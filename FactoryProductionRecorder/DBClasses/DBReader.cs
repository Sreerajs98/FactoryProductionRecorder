using AppCode;
using MyExcelClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FactoryProductionRecorder;
using System.Drawing.Imaging;
using System.Reflection;

namespace DBClasses
{
    internal class DBReader
    {
        public static DataTable GetEmployeeDetails(string UserLogin)
        {
            string newQry = @"SELECT   Emp.EmpId
                                      ,TRIM (Emp.FirstName) as FirstName
                                      ,TRIM (Emp.LastName) as LastName
                                      ,TRIM (Emp.EmpName) as EmpName
                                      ,TRIM (Emp.Desig) as Desig
                                      ,Emp.DepId
                                      ,DP.DepName
                                      ,EI.EmpInitial as EmpInitial
                                      ,'' as SavedBy
                                      ,'' as SavedOn
                                      ,Emp.EmpGrpId
                                      ,Emp.LWD
                                      ,Emp.Status
                                      ,Emp.OTAllow
                                      ,Emp.Reporting
                                      ,Emp.DOJ
                                      ,Emp.Location
                                      ,Emp.Region
                                      ,TRIM (Emp.EmailId) as EmailId
                                      ,TRIM (Emp.Alias) as Alias
                                  FROM Employee as Emp 
                                  INNER JOIN Department as DP ON Emp.DepId = DP.DepId 
                                  LEFT JOIN EmpInitials as EI ON Emp.EmpId = EI.EmployeeID
                                  where Emp.Status = 'Active' And Alias = '" + UserLogin + "' order by TRIM (DP.DepName), TRIM (Emp.Location) DESC, TRIM (Emp.Desig), TRIM (Emp.FirstName)";


            DataTable TempDt = DBReader.CollectedfromTable2(newQry);
            //DataView DV = new DataView(TempDt);

            return TempDt;
        }
        public static DataTable EmailIdForRelease(string ModuleNumber, string EmailType)
        {
            string newQry = @"SELECT    [AppID]
                                      ,[EmpID]
                                      ,[EmpEmailID]
                                      ,[EmailTO]
                                      ,[EmailCC]
                                      ,[EmailType]
                                      ,[RefGroup]
                                 FROM [EmailGroupList] where AppID = " + ModuleNumber + " and Trim(EmailType) like '" + EmailType + "%'";

            //CHK to GRM Ready to Release

            DataTable TempDt = DBReader.CollectedfromTable1(newQry);
            return TempDt;
        }

        public static string GetTheEnquiryNumber(string JobNumber)
        {
            string EnqCode = "";

            string newQry = @"SELECT   jb.[Id]
                                      ,jb.[AreaPrefix]
                                      ,jb.[JobPrefix]
                                      ,jb.[JobNumber]
                                      ,jb.[JobCode]
                                      ,jb.[HOQID]
	                                  ,inq.[HOQCode]
	                                  ,inq.[EstimationNotes]
                          FROM [Jobs] jb
                          INNER JOIN[Inquiries] as inq ON(inq.ID = jb.[HOQID]) where jb.[JobCode] like '%" + JobNumber + "'";

            DataTable TempDt = DBReader.CollectedfromTable3(newQry);


            if (TempDt.Rows.Count > 0) EnqCode = TempDt.Rows[0]["HOQCode"].ToString();
            else EnqCode = "";


            return EnqCode;
        }        
        public static string GetSqlDateTime(string GivenFormat)
        {
            string result = "";

            SqlServerDB newSql = new SqlServerDB();
            newSql.openConnection2();

            try
            {
                string sql = @"SELECT Format(getdate(), '" + GivenFormat + "')";

                SqlDataReader readerVal = newSql.getReader2(sql);

                if (readerVal.HasRows)
                {
                    while (readerVal.Read())
                    {
                        result = readerVal.GetValue(0).ToString();
                    }
                }

                newSql.closeConnection2();
            }
            catch
            {
                newSql.closeConnection2();
            }

            return result;
        }
        
        public static DataTable CollectedfromTable1(string sqlQry)
        {
            DataTable MyDataTable = new DataTable();

            SqlServerDB newSql = new SqlServerDB();
            newSql.openConnection1();

            try
            {
                SqlDataAdapter myAdapter = newSql.getAdapter1(sqlQry);
                myAdapter.Fill(MyDataTable);
                newSql.closeConnection1();
            }
            catch (Exception ep)
            {
                newSql.closeConnection1();
                MessageBox.Show(ep.Message);
            }

            return MyDataTable;
        }
        public static DataTable CollectedfromTable2(string sqlQry)
        {
            DataTable MyDataTable = new DataTable();

            SqlServerDB newSql = new SqlServerDB();
            newSql.openConnection2();

            try
            {
                SqlDataAdapter myAdapter = newSql.getAdapter2(sqlQry);
                myAdapter.Fill(MyDataTable);
                newSql.closeConnection2();
            }
            catch (Exception ep)
            {
                newSql.closeConnection2();
                MessageBox.Show(ep.Message);
            }

            return MyDataTable;
        }
        public static DataTable CollectedfromTable3(string sqlQry)
        {
            DataTable MyDataTable = new DataTable();

            SqlServerDB newSql = new SqlServerDB();
            newSql.openConnection3();

            try
            {
                SqlDataAdapter myAdapter = newSql.getAdapter3(sqlQry);
                myAdapter.Fill(MyDataTable);
                newSql.closeConnection3();
            }
            catch (Exception ep)
            {
                newSql.closeConnection3();
                MessageBox.Show(ep.Message);
            }

            return MyDataTable;
        }
        public static DataTable CollectedfromTable5(string sqlQry)
        {
            DataTable MyDataTable = new DataTable();

            SqlServerDB newSql = new SqlServerDB();
            newSql.openConnection5();

            try
            {
                SqlDataAdapter myAdapter = newSql.getAdapter5(sqlQry);
                myAdapter.Fill(MyDataTable);
                newSql.closeConnection5();
            }
            catch (Exception ep)
            {
                newSql.closeConnection5();
                MessageBox.Show(ep.Message);
            }

            return MyDataTable;
        }



        //-------------------------------PIM-----------------------------------//
        public static DataTable GetJobDataFromPIM(string ThePhaseCode)
        {
            string newQry = @"SELECT ph.BuildingCode
                                      ,ph.BuildingRev
                                      ,ph.PhaseCode
                                      ,ph.PhaseNumber
                                      ,ph.PhaseTypeId
	                                  ,Py.PhaseDesc
                                      ,ph.EstimatedWeight
	                                  ,BL.JobCode
	                                  ,JB.ProjectName
	                                  ,JB.CustomerId
	                                  ,PT.Name as Customer
                                      ,ph.IsActive
                                  FROM Phases as ph
                                  INNER JOIN PhaseTypes as Py ON (Py.Id = ph.PhaseTypeId AND Py.IsActive = 1)
                                  INNER JOIN Buildings as BL ON (BL.BuildingCode = ph.BuildingCode AND BL.IsActive = 1)
                                  INNER JOIN JOBS as JB ON (JB.JobCode = BL.JobCode AND JB.IsActive = 1)
                                  LEFT JOIN parties as PT ON (PT.Id = JB.CustomerId ) --AND PT.IsActive = 1
                                  where ph.PhaseNumber in (select MAX(phs.PhaseNumber) from Phases as phs where phs.PhaseCode like '" + ThePhaseCode + @"' AND phs.IsActive = 1)
                                  and ph.PhaseCode like '" + ThePhaseCode + "'";

            DataTable TempDt = DBReader.CollectedfromTable3(newQry);
            return TempDt;
        }
        public static DataTable GetJobAreaCodeAndJobCode(string JobNumber)
        {
            string newQry = @"SELECT jb.[Id]
                                              ,jb.[AreaPrefix]
                                              ,jb.[JobPrefix]
                                              ,jb.[JobNumber]
                                              ,jb.[JobCode]
											  ,jb.[PMDEngineerId]
											  ,ep.[EmpDetails]
                                  FROM Jobs as jb
								  INNER JOIN [EmpLookups] as ep ON (ep.[Id] = jb.[PMDEngineerId])
                                               where jb.[JobNumber] = " + JobNumber;

            DataTable TempDt = DBReader.CollectedfromTable3(newQry);
            return TempDt;

        }
        public static DataTable GetJobAreaCode(string JobCode)
        {
            string newQry = @"SELECT jb.[Id]
                                              ,jb.[AreaPrefix]
                                              ,jb.[JobPrefix]
                                              ,jb.[JobNumber]
                                              ,jb.[JobCode]
											  ,jb.[PMDEngineerId]
											  ,ep.[EmpDetails]
                                  FROM Jobs as jb
								  INNER JOIN [EmpLookups] as ep ON (ep.[Id] = jb.[PMDEngineerId])
                                               where jb.[JobCode] like '%" + JobCode + "'";

            DataTable TempDt = DBReader.CollectedfromTable3(newQry);
            return TempDt;

        }

        //-------------------------------PRODUCTION STATUS-----------------------//

        public static DataTable LoadGivenStationDataFull(string theDB, string theDate, bool isDaily, bool isMonthly, bool isYearly)
        {
            string dateFilterstring = "FORMAT(sr.[TRANSFEREDON], 'yyyy-MM-dd') = '" + theDate + "'"; //FORMAT(sr.[TRANSFEREDON], 'yyyy-MM') = '2025-10'            
            if (isMonthly) dateFilterstring = "FORMAT(sr.[TRANSFEREDON], 'yyyy-MM') = '" + theDate + "'";
            else if (isYearly) dateFilterstring = "FORMAT(sr.[TRANSFEREDON], 'yyyy') = '" + theDate + "'";


            string newQry = @"-- Final query to get individual records + group total weight info
                            WITH WeightCTE AS (
                                SELECT 
                                    AYT.PARTASSMPHASEID AS PHASEID, 
                                    AYT.PARTASSMPOS AS ASSMPOS,  
                                    SUM(CASE 
                                        WHEN AYT.PARTPOS LIKE 'FL%' OR AYT.PARTPOS LIKE 'WB%' THEN AYT.PARTTOTWEIGHT 
                                        ELSE 0 
                                    END) AS UWeight_FL_WB,
                                    SUM(CASE 
                                        WHEN AYT.PARTPOS NOT LIKE 'FL%' AND AYT.PARTPOS NOT LIKE 'WB%' THEN AYT.PARTTOTWEIGHT 
                                        ELSE 0 
                                    END) AS UWeight_Others
                                FROM 
                                    [eEngineering].[dbo].[Bom_Main_PartTable] AYT 
                                GROUP BY 
                                    AYT.PARTASSMPHASEID,
                                    AYT.PARTASSMPOS
                            )

                            SELECT 
                                    sr.[PHASEID],
                                    sr.[ASSMPOS],
                                    sr.[ASSMNAME],
                                    SUM(sr.[ASSMQTY]) AS ASSMQTY,  -- Sum per PHASEID + ASSMPOS
                                    LEFT(AYT.[ASSMOVERALL], CHARINDEX('x', AYT.[ASSMOVERALL]) - 1) AS BOMLENGTH,
                                    sr.[UNITWEIGHT],
                                    AYT.[ASSMREMARKS],
                                    sr.[STATUS],
                                    FORMAT(sr.[TRANSFEREDON], 'dd-MMM-yyyy') as TRANSFEREDON,
                                    sr.[THELOCK],
                                    sr.[SHIFT],
                                    sr.[BAYID],
                                    -- Calculated weight (preferring FL/WB if available)
                                    CASE 
                                        WHEN ISNULL(wt.UWeight_FL_WB, 0) <> 0 THEN wt.UWeight_FL_WB
                                        ELSE wt.UWeight_Others
                                    END AS UNITWEIGHT_ACT
                            FROM 
                                [eProduction].[dbo].[ProdStatus_Records] sr

                                -- Join to get latest assembly revision
                                INNER JOIN [eEngineering].[dbo].[Bom_Main_AssemblyTable] AYT 
                                    ON AYT.ASSMPHASEID = sr.PHASEID 
                                    AND AYT.ASSMPOS = sr.ASSMPOS
                                    AND AYT.ASSMREVNO = (
                                        SELECT MAX(AT.ASSMREVNO)
                                        FROM [eEngineering].[dbo].[Bom_Main_AssemblyTable] AT
                                        WHERE AT.ASSMPHASEID = AYT.ASSMPHASEID
                                          AND AT.ASSMPOS = AYT.ASSMPOS
                                    )

                                -- Join calculated part weights
                                LEFT JOIN WeightCTE wt
                                    ON sr.[PHASEID] = wt.[PHASEID] 
                                    AND sr.[ASSMPOS] = wt.[ASSMPOS]

                            -- Filters --sr.[ONDATE]
                            WHERE 
                                sr.[STATUS] LIKE '%Q'
                                AND sr.[THELOCK] LIKE 'L'
                                AND " + dateFilterstring + @"
                            -- Grouping (must include all selected non-aggregated fields)
                            GROUP BY 
                                sr.[PHASEID],
                                sr.[ASSMPOS],
                                sr.[ASSMNAME],
                                sr.[UNITWEIGHT],
                                AYT.[ASSMOVERALL],
                                AYT.[ASSMREMARKS],
                                sr.[STATUS],
                                sr.[TRANSFEREDON],
                                sr.[THELOCK],
                                sr.[SHIFT],
                                sr.[BAYID],
                                wt.UWeight_FL_WB,
                                wt.UWeight_Others
                            ";

            DataTable TempDt = DBReader.CollectedfromTable5(newQry);
            return TempDt;
        }

        public static DataTable LoadAllProcessingDatas(string theDB, string theStatus, string transStatus)
        {

            //string newQry = @"-- CTE for current SWC records
            //                    WITH SumAssmQtyCTE AS ( 
            //                        SELECT 
            //                            sr.[PHASEID],
            //                            sr.[ASSMPOS],
            //                            SUM(sr.[ASSMQTY]) AS TotalAssmQty
            //                        FROM 
            //                            [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
            //                        WHERE
            //                            sr.[STATUS] = '" + theStatus + @"' 
            //                            AND sr.[THELOCK] = 'P'
            //                        GROUP BY
            //                            sr.[PHASEID],
            //                            sr.[ASSMPOS]
            //                    ),

            //                    -- CTE for previously processed SWQ records
            //                    PrevAssmQtyCTE AS (
            //                        SELECT 
            //                            sr.[PHASEID],
            //                            sr.[ASSMPOS],
            //                            SUM(sr.[ASSMQTY]) AS PrevAssmQty
            //                        FROM 
            //                            [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
            //                        WHERE
            //                            sr.[STATUS] = '" + transStatus + @"'
            //                        GROUP BY
            //                            sr.[PHASEID],
            //                            sr.[ASSMPOS]
            //                    )

            //                    -- Final main query
            //                    SELECT 
            //                        sr.[PHASEID],
            //                        sr.[ASSMPOS],
            //                        MAX(sr.[ASSMNAME]) AS ASSMNAME,
            //                        sa.TotalAssmQty AS ASSMQTY,
            //                        ISNULL(pa.PrevAssmQty, 0) AS PREVQTY,  -- <-- NEW COLUMN
            //                        MAX(AYT.[ASSMQTY]) AS BOMQTY,
            //                        MAX(sr.[UNITWEIGHT]) AS UNITWEIGHT,
            //                        MAX(sr.[ONDATE]) AS ONDATE,
            //                        MAX(sr.[RECORDEDBY]) AS RECORDEDBY,
            //                        MAX(sr.[RECORDEDON]) AS RECORDEDON,
            //                        MAX(sr.[STATUS]) AS STATUS,
            //                        MAX(sr.[THELOCK]) AS THELOCK
            //                    FROM 
            //                        [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
            //                    INNER JOIN 
            //                        [eEngineering" + theDB + @"].[dbo].[Bom_Main_AssemblyTable] AYT 
            //                        ON AYT.ASSMPHASEID = sr.PHASEID 
            //                        AND AYT.ASSMPOS = sr.ASSMPOS
            //                        AND AYT.ASSMREVNO = (
            //                            SELECT MAX(AT.ASSMREVNO)
            //                            FROM [eEngineering" + theDB + @"].[dbo].[Bom_Main_AssemblyTable] AT 
            //                            WHERE AT.ASSMPHASEID = AYT.ASSMPHASEID
            //                              AND AT.ASSMPOS = AYT.ASSMPOS
            //                        )
            //                    -- Join current quantity summary
            //                    INNER JOIN SumAssmQtyCTE sa
            //                        ON sr.[PHASEID] = sa.[PHASEID]
            //                        AND sr.[ASSMPOS] = sa.[ASSMPOS]

            //                    -- Left join previous quantity summary
            //                    LEFT JOIN PrevAssmQtyCTE pa
            //                        ON sr.[PHASEID] = pa.[PHASEID]
            //                        AND sr.[ASSMPOS] = pa.[ASSMPOS]

            //                    WHERE 
            //                        sr.[STATUS] = '" + theStatus + @"'
            //                        AND sr.[THELOCK] = 'P'

            //                    GROUP BY 
            //                        sr.[PHASEID],
            //                        sr.[ASSMPOS],
            //                        sa.TotalAssmQty,
            //                        pa.PrevAssmQty

            //                    ORDER BY 
            //                        sr.[PHASEID], 
            //                        sr.[ASSMPOS]";


            string newQry = @"-- CTE for current SWC records
                            WITH SumAssmQtyCTE AS (
                                SELECT 
                                    sr.[PHASEID], 
                                    sr.[ASSMPOS], 
                                    SUM(sr.[ASSMQTY]) AS TotalAssmQty
                                FROM 
                                        [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
                                WHERE
                                        sr.[STATUS] = '" + theStatus + @"' 
                                        AND sr.[THELOCK] = 'P'
                                GROUP BY 
                                        sr.[PHASEID], sr.[ASSMPOS]
                            ),
                            -- CTE for previously processed SWQ records
                            PrevAssmQtyCTE AS (
                                SELECT 
                                    sr.[PHASEID], 
                                    sr.[ASSMPOS], 
                                    SUM(sr.[ASSMQTY]) AS PrevAssmQty
                                FROM 
                                        [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
                                WHERE
                                        sr.[STATUS] = '" + transStatus + @"'
                                        and sr.[THELOCK] in ( 'O', 'P', 'L')
                                GROUP BY 
                                        sr.[PHASEID], sr.[ASSMPOS]
                            ),
                            -- CTE for comma-separated REFIDs
                            RefIdsCTE AS (
                                SELECT 
                                    sr.[PHASEID], 
                                    sr.[ASSMPOS], 
                                    STRING_AGG(CAST(sr.[REFID] AS VARCHAR(MAX)), ',') AS REFIDS
                                FROM 
                                        [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
                                WHERE
                                        sr.[STATUS] = '" + theStatus + @"' 
                                        AND sr.[THELOCK] = 'P'
                                GROUP BY 
                                        sr.[PHASEID], sr.[ASSMPOS]
                            )

                            -- Final main query
                            SELECT 
                                sr.[PHASEID], 
                                sr.[ASSMPOS], 
                                MAX(sr.[ASSMNAME]) AS ASSMNAME,
                                sa.TotalAssmQty AS ASSMQTY,
                                ISNULL(pa.PrevAssmQty, 0) AS PREVQTY,
                                MAX(AYT.[ASSMQTY]) AS BOMQTY,
                                MAX(sr.[UNITWEIGHT]) AS UNITWEIGHT,
                                MAX(sr.[ONDATE]) AS ONDATE,
                                MAX(sr.[RECORDEDBY]) AS RECORDEDBY,
                                MAX(sr.[RECORDEDON]) AS RECORDEDON,
                                MAX(sr.[STATUS]) AS STATUS,
                                MAX(sr.[THELOCK]) AS THELOCK,
                                rct.REFIDS as REFID, -- <-- New column: Comma-separated REFIDs,
                                MAX(sr.[BAYID]) AS BAYID
                            FROM [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
                            INNER JOIN [eEngineering" + theDB + @"].[dbo].[Bom_Main_AssemblyTable] AYT
                                ON AYT.ASSMPHASEID = sr.PHASEID 
                                AND AYT.ASSMPOS = sr.ASSMPOS 
                                AND AYT.ASSMREVNO = (
                                    SELECT MAX(AT.ASSMREVNO) 
                                    FROM [eEngineering" + theDB + @"].[dbo].[Bom_Main_AssemblyTable] AT 
                                    WHERE AT.ASSMPHASEID = AYT.ASSMPHASEID AND AT.ASSMPOS = AYT.ASSMPOS
                                )
                            -- Join current quantity summary
                            INNER JOIN SumAssmQtyCTE sa 
                                ON sr.[PHASEID] = sa.[PHASEID] AND sr.[ASSMPOS] = sa.[ASSMPOS]
                            -- Left join previous quantity summary
                            LEFT JOIN PrevAssmQtyCTE pa 
                                ON sr.[PHASEID] = pa.[PHASEID] AND sr.[ASSMPOS] = pa.[ASSMPOS]
                            -- Join REFID aggregation
                            LEFT JOIN RefIdsCTE rct 
                                ON sr.[PHASEID] = rct.[PHASEID] AND sr.[ASSMPOS] = rct.[ASSMPOS]
                            WHERE sr.[STATUS] = '" + theStatus + @"' AND sr.[THELOCK] = 'P'
                            GROUP BY 
                                sr.[PHASEID], 
                                sr.[ASSMPOS], 
                                sa.TotalAssmQty, 
                                pa.PrevAssmQty, 
                                rct.REFIDS,
                                sr.[BAYID]
                            ORDER BY sr.[PHASEID], sr.[ASSMPOS]";

            DataTable TempDt = DBReader.CollectedfromTable5(newQry);
            return TempDt;
        }

        public static DataTable LoadGivenStationData(string theDB, string theStatus)
        {

            string newQry = @"WITH SumAssmQtyCTE AS (
                                                SELECT 
                                                    sr.[PHASEID],
                                                    sr.[ASSMPOS],
                                                    SUM(sr.[ASSMQTY]) AS TotalAssmQty
                                                FROM 
                                                    [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
                                                WHERE
                                                    sr.[STATUS] = '" + theStatus + @"' AND sr.[THELOCK] in ( 'O' , 'H')
                                                GROUP BY
                                                    sr.[PHASEID],
                                                    sr.[ASSMPOS]
                                            ),
                                            -- CTE for comma-separated REFIDs
                                            RefIdsCTE AS (
                                                SELECT 
                                                    sr.[PHASEID], 
                                                    sr.[ASSMPOS], 
                                                    STRING_AGG(CAST(sr.[REFID] AS VARCHAR(MAX)), ',') AS REFIDS
                                                FROM 
                                                        [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
                                                WHERE
                                                        sr.[STATUS] = '" + theStatus + @"' 
                                                        AND sr.[THELOCK] in ( 'O' , 'H')
                                                GROUP BY 
                                                        sr.[PHASEID], sr.[ASSMPOS]
                                            )

                                            SELECT 
                                                sr.[PHASEID],
                                                sr.[ASSMPOS],
                                                MAX(sr.[ASSMNAME]) AS ASSMNAME,
                                                sa.TotalAssmQty AS ASSMQTY,
                                                MAX(AYT.[ASSMQTY]) AS BOMQTY,
                                                MAX(sr.[UNITWEIGHT]) AS UNITWEIGHT,
                                                MAX(sr.[ONDATE]) AS ONDATE,
                                                MAX(sr.[RECORDEDBY]) AS RECORDEDBY,
                                                MAX(sr.[RECORDEDON]) AS RECORDEDON,
                                                MAX(sr.[STATUS]) AS STATUS,
                                                MAX(sr.[THELOCK]) AS THELOCK,
                                                rct.REFIDS as REFID -- <-- New column: Comma-separated REFIDs
                                            FROM 
                                                [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr 
                                            INNER JOIN 
                                                [eEngineering" + theDB + @"].[dbo].[Bom_Main_AssemblyTable] AYT 
                                                ON AYT.ASSMPHASEID = sr.PHASEID 
                                                AND AYT.ASSMPOS = sr.ASSMPOS
                                                AND AYT.ASSMREVNO = (
                                                    SELECT MAX(AT.ASSMREVNO)
                                                    FROM [eEngineering" + theDB + @"].[dbo].[Bom_Main_AssemblyTable] AT
                                                    WHERE AT.ASSMPHASEID = AYT.ASSMPHASEID
                                                      AND AT.ASSMPOS = AYT.ASSMPOS
                                                )
                                            INNER JOIN
                                                SumAssmQtyCTE sa
                                                ON sr.[PHASEID] = sa.[PHASEID]
                                                AND sr.[ASSMPOS] = sa.[ASSMPOS]
                                            -- Join REFID aggregation
                                            LEFT JOIN RefIdsCTE rct 
                                                ON sr.[PHASEID] = rct.[PHASEID] AND sr.[ASSMPOS] = rct.[ASSMPOS]
                                            WHERE 
                                                sr.[STATUS] = '" + theStatus + @"'
                                                AND sr.[THELOCK] in ( 'O' , 'H')
                                            GROUP BY 
                                                sr.[PHASEID],
                                                sr.[ASSMPOS],
                                                sa.TotalAssmQty,
                                                rct.REFIDS
                                            ORDER BY 
                                                sr.[PHASEID], 
                                                sr.[ASSMPOS]";

            DataTable TempDt = DBReader.CollectedfromTable5(newQry);
            return TempDt;
        }

        public static DataTable LoadAllNextStationData(string theDB, string theStatus)
        {

            string newQry = @"WITH SumAssmQtyCTE AS (
                                                SELECT 
                                                    sr.[PHASEID],
                                                    sr.[ASSMPOS],
                                                    SUM(sr.[ASSMQTY]) AS TotalAssmQty
                                                FROM 
                                                    [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
                                                WHERE
                                                    sr.[STATUS] = '" + theStatus + @"' AND sr.[THELOCK] = 'O'
                                                GROUP BY
                                                    sr.[PHASEID],
                                                    sr.[ASSMPOS]
                                            ),
                                            -- CTE for comma-separated REFIDs
                                            RefIdsCTE AS (
                                                SELECT 
                                                    sr.[PHASEID], 
                                                    sr.[ASSMPOS], 
                                                    STRING_AGG(CAST(sr.[REFID] AS VARCHAR(MAX)), ',') AS REFIDS
                                                FROM 
                                                        [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
                                                WHERE
                                                        sr.[STATUS] = '" + theStatus + @"' 
                                                        AND sr.[THELOCK] = 'O'
                                                GROUP BY 
                                                        sr.[PHASEID], sr.[ASSMPOS]
                                            )

                                            SELECT 
                                                sr.[PHASEID],
                                                sr.[ASSMPOS],
                                                MAX(sr.[ASSMNAME]) AS ASSMNAME,
                                                sa.TotalAssmQty AS ASSMQTY,
                                                MAX(AYT.[ASSMQTY]) AS BOMQTY,
                                                MAX(sr.[UNITWEIGHT]) AS UNITWEIGHT,
                                                MAX(sr.[ONDATE]) AS ONDATE,
                                                MAX(sr.[RECORDEDBY]) AS RECORDEDBY,
                                                MAX(sr.[RECORDEDON]) AS RECORDEDON,
                                                MAX(sr.[STATUS]) AS STATUS,
                                                MAX(sr.[THELOCK]) AS THELOCK,
                                                rct.REFIDS as REFID -- <-- New column: Comma-separated REFIDs
                                            FROM 
                                                [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr 
                                            INNER JOIN 
                                                [eEngineering" + theDB + @"].[dbo].[Bom_Main_AssemblyTable] AYT 
                                                ON AYT.ASSMPHASEID = sr.PHASEID 
                                                AND AYT.ASSMPOS = sr.ASSMPOS
                                                AND AYT.ASSMREVNO = (
                                                    SELECT MAX(AT.ASSMREVNO)
                                                    FROM [eEngineering" + theDB + @"].[dbo].[Bom_Main_AssemblyTable] AT
                                                    WHERE AT.ASSMPHASEID = AYT.ASSMPHASEID
                                                      AND AT.ASSMPOS = AYT.ASSMPOS
                                                )
                                            INNER JOIN
                                                SumAssmQtyCTE sa
                                                ON sr.[PHASEID] = sa.[PHASEID]
                                                AND sr.[ASSMPOS] = sa.[ASSMPOS]
                                            -- Join REFID aggregation
                                            LEFT JOIN RefIdsCTE rct 
                                                ON sr.[PHASEID] = rct.[PHASEID] AND sr.[ASSMPOS] = rct.[ASSMPOS]
                                            WHERE 
                                                sr.[STATUS] = '" + theStatus + @"'
                                                AND sr.[THELOCK] = 'O'
                                            GROUP BY 
                                                sr.[PHASEID],
                                                sr.[ASSMPOS],
                                                sa.TotalAssmQty,
                                                rct.REFIDS
                                            ORDER BY 
                                                sr.[PHASEID], 
                                                sr.[ASSMPOS]";

            DataTable TempDt = DBReader.CollectedfromTable5(newQry);
            return TempDt;
        }

        public static DataTable Load_HandedOver_Assembly_Data(string theDB, string ThePhaseId, string TheAssmPos, string theStatus)
        {

            string newQry = @"WITH SumAssmQtyCTE AS (
                            SELECT 
                                sr.[PHASEID],
                                sr.[ASSMPOS],
                                SUM(sr.[ASSMQTY]) AS TotalAssmQty
                            FROM 
                                [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
                            WHERE
                                sr.[STATUS] = '" + theStatus + @"'
                                AND sr.[THELOCK] != 'P'
                            GROUP BY
                                sr.[PHASEID],
                                sr.[ASSMPOS]
                        ),
                            -- CTE for comma-separated REFIDs
                            RefIdsCTE AS (
                            SELECT 
                                sr.[PHASEID], 
                                sr.[ASSMPOS], 
                                STRING_AGG(CAST(sr.[REFID] AS VARCHAR(MAX)), ',') AS REFIDS
                            FROM 
                                [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
                            WHERE
                                sr.[STATUS] = '" + theStatus + @"' 
                                AND sr.[THELOCK] = 'O'
                            GROUP BY 
                                sr.[PHASEID], sr.[ASSMPOS]
                        )

                        SELECT 
                            sr.[PHASEID],
                            sr.[ASSMPOS],
                            MAX(sr.[ASSMNAME]) AS ASSMNAME,
                            sa.TotalAssmQty AS ASSMQTY,
                            MAX(sr.[UNITWEIGHT]) AS UNITWEIGHT,
                            MAX(sr.[ONDATE]) AS ONDATE,
                            MAX(sr.[RECORDEDBY]) AS RECORDEDBY,
                            MAX(sr.[RECORDEDON]) AS RECORDEDON,
                            MAX(sr.[STATUS]) AS STATUS,
                            MAX(sr.[THELOCK]) AS THELOCK,
                            rct.REFIDS as REFID -- <-- New column: Comma-separated REFIDs
                        FROM 
                            [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr 
                        INNER JOIN
                            SumAssmQtyCTE sa
                            ON sr.[PHASEID] = sa.[PHASEID]
                            AND sr.[ASSMPOS] = sa.[ASSMPOS]
                        -- Join REFID aggregation
                        LEFT JOIN RefIdsCTE rct 
                            ON sr.[PHASEID] = rct.[PHASEID] AND sr.[ASSMPOS] = rct.[ASSMPOS]
                        WHERE 
                            sr.[STATUS] = '" + theStatus + @"'
                            AND sr.[PHASEID] like '%" + ThePhaseId + @"'
                            AND sr.[ASSMPOS] = '" + TheAssmPos + @"'
                        GROUP BY 
                            sr.[PHASEID],
                            sr.[ASSMPOS],
                            sa.TotalAssmQty,
                            rct.REFIDS
                        ORDER BY 
                            sr.[PHASEID], 
                            sr.[ASSMPOS]";


            DataTable TempDt = DBReader.CollectedfromTable5(newQry);
            return TempDt;
        }
        public static DataTable Load_Assembly_Datas_Next(string theDB, string ThePhaseId, string TheAssmPos, string theCurrStatus, string theNextStatus)
        {

            string newQry = @"
                        SELECT 
                            sr.[ID],
                            sr.[PHASEID] AS ASSMPHASEID,
                            sr.[ASSMPOS],
                            sr.[ASSMQTY] AS ASSMQTY,
                            sr.[ASSMNAME],
                            sr.[UNITWEIGHT] AS ASSMUNITWEIGHT,
                            sr.[ONDATE],
                            sr.[RECORDEDBY],
                            sr.[RECORDEDON],
                            sr.[STATUS] AS STATUS,
                            sr.[THELOCK],
                            sr.[REFID]
                        FROM 
                            [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr 
                        WHERE 
                                sr.[PHASEID] like '%" + ThePhaseId + @"'
                            AND sr.[ASSMPOS] = '" + TheAssmPos + @"'
                            AND (
                                   (sr.[STATUS] =  '" + theNextStatus + @"' AND sr.[THELOCK] IN ('O', 'P', 'L'))
                                OR (sr.[STATUS] =  '" + theCurrStatus + @"' AND sr.[THELOCK] = 'P')
                                )
                        ORDER BY 
                            sr.[PHASEID], 
                            sr.[ASSMPOS]";


            DataTable TempDt = DBReader.CollectedfromTable5(newQry);
            return TempDt;
        }
        public static DataTable Load_Assembly_Datas_Current(string theDB, string ThePhaseId, string TheAssmPos, string theStatus)
        {

            string newQry = @"
                        SELECT 
                            sr.[ID],
                            sr.[PHASEID] AS ASSMPHASEID,
                            sr.[ASSMPOS],
                            sr.[ASSMQTY] AS ASSMQTY,
                            sr.[ASSMNAME],
                            sr.[UNITWEIGHT] AS ASSMUNITWEIGHT,
                            sr.[ONDATE],
                            sr.[RECORDEDBY],
                            sr.[RECORDEDON],
                            sr.[STATUS] AS STATUS,
                            sr.[THELOCK],
                            sr.[REFID]
                        FROM 
                            [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr 
                        WHERE 
                            sr.[STATUS] = '" + theStatus + @"'
                            AND sr.[PHASEID] like '%" + ThePhaseId + @"'
                            AND sr.[ASSMPOS] = '" + TheAssmPos + @"'
                            AND sr.[THELOCK] in ( 'O', 'P')
                        ORDER BY 
                            sr.[PHASEID], 
                            sr.[ASSMPOS]";


            DataTable TempDt = DBReader.CollectedfromTable5(newQry);
            return TempDt;
        }

        public static DataTable Load_TheAssembly_Log(string theDB, string ThePhaseId, string AssmPos)
        {

            string newQry = @"WITH SumAssmQtyCTE AS(
                                            SELECT
                                                sr.[PHASEID],
                                                sr.[ASSMPOS],
                                                SUM(sr.[ASSMQTY]) AS TotalAssmQty
                                            FROM
                                                [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
                                            WHERE
                                                sr.[PHASEID] like '%" + ThePhaseId + @"'
                                                AND sr.[ASSMPOS] like '" + AssmPos + @"'
                                                AND sr.[THELOCK] in ('L', 'P')
                                                AND sr.[REFID] = 0
                                            GROUP BY
                                                sr.[PHASEID],
                                                sr.[ASSMPOS]
                                        )
                                        SELECT
                                            AYT.[ASSMPHASEID] AS PHASEID,
                                            AYT.[ASSMPOS],
                                            MAX(AYT.[ASSMNAME]) AS ASSMNAME,
                                            ISNULL(sa.TotalAssmQty, 0) AS PROCESSEDQTY,
                                            MAX(AYT.[ASSMQTY]) AS ENGBOMQTY,
                                            MAX(AYT.[ASSMQTY]) -ISNULL(sa.TotalAssmQty, 0) AS BALANCEQTY,
                                            CASE
                                                WHEN MAX(AYT.[ASSMQTY]) -ISNULL(sa.TotalAssmQty, 0) = 0 THEN 'Completed'
                                                ELSE 'Pending'
                                            END AS PRODSTATUS
                                        FROM
                                            [eEngineering" + theDB + @"].[dbo].[Bom_Main_AssemblyTable] AYT
                                        LEFT JOIN
                                            [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
                                            ON AYT.ASSMPHASEID = sr.PHASEID
                                            AND AYT.ASSMPOS = sr.ASSMPOS
                                            AND sr.THELOCK IN('L', 'P') 
                                            AND sr.REFID = 0
                                        LEFT JOIN
                                            SumAssmQtyCTE sa
                                            ON AYT.ASSMPHASEID = sa.PHASEID
                                            AND AYT.ASSMPOS = sa.ASSMPOS
                                        WHERE
                                            AYT.ASSMPHASEID LIKE '%" + ThePhaseId + @"'
                                            AND AYT.ASSMPOS LIKE '" + AssmPos + @"'
                                            AND AYT.ASSMREVNO <= (
                                                SELECT MAX(taskrevision)
                                                FROM[eEngineering" + theDB + @"].[dbo].[Master_EngScheduler] rr
                                                WHERE
                                                    rr.[taskid] = AYT.ASSMPHASEID
                                                    AND rr.department_status = 'PPC'
                                            )
                                        GROUP BY
                                            AYT.[ASSMPHASEID],
                                            AYT.[ASSMPOS],
                                            ISNULL(sa.TotalAssmQty, 0)
                                        ORDER BY
                                            AYT.[ASSMPHASEID], 
                                            AYT.[ASSMPOS], 
                                            PRODSTATUS";

            DataTable TempDt = DBReader.CollectedfromTable5(newQry);
            return TempDt;
        }

        public static DataTable Load_AllAssembly_Log(string theDB, string ThePhaseId, string TheStatus)
        {
            string newQry = @"WITH SumAssmQtyCTE AS (
                                                SELECT 
                                                    sr.[PHASEID],
                                                    sr.[ASSMPOS],
                                                    SUM(sr.[ASSMQTY]) AS TotalAssmQty
                                                FROM 
                                                    [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
                                                WHERE
                                                    sr.[PHASEID] like '%"+ ThePhaseId + @"' 
													AND sr.[STATUS] like '%"+ TheStatus + @"'
													AND sr.[THELOCK] in ( 'L', 'P')
                                                GROUP BY
                                                    sr.[PHASEID],
                                                    sr.[ASSMPOS]
                                            )											
                                            SELECT 
                                                sr.[PHASEID],
                                                sr.[ASSMPOS],
                                                MAX(sr.[ASSMNAME]) AS ASSMNAME,
                                                sa.TotalAssmQty AS PROCESSEDQTY,
                                                MAX(AYT.[ASSMQTY]) AS ENGBOMQTY,
												MAX(AYT.[ASSMQTY]) - sa.TotalAssmQty as BALANCEQTY,
                                                CASE 
                                                        WHEN MAX(AYT.[ASSMQTY]) - sa.TotalAssmQty = 0 THEN 'Completed'
                                                        ELSE 'Pending'
                                                    END AS PRODSTATUS
                                            FROM 
                                                [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr 
                                            INNER JOIN 
                                                [eEngineering" + theDB + @"].[dbo].[Bom_Main_AssemblyTable] AYT 
                                                ON AYT.ASSMPHASEID = sr.PHASEID 
                                                AND AYT.ASSMPOS = sr.ASSMPOS
                                                AND AYT.ASSMREVNO <= (
                                            SELECT MAX(taskrevision) AS Rev
                                            FROM [eEngineering" + theDB + @"].[dbo].[Master_EngScheduler] rr
                                            WHERE 
                                                rr.[taskid] = sr.[PHASEID]
                                                AND rr.department_status = 'PPC'
                                                )
                                            INNER JOIN
                                                SumAssmQtyCTE sa
                                                ON sr.[PHASEID] = sa.[PHASEID]
                                                AND sr.[ASSMPOS] = sa.[ASSMPOS]
                                            WHERE 
                                                sr.[PHASEID] like '%" + ThePhaseId + @"' 
												AND sr.[STATUS] like '%"+ TheStatus + @"'
                                                AND sr.[THELOCK] in ( 'L', 'P')
                                            GROUP BY 
                                                sr.[PHASEID],
                                                sr.[ASSMPOS],
                                                sa.TotalAssmQty
                                            ORDER BY 
                                                sr.[PHASEID], 
                                                sr.[ASSMPOS], 
                                                PRODSTATUS";


            DataTable TempDt = DBReader.CollectedfromTable5(newQry);
            return TempDt;
        }

        public static DataTable Load_AllAssembly_DistributionDatas(string theDB, string ThePhaseId, string TheAssmPos, string StatusGroup)
        {

            string newQry = @"
                        SELECT 
                            sr.[ID],
                            sr.[PHASEID] AS ASSMPHASEID,
                            sr.[ASSMPOS],
                            sr.[ASSMQTY] AS ASSMQTY,
                            sr.[ASSMNAME],
                            sr.[UNITWEIGHT] AS ASSMUNITWEIGHT,
                            sr.[ONDATE],
                            sr.[RECORDEDBY],
                            sr.[RECORDEDON],
                            sr.[STATUS] AS STATUS,
                            sc.[Description] AS Station,
                            sc.[Seq] AS StationSeq,
                            ss.[Description] AS THELOCK,
                            sr.[THELOCK] AS ACTTHELOCK,
                            '' AS Remark,
                            sr.[REFID],
                            sr.[SHIFT],
                            sr.[BAYID]
                        FROM 
                            [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr
                        RIGHT JOIN 
							[eProduction" + theDB + @"].[dbo].[StatusConfig] sc 
							ON sr.[STATUS] = sc.[StatusLabel] AND sc.[StatusUsed]  like '" + StatusGroup + @"'
                        RIGHT JOIN 
							[eProduction" + theDB + @"].[dbo].[SubStatus] ss 
							ON sr.[THELOCK] = ss.[Prefix]
                        WHERE 
                            sr.[PHASEID] like '%" + ThePhaseId + @"%'
                            AND sr.[ASSMPOS] = '" + TheAssmPos + @"'
                            AND sr.[THELOCK] IN ('O', 'P')
                        ORDER BY
                            sr.[PHASEID], sr.[ASSMPOS], sc.[Description]";


            DataTable TempDt = DBReader.CollectedfromTable5(newQry);
            return TempDt;
        }

        public static DataTable Load_AllAssembly_LogDatas(string theDB, string ThePhaseId, string TheAssmPos)
        {

            string newQry = @"
                        SELECT 
                              -- [PHASEID]
                              [REFID]
                              ,[ASSMPOS]
                              ,[NEWASSMPOS]
                              ,[CURRENTSTATUS]
                              ,[NEWSTATUS]
                              ,[MODIFIEDBY]
                              ,[MODIFIEDON]
                              ,[UPDATETYPE]
                        FROM 
                            [eProduction" + theDB + @"].[dbo].[ProdStatus_Record_Changes]
                        WHERE 
                            [PHASEID] like '%" + ThePhaseId + @"%'
                            AND [ASSMPOS] = '" + TheAssmPos + @"'
                        ORDER BY
                            [PHASEID] ASC, [ASSMPOS] ASC , [MODIFIEDON] DESC";


            DataTable TempDt = DBReader.CollectedfromTable5(newQry);
            return TempDt;
        }
        
        public static DataTable Load_OpenedAssembly_Datas(string theDB, string ThePhaseId, string TheAssmPos, string theStatus)
        {

            string newQry = @"
                        SELECT 
                            sr.[ID],
                            sr.[PHASEID] AS ASSMPHASEID,
                            sr.[ASSMPOS],
                            sr.[ASSMQTY] AS ASSMQTY,
                            sr.[ASSMNAME],
                            sr.[UNITWEIGHT] AS ASSMUNITWEIGHT,
                            sr.[ONDATE],
                            sr.[RECORDEDBY],
                            sr.[RECORDEDON],
                            sr.[STATUS] AS STATUS,
                            sr.[THELOCK],
                            sr.[REFID]
                        FROM 
                            [eProduction" + theDB + @"].[dbo].[ProdStatus_Records] sr 
                        WHERE 
                            sr.[STATUS] = '" + theStatus + @"'
                            AND sr.[PHASEID] like '%" + ThePhaseId + @"'
                            AND sr.[ASSMPOS] = '" + TheAssmPos + @"'
                            AND sr.[THELOCK] IN ('O', 'H')
                        ORDER BY 
                            sr.[PHASEID], 
                            sr.[ASSMPOS]";


            DataTable TempDt = DBReader.CollectedfromTable5(newQry);
            return TempDt;
        }

        public static DataTable AllStatusData(string theDB)
        {
            string newQry = @"SELECT  [Seq]
                                     ,[StatusLabel]
                                     ,[StatusUsed]
                                     ,[Description]
                                 FROM [eProduction" + theDB + @"].[dbo].[StatusConfig]";


            DataTable TempDt = DBReader.CollectedfromTable1(newQry);
            return TempDt;
        }

        public static DataTable AllStatusData(string theDB, string theSufix)
        {
            string newQry = @"SELECT  [Seq]
                                     ,[StatusLabel]
                                     ,[StatusUsed]
                                     ,[Description]
                                 FROM [eProduction" + theDB + @"].[dbo].[StatusConfig]  where StatusLabel like '%" + theSufix + "'";


            DataTable TempDt = DBReader.CollectedfromTable1(newQry);
            return TempDt;
        }

        public static DataTable AllSubStatusData(string theDB)
        {
            string newQry = @"SELECT  [Seq]
                                     ,[Prefix]
                                     ,[Description]
                                 FROM [eProduction" + theDB + @"].[dbo].[SubStatus]";


            DataTable TempDt = DBReader.CollectedfromTable1(newQry);
            return TempDt;
        }

        public static DataTable AllSavedJobs(string thePhaseId)
        {
            string newQry = @"SELECT distinct(PHASEID)
                                  FROM  Production_Status_Records 
                                  where PHASEID LIKE '" + thePhaseId + "' AND ISACTIVE = 0";


            DataTable TempDt = DBReader.CollectedfromTable1(newQry);
            return TempDt;
        }

        public static DataTable EngineeringBOMData(string thePhaseId, string theAssmPos, string theRevNum)
        {
            string newQry =  @"SELECT 
                                                AYT.ASSMPHASEID, 
                                                AYT.ASSMPOS, 
                                                AYT.ASSMQTY, 
                                                AYT.ASSMREVNO, 
                                                AYT.ASSMUNITWEIGHT, 
                                                AYT.ASSMNAME, 
                                                0 AS RefID
                                            FROM 
                                                Bom_Main_AssemblyTable AYT
                                            WHERE 
                                                AYT.ASSMPHASEID LIKE '%" + thePhaseId + @"'
                                                AND AYT.ASSMPOS LIKE '" + theAssmPos + @"'
                                                AND AYT.ASSMREVNO IN (
                                                    SELECT 
                                                        MAX(AT.ASSMREVNO)
                                                    FROM 
                                                        Bom_Main_AssemblyTable AT
                                                    WHERE 
                                                        AT.ASSMPHASEID LIKE '%" + thePhaseId + @"'
                                                        AND AT.ASSMPOS LIKE '" + theAssmPos + @"'
                                                        AND AT.ASSMREVNO <= " + theRevNum +
                                                        @"AND AT.ASSMPHASEID = AYT.ASSMPHASEID
                                                        AND AT.ASSMPOS = AYT.ASSMPOS
                                                    GROUP BY 
                                                        AT.ASSMPHASEID, 
                                                        AT.ASSMPOS )";


            DataTable TempDt = DBReader.CollectedfromTable1(newQry);
            return TempDt;
        }

        public static bool IsPhaseIDReleased(string PhaseId)
        {
            bool result = false;

            SqlServerDB newSql = new SqlServerDB();
            newSql.openConnection1();

            try
            {
                string sql = @"SELECT * FROM [Production_Status_Scheduler] where PHASEID like '" + PhaseId + "' and YEAR = " + Cart.TheSelectedYear + " and MONTH like '" + Cart.TheSelectedMonth + "' and STATUS like 'Completed'";

                SqlDataReader readerVal = newSql.getReader1(sql);

                if (readerVal.HasRows)
                {
                    while (readerVal.Read())
                    {
                        if (readerVal.GetValue(0) != null)
                        {
                            result = true; break;   
                        }
                    }
                }

                newSql.closeConnection1();
            }
            catch
            {
                newSql.closeConnection1();
                result = false;
            }

            return result;
        }

        public static bool Select_TranferedData(string PhaseId, string AssmPos, string NewStatus, string TheNextLock, string TheRefId)
        {
            bool isSuccess = false;

            //string TheRefId = "0";

            try
            {
                string newQry = @"SELECT * FROM ProdStatus_Records where [PHASEID] = '" + PhaseId + "' AND [ASSMPOS] = '" + AssmPos + "' AND [STATUS] = '" + NewStatus + "' AND [THELOCK] = '" + TheNextLock + "' AND [REFID] = '" + TheRefId + "'";

                DataTable TempDt = DBReader.CollectedfromTable5(newQry);

                if (TempDt.Rows.Count > 0)
                {
                    isSuccess = true;
                }
                else
                    isSuccess = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Select_TranferedData " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }

        public static bool Select_TranferedData(string PhaseId, string AssmPos, string NewStatus, string TheNextLock, ref string TheRefId)
        {
            bool isSuccess = false;

            try
            {
                string newQry = @"SELECT * FROM ProdStatus_Records where [PHASEID] = '" + PhaseId + "' AND [ASSMPOS] = '" + AssmPos + "' AND [STATUS] = '" + NewStatus + "' AND [THELOCK] = '" + TheNextLock + "' AND [REFID] = '" + TheRefId + "'";

                DataTable TempDt = DBReader.CollectedfromTable5(newQry);

                if (TempDt.Rows.Count > 0)
                {
                    if (TheRefId == "0") TheRefId = TempDt.Rows[0][0].ToString();
                    isSuccess = true;
                }
                else
                    isSuccess = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Select_TranferedData " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;            
        }    
    }
}
