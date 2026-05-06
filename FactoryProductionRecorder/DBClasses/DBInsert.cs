using AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBClasses
{
    class DBInsert
    {
        public static bool Insert_MyStationData(ref string[] queries, object[] theDetails)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);

                queries[queries.Length - 1] = @"INSERT INTO ProdStatus_Records ([PHASEID]
                                                                              ,[ASSMPOS]
                                                                              ,[ASSMNAME]
                                                                              ,[ASSMQTY]
                                                                              ,[UNITWEIGHT]
                                                                              ,[ONDATE]
                                                                              ,[RECORDEDBY]
                                                                              ,[RECORDEDON]
                                                                              ,[STATUS]
                                                                              ,[THELOCK]
                                                                              ,[REFID]
                                                                              ,[SHIFT], BAYID) VALUES ("
                                                                                     + theDetails[0].ToString() 
                                                                                     + theDetails[2].ToString() 
                                                                                     + theDetails[3].ToString() 
                                                                                     + theDetails[4].ToString() 
                                                                                     + theDetails[5].ToString() 
                                                                                     + theDetails[6].ToString() 
                                                                                     + theDetails[7].ToString() 
                                                                                     + theDetails[8].ToString() 
                                                                                     + theDetails[9].ToString()
                                                                                     + theDetails[10].ToString()
                                                                                     + theDetails[11].ToString()
                                                                                     + theDetails[12].ToString()
                                                                                     + theDetails[13].ToString() + ")";

                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Insert_MyStationData " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }

        public static bool Insert_toProdStatus_Record_Changes(ref string[] queries,
            string thePhaseId,
            string theAssmMak,
            string theNewAssmMak,
            string CurStatus,
            string NewStatus,
            string theUser,
            string theDate,
            string theRefMak,
            string UType)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);

                queries[queries.Length - 1] = @"INSERT INTO ProdStatus_Record_Changes ([PHASEID]
                                                                                      ,[REFID]
                                                                                      ,[ASSMPOS]
                                                                                      ,[NEWASSMPOS]
                                                                                      ,[CURRENTSTATUS]
                                                                                      ,[NEWSTATUS]
                                                                                      ,[MODIFIEDBY]
                                                                                      ,[MODIFIEDON]
                                                                                      ,[UPDATETYPE]) VALUES ("
                                                                                         + "'" + thePhaseId + "',"
                                                                                         + theRefMak + ","
                                                                                         + "'" + theAssmMak + "',"
                                                                                         + "'" + theNewAssmMak + "',"
                                                                                         + "'" + CurStatus + "',"
                                                                                         + "'" + NewStatus + "',"
                                                                                         + "'" + theUser + "',"
                                                                                         +  theDate + ","
                                                                                         + "'" + UType + "')";


                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Insert_MyStationData " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }

        public static bool Insert_toNextStation(ref string[] queries,string thePhaseId, string theAssmMak, string curlock, string curNextlock, string theUser, string theDate, string currentStatus, string nextStatus, string theRefMak, string theShift)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);

                queries[queries.Length - 1] = @"INSERT INTO ProdStatus_Records ([PHASEID]
                                                                              ,[ASSMPOS]
                                                                              ,[ASSMNAME]
                                                                              ,[ASSMQTY]
                                                                              ,[UNITWEIGHT]
                                                                              ,[ONDATE]
                                                                              ,[RECORDEDBY]
                                                                              ,[RECORDEDON]
                                                                              ,[TRANSFEREDBY]
                                                                              ,[TRANSFEREDON]
                                                                              ,[STATUS]
                                                                              ,[THELOCK]
                                                                              ,[REFID]
                                                                              ,[SHIFT]
                                                                              ,[BAYID])
                                                                            SELECT
                                                                                [PHASEID],
                                                                                [ASSMPOS],
                                                                                [ASSMNAME],
                                                                                [ASSMQTY],
                                                                                [UNITWEIGHT],
                                                                                [ONDATE] ,
                                                                                '" + theUser + @"' AS[RECORDEDBY],
                                                                                " + theDate + @" [RECORDEDON],
                                                                                NULL AS[TRANSFEREDBY],
                                                                                NULL AS[TRANSFEREDON],
                                                                                '" + nextStatus + @"' AS[STATUS],
                                                                                '" + curNextlock + @"' AS[THELOCK],
                                                                                CASE
                                                                                    WHEN[REFID] = 0 THEN[ID]
                                                                                    ELSE[REFID]
                                                                                END AS[REFID],
                                                                                " + Cart.ValidateNullvalue(theShift,true) + @",
                                                                                [BAYID]
                                                                            FROM
                                                                                [ProdStatus_Records]
                                                                            WHERE
                                                                                [PHASEID] = '" + thePhaseId + @"'
                                                                                AND[ASSMPOS] = '" + theAssmMak + @"'
                                                                                AND[STATUS] = '" + currentStatus + @"'
                                                                                AND[THELOCK] = '" + curlock + @"'
                                                                                AND[REFID] = '" + theRefMak + "'";

                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Insert_MyStationData " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }

        public static bool Insert_toNextStation_IDBased(ref string[] queries, string thePhaseId, string theAssmMak, string curlock, string curNextlock, string theUser, string theDate, string currentStatus, string nextStatus, string theRefMak)
        {
            bool isSuccess = false;

            try
            {
                Array.Resize(ref queries, queries.Length + 1);

                queries[queries.Length - 1] = @"INSERT INTO ProdStatus_Records ([PHASEID]
                                                                              ,[ASSMPOS]
                                                                              ,[ASSMNAME]
                                                                              ,[ASSMQTY]
                                                                              ,[UNITWEIGHT]
                                                                              ,[ONDATE]
                                                                              ,[RECORDEDBY]
                                                                              ,[RECORDEDON]
                                                                              ,[TRANSFEREDBY]
                                                                              ,[TRANSFEREDON]
                                                                              ,[STATUS]
                                                                              ,[THELOCK]
                                                                              ,[REFID])
                                                                            SELECT
                                                                                [PHASEID],
                                                                                [ASSMPOS],
                                                                                [ASSMNAME],
                                                                                [ASSMQTY],
                                                                                [UNITWEIGHT],
                                                                                [ONDATE],
                                                                                '" + theUser + @"' AS[RECORDEDBY],
                                                                                " + theDate + @" [RECORDEDON],
                                                                                NULL AS[TRANSFEREDBY],
                                                                                NULL AS[TRANSFEREDON],
                                                                                '" + nextStatus + @"' AS[STATUS],
                                                                                '" + curNextlock + @"' AS[THELOCK],
                                                                                CASE
                                                                                    WHEN[REFID] = 0 THEN[ID]
                                                                                    ELSE[REFID]
                                                                                END AS[REFID]
                                                                            FROM
                                                                                [ProdStatus_Records]
                                                                            WHERE
                                                                                [PHASEID] = '" + thePhaseId + @"'
                                                                                AND[ASSMPOS] = '" + theAssmMak + @"'
                                                                                AND[STATUS] = '" + currentStatus + @"'
                                                                                AND[THELOCK] = '" + curlock + @"'
                                                                                AND[ID] = '" + theRefMak + "'";

                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: in Insert_MyStationData " + ex.Message, "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;

        }
    }
}
