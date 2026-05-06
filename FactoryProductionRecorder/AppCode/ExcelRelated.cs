using AppCode;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using Excel = Microsoft.Office.Interop.Excel;


namespace MyExcelClass
{
    class ExcelRelated
    {

        //public static DataTable AllAssemblyPartData = new DataTable();
        public static DataTable AllAssembly = new DataTable();
        public static DataTable CopyAllAssembly = new DataTable();
        public static DataTable AllJobData = new DataTable();
        public static DataTable AllAssemblyDate = new DataTable();

        public static Excel.Application exApp;
        private static Excel._Workbook exWB;


        #region BOM Import Related

        public static bool BOMExcelApp(string FilePath, string FileName, bool isAEMFile, Form fm)
        {
            bool success = true;

            //Excel.Application exApp;
            //Excel._Workbook exWB;
            //exApp = new Microsoft.Office.Interop.Excel.Application();

            if (exApp != null)
            {
                exWB = exApp.ActiveWorkbook;

                if (isAEMFile)
                    ReadDataFrom_ASSMPARTBOMXL_AEM(FilePath, FileName, exApp, exWB, fm);

                else if (FileName.ToUpper().EndsWith("_ASSEMBLY_PARTS_LIST.XLSX"))
                    ReadDataFrom_ASSMPARTBOMXL(FilePath, FileName, exApp, exWB, fm);

                else if (FileName.ToUpper().EndsWith("_PANEL BOM.XLSX"))
                    ReadDataFrom_SHEETINGBOMXL(FilePath, FileName, exApp, exWB, fm);

                else if (FileName.ToUpper().EndsWith("_TRIM BOM.XLSX"))
                    ReadDataFrom_TRIMBOMXL(FilePath, FileName, exApp, exWB, fm);

                else if (FileName.ToUpper().EndsWith("_COLD FORM MEMBER BOM.XLSX"))
                    ReadDataFrom_COLDFORMEDBOMXL(FilePath, FileName, exApp, exWB, fm);

                else if (FileName.ToUpper().EndsWith("_TOUCH-UP-PAINT_LIST.XLSX"))
                    ReadDataFrom_TOUCHUPPAINTXL(FilePath, FileName, exApp, exWB, fm);

                else if (FileName.ToUpper().EndsWith("_DECKING_PANEL_LIST.XLSX"))
                    ReadDataFrom_DECKINGBOMXL(FilePath, FileName, exApp, exWB, fm);
            }

            return success;
        }

        private static string GetAreaCode(string JobCode)
        {
            string result = "";

            DataTable ACode = DBClasses.DBReader.GetJobAreaCode(JobCode);

            if (ACode.Rows.Count > 0)
            {
                result = ACode.Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("Error: Unable to load AJM Data for the entered job number\nPlease inform PMD to add this job data in AJM", "Error::Contact PD_SupportDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = "";
            }

            return result;
        }

        public static bool ReadDataFrom_ASSMPARTBOMXL(string FilePath, string FileName, Excel.Application exApp, Excel._Workbook exWB, Form fm)
        {
            bool result = false;
            exWB = exApp.ActiveWorkbook;

            FactoryProductionRecorder.MoveTo inpro = new FactoryProductionRecorder.MoveTo();
            inpro.TopMost = true;
            inpro.Location = new System.Drawing.Point(fm.Location.X + 100, fm.Location.Y + 100);
            inpro.Show();

            if (exWB != null)
                exWB.Close(false, Missing.Value, Missing.Value);

            try
            {
                Cart.LoadTheBOMAgain = false;

                exWB = (Excel._Workbook)(exApp.Workbooks.Open(FilePath, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 0, 0));

                exApp.Visible = false;
                Excel.Worksheet tempSht = (Excel.Worksheet)exWB.Sheets.get_Item(1);

                tempSht.Select(Missing.Value);
                tempSht.Unprotect("#Oreca");

                #region User Details..
                var DetailerName = tempSht.Cells[2, 13].Value;
                var CheckerName = tempSht.Cells[3, 13].Value;
                var DateString = tempSht.Cells[4, 13].Value;
                #endregion

                #region Header JOB informations..

                int rowNum = 6;

                string jobId = tempSht.Cells[rowNum, 4].Value;
                string AreaCode = "";
                string JobNumber = "";

                if (jobId.Contains("-"))
                {
                    string[] splitJobId = jobId.Split(new char[] { '-' });
                    AreaCode = splitJobId[0].ToString().Trim();
                    JobNumber = splitJobId[1].ToString().Trim();
                }
                else
                {
                    JobNumber = jobId;
                }

                string BldNumber = tempSht.Cells[rowNum, 6].Text.ToString().Trim();
                BldNumber = BldNumber.Replace("\0", "");
                if (BldNumber.Length == 1) BldNumber = "0" + BldNumber;

                string PhNumber = tempSht.Cells[rowNum, 8].Text.ToString().Trim();
                PhNumber = PhNumber.Replace("\0", "");
                if (PhNumber.Length == 1) PhNumber = "00" + PhNumber;
                else if (PhNumber.Length == 2) PhNumber = "0" + PhNumber;


                string ReNumber = tempSht.Cells[rowNum, 10].Text.ToString().Trim();
                if (ReNumber.Trim() == "") ReNumber = "0";
                ReNumber = ReNumber.Replace("\0", "");
                ReNumber = int.Parse(ReNumber).ToString();
                string PhaseID = jobId + "-" + BldNumber + "-" + PhNumber;

                Cart.ThePhaseId = PhaseID;


                if (DBClasses.DBReader.IsPhaseIDReleased(PhaseID))
                { throw new Exception("Exception: \n\nThis job: " + PhaseID + ", has already processed for the month of '" + Cart.TheSelectedMonth + ", " + Cart.TheSelectedYear + "'"); }


                DataTable AllSavedJobs = DBClasses.DBReader.AllSavedJobs(PhaseID);

                if (AllSavedJobs.Rows.Count > 0)
                {
                    DialogResult dr = KryptonMessageBox.Show(PhaseID + "\n\nThis phase data was already saved for production update, do you want to process the data again?", "Process again..?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No) { throw new Exception(""); }

                    Cart.LoadTheBOMAgain = true;
                }


                #endregion

                #region _Assembly_Parts_List Data Collecting..

                int inc = 8;
                bool ValidHeader = false;

                var AssmPos = tempSht.Cells[inc, 3].Value;
                var AssmQty = tempSht.Cells[inc, 6].Value; //dummy
                var AssmUnitWt = "";
                var AssmWt = "";


                if (AssmPos.ToString().ToUpper() == "ASSM MARK")
                    ValidHeader = true;

                if (ValidHeader)
                {
                    inc = inc + 2; //10

                    Excel.Range cells = tempSht.Columns["C:C"] as Excel.Range;
                    Excel.Range match = cells.Find("Total", LookAt: Excel.XlLookAt.xlPart) as Excel.Range;

                    string matchAdd = match != null ? match.Address : null;

                    if (match != null)
                    {
                        string theCellindexVal = match.Address.Replace("$C$", "");
                        int theCellIndex = int.Parse(theCellindexVal) - 1;

                        Excel.Range MyRowRange = tempSht.get_Range("C" + inc, "M" + theCellindexVal);

                        object[,] values = (object[,])MyRowRange.Value2;

                        int NumRow = 1;
                        var PrevAssmPos = "";
                        var PrevAssmQty = "";

                        while (NumRow < values.GetLength(0))
                        {
                            AssmPos = Convert.ToString(values[NumRow, 1]);
                            AssmQty = Convert.ToString(values[NumRow, 4]);
                            AssmUnitWt = Convert.ToDouble(values[NumRow, 9]).ToString("F3");
                            AssmWt = Convert.ToDouble(values[NumRow, 10]).ToString("F3");

                            if (AssmPos == "")
                            {
                                AssmPos = PrevAssmPos;
                                AssmQty = PrevAssmQty;

                                //int PartQty = Convert.ToInt32(values[NumRow, 4]);
                                //string PartPos = Convert.ToString(values[NumRow, 2]);

                                //AllAssemblyPartData.Rows.Add(PhaseID, AssmPos, AssmQty, PartPos, PartQty);
                            }
                            else
                            {
                                PrevAssmPos = AssmPos;
                                PrevAssmQty = AssmQty;

                                AllAssembly.Rows.Add(PhaseID, AssmPos, AssmQty, "", "", AssmQty, AssmUnitWt, AssmWt, 0, AssmWt, "");
                            }

                            inc = inc + 1;
                            NumRow++;
                        }

                        ReleaseObject(MyRowRange);
                        ReleaseObject(match);
                        ReleaseObject(cells);
                        result = true;
                    }
                }
                else
                {
                    result = false;
                }

                #endregion

            }

            catch (Exception ex)
            {
                if (ex.Message != "")
                    KryptonMessageBox.Show(ex.Message);

                result = false;
            }
            finally
            {
                if (exWB != null)
                    exWB.Close(false, Missing.Value, Missing.Value);

                ReleaseObject(exWB);
                exWB = null;

            }

            inpro.Close();

            return result;

        }
        public static bool ReadDataFrom_ASSMPARTBOMXL_AEM(string FilePath, string FileName, Excel.Application exApp, Excel._Workbook exWB, Form fm)
        {
            bool result = false;
            exWB = exApp.ActiveWorkbook;

            FactoryProductionRecorder.MoveTo inpro = new FactoryProductionRecorder.MoveTo();
            inpro.TopMost = true;
            inpro.Location = new System.Drawing.Point(fm.Location.X + 100, fm.Location.Y + 100);
            inpro.Show();

            if (exWB != null)
                exWB.Close(false, Missing.Value, Missing.Value);

            try
            {
                Cart.LoadTheBOMAgain = false;

                exWB = (Excel._Workbook)(exApp.Workbooks.Open(FilePath, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 0, 0));

                exApp.Visible = false;
                Excel.Worksheet tempSht = (Excel.Worksheet)exWB.Sheets.get_Item(1);

                tempSht.Select(Missing.Value);
                tempSht.Unprotect("Sheet6yu45m89n89n89#*($N(#*$m003nf9dfng9dg$n=f^dfg{}b4df:{godbvklxjv");

                #region User Details..
                var DetailerName = tempSht.Cells[2, 13].Value;
                var CheckerName = tempSht.Cells[3, 13].Value;
                var DateString = tempSht.Cells[4, 13].Value;
                #endregion

                #region Header JOB informations..

                int rowNum = 6;

                string jobId = tempSht.Cells[rowNum, 4].Value;
                string AreaCode = "";
                string JobNumber = "";

                if (jobId.Contains("-"))
                {
                    string[] splitJobId = jobId.Split(new char[] { '-' });
                    AreaCode = splitJobId[0].ToString().Trim();
                    JobNumber = splitJobId[1].ToString().Trim();
                }
                else
                {
                    JobNumber = jobId;
                }

                string BldNumber = tempSht.Cells[rowNum, 6].Text.ToString().Trim();
                BldNumber = BldNumber.Replace("\0", "");
                if (BldNumber.Length == 1) BldNumber = "0" + BldNumber;

                string PhNumber = tempSht.Cells[rowNum, 8].Text.ToString().Trim();
                PhNumber = PhNumber.Replace("\0", "");
                if (PhNumber.Length == 1) PhNumber = "00" + PhNumber;
                else if (PhNumber.Length == 2) PhNumber = "0" + PhNumber;


                string ReNumber = tempSht.Cells[rowNum, 10].Text.ToString().Trim();
                if (ReNumber.Trim() == "") ReNumber = "0";
                ReNumber = ReNumber.Replace("\0", "");
                ReNumber = int.Parse(ReNumber).ToString();
                string PhaseID = jobId + "-" + BldNumber + "-" + PhNumber;

                Cart.ThePhaseId  = PhaseID;


                if (DBClasses.DBReader.IsPhaseIDReleased(PhaseID))
                { throw new Exception("Exception: \n\nThis job: " + PhaseID + ", has already processed for the month of '" + Cart.TheSelectedMonth + ", " + Cart.TheSelectedYear + "'"); }


                DataTable AllSavedJobs = DBClasses.DBReader.AllSavedJobs(PhaseID);

                if (AllSavedJobs.Rows.Count > 0)
                {
                    DialogResult dr = KryptonMessageBox.Show(PhaseID + "\n\nThis phase data was already saved for production update, do you want to process the data again?", "Process again..?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No) { throw new Exception(""); }

                    Cart.LoadTheBOMAgain = true;
                }


                #endregion

                #region _Assembly_Parts_List Data Collecting..

                int inc = 8;
                bool ValidHeader = false;

                var AssmPos = tempSht.Cells[inc, 3].Value;
                var AssmQty = tempSht.Cells[inc, 5].Value; //dummy
                var AssmUnitWt = "";
                var AssmWt = "";


                if (AssmPos.ToString().ToUpper() == "ASSM MARK")
                    ValidHeader = true;

                if (ValidHeader)
                {
                    inc = inc + 2; //10

                    //Excel.Range cells = tempSht.Columns["C:C"] as Excel.Range;
                    //Excel.Range match = cells.Find("Total", LookAt: Excel.XlLookAt.xlPart) as Excel.Range;

                    Excel.Range match = tempSht.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);

                    string matchAdd = match != null ? match.Address : null;

                    if (match != null)
                    {
                        int theCellindexVal = match.Row;
                        int theCellIndex = theCellindexVal - 1;

                        Excel.Range MyRowRange = tempSht.get_Range("C" + inc, "M" + theCellindexVal);

                        object[,] values = (object[,])MyRowRange.Value2;

                        int NumRow = 1;
                        var PrevAssmPos = "";
                        var PrevAssmQty = "";

                        while (NumRow < values.GetLength(0))
                        {
                            if (Convert.ToString(values[NumRow, 1]) != "")
                            {
                                AssmPos = Convert.ToString(values[NumRow, 1]);
                                AssmQty = Convert.ToString(values[NumRow, 3]);
                                AssmUnitWt = Convert.ToDouble(values[NumRow, 9]).ToString("F3");
                                AssmWt = Convert.ToDouble(values[NumRow, 10]).ToString("F3");

                                if (AssmPos == "")
                                {
                                    AssmPos = PrevAssmPos;
                                    AssmQty = PrevAssmQty;

                                    //int PartQty = Convert.ToInt32(values[NumRow, 4]);
                                    //string PartPos = Convert.ToString(values[NumRow, 2]);

                                    //AllAssemblyPartData.Rows.Add(PhaseID, AssmPos, AssmQty, PartPos, PartQty);
                                }
                                else
                                {
                                    PrevAssmPos = AssmPos;
                                    PrevAssmQty = AssmQty;

                                    AllAssembly.Rows.Add(PhaseID, AssmPos, AssmQty, "", "", AssmQty, AssmUnitWt, AssmWt, 0, AssmWt, "");
                                }
                            }

                            inc = inc + 1;
                            NumRow++;
                        }

                        ReleaseObject(MyRowRange);
                        ReleaseObject(match);
                        result = true;
                    }
                }
                else
                {
                    result = false;
                }

                #endregion

            }

            catch (Exception ex)
            {
                if (ex.Message != "")
                    KryptonMessageBox.Show(ex.Message);

                result = false;
            }
            finally
            {
                if (exWB != null)
                    exWB.Close(false, Missing.Value, Missing.Value);

                ReleaseObject(exWB);
                exWB = null;

            }

            inpro.Close();

            return result;

        }
        public static bool ReadDataFrom_TOUCHUPPAINTXL(string FilePath, string FileName, Excel.Application exApp, Excel._Workbook exWB, Form fm)
        {
            bool result = false;
            exWB = exApp.ActiveWorkbook;

            FactoryProductionRecorder.MoveTo inpro = new FactoryProductionRecorder.MoveTo();
            inpro.TopMost = true;
            inpro.Location = new System.Drawing.Point(fm.Location.X + 100, fm.Location.Y + 100);
            inpro.Show();

            if (exWB != null)
                exWB.Close(false, Missing.Value, Missing.Value);

            try
            {
                exWB = (Excel._Workbook)(exApp.Workbooks.Open(FilePath, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 0, 0));

                exApp.Visible = false;
                Excel.Worksheet tempSht = (Excel.Worksheet)exWB.Sheets.get_Item(1);

                tempSht.Select(Missing.Value);
                tempSht.Unprotect("#Oreca");

                #region USER DETAILS..
                var DetailerName = tempSht.Cells[2, 13].Value;
                var CheckerName = tempSht.Cells[3, 13].Value;
                var DateString = tempSht.Cells[4, 13].Value;
                #endregion

                #region HEADER JOB INFORMATIONS..

                int rowNum = 5;
                var jobId = tempSht.Cells[rowNum, 3].Value;

                string AreaCode = "";
                string JobNumber = "";

                if (jobId.Contains("-"))
                {
                    string[] splitJobId = jobId.Split(new char[] { '-' });
                    AreaCode = splitJobId[0].ToString().Trim();
                    JobNumber = splitJobId[1].ToString().Trim();
                }
                else
                {
                    JobNumber = jobId;
                }

                string BldNumber = tempSht.Cells[rowNum, 5].Text.ToString().Trim();
                BldNumber = BldNumber.Replace("\0", "");
                if (BldNumber.Length == 1) BldNumber = "0" + BldNumber;

                string PhNumber = tempSht.Cells[rowNum, 7].Text.ToString().Trim();
                PhNumber = PhNumber.Replace("\0", "");
                if (PhNumber.Length == 1) PhNumber = "00" + PhNumber;
                else if (PhNumber.Length == 2) PhNumber = "0" + PhNumber;

                string ReNumber = tempSht.Cells[rowNum, 9].Text;
                if (ReNumber.Trim() == "") ReNumber = "0";
                ReNumber = ReNumber.Replace("\0", "");
                ReNumber = int.Parse(ReNumber).ToString();
                string PhaseID = jobId + "-" + BldNumber + "-" + PhNumber;
                
                Cart.ThePhaseId = PhaseID;

                if (DBClasses.DBReader.IsPhaseIDReleased(PhaseID))
                { throw new Exception("Exception: \n\nThis job: " + PhaseID + ", has already processed for the month of '" + Cart.TheSelectedMonth + ", " + Cart.TheSelectedYear + "'"); }

                DataTable AllSavedJobs = DBClasses.DBReader.AllSavedJobs(PhaseID);

                if (AllSavedJobs.Rows.Count > 0)
                {
                    DialogResult dr = KryptonMessageBox.Show(PhaseID + "\n\nThis phase data was already saved for production update, do you want to process the data again?", "Process again..?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No) { throw new Exception(""); }

                    Cart.LoadTheBOMAgain = true;
                }

                #endregion

                #region TOUCHUP INFORMATIONS..

                rowNum = 12;
                string TUPCode = tempSht.Cells[rowNum, 2].Text.ToString().Trim();
                bool ValidHeader = false;

                if (TUPCode.ToString().ToUpper() == "TUP CODE")
                    ValidHeader = true;

                if (ValidHeader)
                {
                    rowNum = 13;

                    //Excel.Range cells = tempSht.Columns["B:D"] as Excel.Range;
                    //Excel.Range match = cells.Find("SECONDARY MEMBERS:", LookAt: Excel.XlLookAt.xlPart) as Excel.Range;
                    Excel.Range match = tempSht.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
                    //string matchAdd = match != null ? match.Address : null;

                    if (match != null)
                    {
                        int theCellindexVal = match.Row;
                        int theCellIndex = theCellindexVal - 1;

                        Excel.Range MyRowRange = tempSht.get_Range("B" + rowNum, "M" + theCellindexVal);

                        object[,] values = (object[,])MyRowRange.Value2;

                        int NumRow = 1;
                        string PrevPFCode = "";

                        List<string> listOfPfCodes = new List<string>();

                        while (NumRow < values.GetLength(0))
                        {
                            TUPCode = Convert.ToString(values[NumRow, 1]);
                            //string CoatNo = Convert.ToString(values[NumRow, 2]);

                            if (TUPCode != "")
                            {
                                if (TUPCode == "")
                                    TUPCode = PrevPFCode;
                                else if (TUPCode != PrevPFCode)
                                    PrevPFCode = TUPCode;

                                string Desc = Convert.ToString(values[NumRow, 2]).Trim();
                                string Qty = Convert.ToString(values[NumRow, 8]).Trim();
                                string Rmk = Convert.ToString(values[NumRow, 10]).Trim();
                                string Clr = "";
                                string tupUnitWt = "";
                                double theTotWt = 0;
                                int IsCan = 0;
                                int IsLiter = 0;

                                if (Desc.ToUpper().Contains("SPRAY"))
                                {
                                    IsCan = 1; IsLiter = 0;
                                    tupUnitWt = "0.4314";
                                }
                                else
                                {
                                    IsCan = 0; IsLiter = 1;
                                    tupUnitWt = "1.25";
                                }


                                if (Qty.ToUpper().Contains("CAN"))
                                    Qty = Qty.ToUpper().Replace("CAN", "").Trim();
                                else if (Qty.ToUpper().Contains("LITERS"))
                                    Qty = Qty.ToUpper().Replace("LITERS", "").Trim();


                                if (Cart.IsInterger(Qty))
                                    theTotWt = double.Parse(Qty) * double.Parse(tupUnitWt);
                                
                                AllAssembly.Rows.Add(PhaseID, TUPCode, Qty, "", "", Qty, tupUnitWt, theTotWt, 0, theTotWt, "");
                            }

                            rowNum = rowNum + 1;
                            NumRow++;
                        }


                        ReleaseObject(MyRowRange);
                        ReleaseObject(match);
                        result = true;
                    }

                }
                else
                {
                    result = false;
                }
                #endregion

            }
            catch (Exception ex)
            {
                if (ex.Message != "")
                    KryptonMessageBox.Show(ex.Message);

                result = false;
            }
            finally
            {
                if (exWB != null)
                    exWB.Close(false, Missing.Value, Missing.Value);

                ReleaseObject(exWB);
                exWB = null;

            }

            inpro.Close();

            return result;

        }
        public static bool ReadDataFrom_SHEETINGBOMXL(string FilePath, string FileName, Excel.Application exApp, Excel._Workbook exWB, Form fm)
        {
            bool result = false;
            exWB = exApp.ActiveWorkbook;

            FactoryProductionRecorder.MoveTo inpro = new FactoryProductionRecorder.MoveTo();
            inpro.TopMost = true;
            inpro.Location = new System.Drawing.Point(fm.Location.X + 100, fm.Location.Y + 100);
            inpro.Show();

            if (exWB != null)
                exWB.Close(false, Missing.Value, Missing.Value);

            try
            {
                exWB = (Excel._Workbook)(exApp.Workbooks.Open(FilePath, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 0, 0));

                exApp.Visible = false;
                Excel.Worksheet tempSht = (Excel.Worksheet)exWB.Sheets.get_Item(1);

                tempSht.Select(Missing.Value);
                tempSht.Unprotect("#Oreca");

                #region User Details..
                var DetailerName = tempSht.Cells[21, 6].Value;
                var CheckerName = tempSht.Cells[21, 12].Value;
                var DateString = tempSht.Cells[22, 9].Value;
                #endregion

                #region Header JOB informations..

                int rowNum = 18;
                var jobId = tempSht.Cells[18, 6].Value;

                string AreaCode = "";
                string JobNumber = "";

                if (jobId.Contains("-"))
                {
                    string[] splitJobId = jobId.Split(new char[] { '-' });
                    AreaCode = splitJobId[0].ToString().Trim();
                    JobNumber = splitJobId[1].ToString().Trim();
                }
                else
                {
                    JobNumber = jobId;
                    AreaCode = GetAreaCode(JobNumber);

                    if (AreaCode == "")
                        throw new Exception("Exception: Area code missing");
                    else
                        jobId = AreaCode + "-" + JobNumber;
                }

                string BldNumber = tempSht.Cells[19, 6].Text.ToString().Trim();
                BldNumber = BldNumber.Replace("\0", "");
                if (BldNumber.Length == 1) BldNumber = "0" + BldNumber;

                string PhNumber = tempSht.Cells[18, 12].Text.ToString().Trim();
                PhNumber = PhNumber.Replace("\0", "");
                if (PhNumber.Length == 1) PhNumber = "00" + PhNumber;
                else if (PhNumber.Length == 2) PhNumber = "0" + PhNumber;

                string ReNumber = tempSht.Cells[19, 12].Text;
                if (ReNumber.Trim() == "") ReNumber = "0";
                ReNumber = ReNumber.Replace("\0", "");
                ReNumber = int.Parse(ReNumber).ToString();
                string PhaseID = jobId + "-" + BldNumber + "-" + PhNumber;

                Cart.ThePhaseId = PhaseID;


                if (DBClasses.DBReader.IsPhaseIDReleased(PhaseID))
                { throw new Exception("Exception: \n\nThis job: " + PhaseID + ", has already processed for the month of '" + Cart.TheSelectedMonth + ", " + Cart.TheSelectedYear + "'"); }

                DataTable AllSavedJobs = DBClasses.DBReader.AllSavedJobs(PhaseID);

                if (AllSavedJobs.Rows.Count > 0)
                {
                    DialogResult dr = KryptonMessageBox.Show(PhaseID + "\n\nThis phase data was already saved for production update, do you want to process the data again?", "Process again..?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No) { throw new Exception(""); }

                    Cart.LoadTheBOMAgain = true;
                }

                #endregion

                #region _SHEETING_Panel_List Data Collecting..

                //Excel.Range mcells = tempSht.Columns["C:C"] as Excel.Range;
                Excel.Range lastCell = tempSht.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);

                int theCellindexVal = lastCell.Row;

                //============================================================
                bool isRead = false;

                for (int ii = 78; ii < theCellindexVal; ii++)
                {
                    var AssmPos = tempSht.Cells[86, 3].Value;
                    var AssmQty = tempSht.Cells[86, 8].Value;

                    if (tempSht.Cells[ii, 3].Text == "Assm Mark")
                    {
                        //header data
                        ii = ii + 1;
                        isRead = true;
                    }
                    else if (tempSht.Cells[ii, 3].Text == "" || tempSht.Cells[ii, 3].Text == "Page Total")
                    {
                        isRead = false;
                    }

                    if (isRead)
                    {
                        AssmPos = tempSht.Cells[ii, 3].Value;
                        AssmQty = tempSht.Cells[ii, 8].Value;

                        var AssmUnitWt = tempSht.Cells[ii, 9].Value;
                        var AssmTotWt = tempSht.Cells[ii, 10].Value;

                        AllAssembly.Rows.Add(PhaseID, AssmPos, AssmQty, "", "", AssmQty, AssmUnitWt, AssmTotWt, 0, AssmTotWt, "");

                        result = true;
                    }
                }

                ReleaseObject(lastCell);
                //ReleaseObject(mcells);

                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            finally
            {
                if (exWB != null)
                    exWB.Close(false, Missing.Value, Missing.Value);

                ReleaseObject(exWB);
                exWB = null;
                
            }

            inpro.Close();

            return result;

        }
        public static bool ReadDataFrom_TRIMBOMXL(string FilePath, string FileName, Excel.Application exApp, Excel._Workbook exWB, Form fm)
        {
            bool result = false;
            exWB = exApp.ActiveWorkbook;

            FactoryProductionRecorder.MoveTo inpro = new FactoryProductionRecorder.MoveTo();
            inpro.TopMost = true;
            inpro.Location = new System.Drawing.Point(fm.Location.X + 100, fm.Location.Y + 100);
            inpro.Show();

            if (exWB != null)
                exWB.Close(false, Missing.Value, Missing.Value);

            try
            {
                exWB = (Excel._Workbook)(exApp.Workbooks.Open(FilePath, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 0, 0));

                exApp.Visible = false;
                Excel.Worksheet tempSht = (Excel.Worksheet)exWB.Sheets.get_Item(1);

                tempSht.Select(Missing.Value);
                tempSht.Unprotect("#Oreca");

                #region User Details..
                var DetailerName = tempSht.Cells[21, 6].Value;
                var CheckerName = tempSht.Cells[21, 12].Value;
                var DateString = tempSht.Cells[22, 9].Value;
                #endregion

                #region Header JOB informations..

                int rowNum = 18;
                var jobId = tempSht.Cells[18, 6].Value;

                string AreaCode = "";
                string JobNumber = "";

                if (jobId.Contains("-"))
                {
                    string[] splitJobId = jobId.Split(new char[] { '-' });
                    AreaCode = splitJobId[0].ToString().Trim();
                    JobNumber = splitJobId[1].ToString().Trim();
                }
                else
                {
                    JobNumber = jobId;

                    AreaCode = GetAreaCode(JobNumber);

                    if (AreaCode == "")
                        throw new Exception("Exception: Area code missing");
                    else
                        jobId = AreaCode + "-" + JobNumber;
                }

                string BldNumber = tempSht.Cells[19, 6].Text.ToString().Trim();
                BldNumber = BldNumber.Replace("\0", "");
                if (BldNumber.Length == 1) BldNumber = "0" + BldNumber;

                string PhNumber = tempSht.Cells[18, 12].Text.ToString().Trim();
                PhNumber = PhNumber.Replace("\0", "");
                if (PhNumber.Length == 1) PhNumber = "00" + PhNumber;
                else if (PhNumber.Length == 2) PhNumber = "0" + PhNumber;


                string ReNumber = tempSht.Cells[19, 12].Text;
                if (ReNumber.Trim() == "") ReNumber = "0";
                ReNumber = ReNumber.Replace("\0", "");
                ReNumber = int.Parse(ReNumber).ToString();
                string PhaseID = jobId + "-" + BldNumber + "-" + PhNumber;

                Cart.ThePhaseId = PhaseID;

                if (DBClasses.DBReader.IsPhaseIDReleased(PhaseID))
                { throw new Exception("Exception: \n\nThis job: " + PhaseID + ", has already processed for the month of '" + Cart.TheSelectedMonth + ", " + Cart.TheSelectedYear + "'"); }

                DataTable AllSavedJobs = DBClasses.DBReader.AllSavedJobs(PhaseID);

                if (AllSavedJobs.Rows.Count > 0)
                {
                    DialogResult dr = KryptonMessageBox.Show(PhaseID + "\n\nThis phase data was already saved for production update, do you want to process the data again?", "Process again..?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No) { throw new Exception(""); }

                    Cart.LoadTheBOMAgain = true;
                }

                #endregion

                #region _TRIM_List Data Collecting..

                //Excel.Range mcells = tempSht.Columns["C:C"] as Excel.Range;
                Excel.Range lastCell = tempSht.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);

                int theCellindexVal = lastCell.Row;

                //======================================================================================

                bool isRead = false;

                for (int ii = 74; ii < theCellindexVal; ii++)
                {
                    var AssmPos = tempSht.Cells[82, 3].Value;
                    var AssmQty = tempSht.Cells[82, 8].Value;

                    if (tempSht.Cells[ii, 3].Text == "Trim Mark")
                    {
                        ii = ii + 1;
                        isRead = true;
                    }
                    else if (tempSht.Cells[ii, 3].Text == "" || tempSht.Cells[ii, 3].Text == "Page Total")
                    {
                        isRead = false;
                    }

                    if (isRead)
                    {
                        AssmPos = tempSht.Cells[ii, 3].Value;
                        AssmQty = tempSht.Cells[ii, 8].Value;

                        var AssmUnitWt = tempSht.Cells[ii, 9].Value;
                        var AssmTotWt = tempSht.Cells[ii, 10].Value;

                        AllAssembly.Rows.Add(PhaseID, AssmPos, AssmQty, "", "", AssmQty, AssmUnitWt, AssmTotWt, 0, AssmTotWt, "");

                        result = true;

                    }
                }

                ReleaseObject(lastCell);
                //ReleaseObject(mcells);

                #endregion

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            finally
            {
                if (exWB != null)
                    exWB.Close(false, Missing.Value, Missing.Value);

                ReleaseObject(exWB);
                exWB = null;
           }

            inpro.Close();

            return result;


        }
        public static bool ReadDataFrom_COLDFORMEDBOMXL(string FilePath, string FileName, Excel.Application exApp, Excel._Workbook exWB, Form fm)
        {
            bool result = false;
            exWB = exApp.ActiveWorkbook;

            FactoryProductionRecorder.MoveTo inpro = new FactoryProductionRecorder.MoveTo();
            inpro.TopMost = true;
            inpro.Location = new System.Drawing.Point(fm.Location.X + 100, fm.Location.Y + 100);
            inpro.Show();

            if (exWB != null)
                exWB.Close(false, Missing.Value, Missing.Value);

            try
            {
                exWB = (Excel._Workbook)(exApp.Workbooks.Open(FilePath, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 0, 0));

                exApp.Visible = false;
                Excel.Worksheet tempSht = (Excel.Worksheet)exWB.Sheets.get_Item(1);

                tempSht.Select(Missing.Value);
                tempSht.Unprotect("#Oreca");

                #region User Details..
                var DetailerName = tempSht.Cells[2, 15].Value;
                var CheckerName = tempSht.Cells[3, 15].Value;
                var DateString = tempSht.Cells[4, 15].Value;
                #endregion

                #region Header JOB informations..

                int rowNum = 5;
                var jobId = tempSht.Cells[rowNum, 4].Value;

                string[] splitJobId = jobId.Split(new char[] { '-' });
                string AreaCode = splitJobId[0].ToString().Trim();
                string JobNumber = splitJobId[1].ToString().Trim();

                string BldNumber = tempSht.Cells[rowNum, 6].Text.ToString().Trim();
                BldNumber = BldNumber.Replace("\0", "");
                if (BldNumber.Length == 1) BldNumber = "0" + BldNumber;

                string PhNumber = tempSht.Cells[rowNum, 8].Text.ToString().Trim();
                PhNumber = PhNumber.Replace("\0", "");
                if (PhNumber.Length == 1) PhNumber = "00" + PhNumber;
                else if (PhNumber.Length == 2) PhNumber = "0" + PhNumber;


                string ReNumber = tempSht.Cells[rowNum, 11].Text;
                if (ReNumber.Trim() == "") ReNumber = "0";
                ReNumber = ReNumber.Replace("\0", "");
                ReNumber = int.Parse(ReNumber).ToString();
                string PhaseID = jobId + "-" + BldNumber + "-" + PhNumber;

                Cart.ThePhaseId = PhaseID;

                if (DBClasses.DBReader.IsPhaseIDReleased(PhaseID))
                { throw new Exception("Exception: \n\nThis job: " + PhaseID + ", has already processed for the month of '" + Cart.TheSelectedMonth + ", " + Cart.TheSelectedYear + "'"); }

                DataTable AllSavedJobs = DBClasses.DBReader.AllSavedJobs(PhaseID);

                if (AllSavedJobs.Rows.Count > 0)
                {
                    DialogResult dr = KryptonMessageBox.Show(PhaseID + "\n\nThis phase data was already saved for production update, do you want to process the data again?", "Process again..?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No) { throw new Exception(""); }

                    Cart.LoadTheBOMAgain = true;
                }

                #endregion

                #region _Cold form member BOM Data Collecting..

                int inc = 10;
                bool ValidHeader = false;

                var AssmPos = tempSht.Cells[inc, 3].Value;
                var AssmQty = tempSht.Cells[inc, 7].Value;

                if (AssmPos.ToString().ToUpper() == "MARK NO.")
                    ValidHeader = true;

                if (ValidHeader)
                {
                    inc = inc + 1; //11

                    Excel.Range cells = tempSht.Columns["C:H"] as Excel.Range;
                    Excel.Range match = cells.Find("Page Total", LookAt: Excel.XlLookAt.xlPart) as Excel.Range;

                    string matchAdd = match != null ? match.Address : null;

                    if (match != null)
                    {
                        string theCellindexVal = match.Address.Replace("$C$", "");
                        int theCellIndex = int.Parse(theCellindexVal) - 1;

                        Excel.Range MyRowRange = tempSht.get_Range("C" + inc, "L" + theCellindexVal);

                        object[,] values = (object[,])MyRowRange.Value2;

                        int NumRow = 1;

                        while (NumRow < values.GetLength(0))
                        {
                            AssmPos = Convert.ToString(values[NumRow, 1]);
                            AssmQty = Convert.ToString(values[NumRow, 7]);

                            var AssmUnitWt = Convert.ToString(values[NumRow, 8]).Trim();
                            var AssmTotWt = Convert.ToString(values[NumRow, 9]).Trim();

                            AllAssembly.Rows.Add(PhaseID, AssmPos, AssmQty, "", "", AssmQty, AssmUnitWt, AssmTotWt, 0, AssmTotWt, "");

                            inc = inc + 1;
                            NumRow++;
                        }

                        ReleaseObject(MyRowRange);
                        ReleaseObject(match);
                        ReleaseObject(cells);
                        result = true;
                    }
                }
                else
                {
                    result = false;
                }

                #endregion

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            finally
            {
                if (exWB != null)
                    exWB.Close(false, Missing.Value, Missing.Value);

                ReleaseObject(exWB);
                exWB = null;
            }

            inpro.Close();

            return result;

        }
        public static bool ReadDataFrom_DECKINGBOMXL(string FilePath, string FileName, Excel.Application exApp, Excel._Workbook exWB, Form fm)
        {
            bool result = false;
            exWB = exApp.ActiveWorkbook;

            FactoryProductionRecorder.MoveTo inpro = new FactoryProductionRecorder.MoveTo();
            inpro.TopMost = true;
            inpro.Location = new System.Drawing.Point(fm.Location.X + 100, fm.Location.Y + 100);
            inpro.Show();

            if (exWB != null)
                exWB.Close(false, Missing.Value, Missing.Value);

            try
            {
                exWB = (Excel._Workbook)(exApp.Workbooks.Open(FilePath, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 0, 0));

                exApp.Visible = false;
                Excel.Worksheet tempSht = (Excel.Worksheet)exWB.Sheets.get_Item(1);

                tempSht.Select(Missing.Value);
                tempSht.Unprotect("#Oreca");

                #region User Details..
                var DetailerName = tempSht.Cells[2, 12].Value;
                var CheckerName = tempSht.Cells[3, 12].Value;
                var DateString = tempSht.Cells[4, 12].Value;
                #endregion

                #region Header JOB informations..

                int rowNum = 6;
                var jobId = tempSht.Cells[rowNum, 4].Value;

                string AreaCode = "";
                string JobNumber = "";

                if (jobId.Contains("-"))
                {
                    string[] splitJobId = jobId.Split(new char[] { '-' });
                    AreaCode = splitJobId[0].ToString().Trim();
                    JobNumber = splitJobId[1].ToString().Trim();
                }
                else
                {
                    JobNumber = jobId;

                    AreaCode = GetAreaCode(JobNumber);

                    if (AreaCode == "")
                        throw new Exception("Exception: Area code missing");
                    else
                        jobId = AreaCode + "-" + JobNumber;
                }

                string BldNumber = tempSht.Cells[rowNum, 6].Text.ToString().Trim();
                BldNumber = BldNumber.Replace("\0", "");
                if (BldNumber.Length == 1) BldNumber = "0" + BldNumber;

                string PhNumber = tempSht.Cells[rowNum, 7].Text.ToString().Trim();
                PhNumber = PhNumber.Replace("\0", "");
                if (PhNumber.Length == 1) PhNumber = "00" + PhNumber;
                else if (PhNumber.Length == 2) PhNumber = "0" + PhNumber;

                string[] splitPhaseId = PhNumber.Split(new char[] { ':' });
                PhNumber = splitPhaseId[1].ToString().Trim();

                string ReNumber = tempSht.Cells[rowNum, 9].Text;
                if (ReNumber.Trim() == "") ReNumber = "0";
                ReNumber = ReNumber.Replace("\0", "");
                ReNumber = int.Parse(ReNumber).ToString();
                string PhaseID = jobId + "-" + BldNumber + "-" + PhNumber;

                Cart.ThePhaseId = PhaseID;

                if (DBClasses.DBReader.IsPhaseIDReleased(PhaseID))
                { throw new Exception("Exception: \n\nThis job: " + PhaseID + ", has already processed for the month of '" + Cart.TheSelectedMonth + ", " + Cart.TheSelectedYear + "'"); }
                
                DataTable AllSavedJobs = DBClasses.DBReader.AllSavedJobs(PhaseID);

                if (AllSavedJobs.Rows.Count > 0)
                {
                    DialogResult dr = KryptonMessageBox.Show(PhaseID + "\n\nThis phase data was already saved for production update, do you want to process the data again?", "Process again..?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No) { throw new Exception(""); }

                    Cart.LoadTheBOMAgain = true;
                }

                #endregion


                #region _Decking_Panel_List Data Collecting..

                int inc = 15;
                bool ValidHeader = false;

                var AssmPos = tempSht.Cells[inc, 3].Value;
                var AssmQty = tempSht.Cells[inc, 4].Value;

                if (AssmPos.ToString().ToUpper() == "ASSM MARK")
                    ValidHeader = true;

                if (ValidHeader)
                {
                    inc = inc + 1; //16

                    Excel.Range cells = tempSht.Columns["C:C"] as Excel.Range;
                    Excel.Range match = cells.Find("TOTAL", LookAt: Excel.XlLookAt.xlPart) as Excel.Range;

                    string matchAdd = match != null ? match.Address : null;

                    if (match != null)
                    {
                        string theCellindexVal = match.Address.Replace("$C$", "");
                        int theCellIndex = int.Parse(theCellindexVal) - 1;

                        Excel.Range MyRowRange = tempSht.get_Range("C" + inc, "L" + theCellindexVal);

                        object[,] values = (object[,])MyRowRange.Value2;

                        int NumRow = 1;

                        while (NumRow < values.GetLength(0))
                        {
                            AssmPos = Convert.ToString(values[NumRow, 1]);
                            AssmQty = Convert.ToString(values[NumRow, 2]);

                            var AssmUnitWt = Convert.ToString(values[NumRow, 8]).Trim();
                            var AssmTotWt = Convert.ToString(values[NumRow, 9]).Trim();

                            AllAssembly.Rows.Add(PhaseID, AssmPos, AssmQty, "", "", AssmQty, AssmUnitWt, AssmTotWt, 0, AssmTotWt, "");

                            inc = inc + 1;
                            NumRow++;
                        }

                        ReleaseObject(MyRowRange);
                        ReleaseObject(match);
                        ReleaseObject(cells);
                        result = true;
                    }
                }
                else
                {
                    result = false;
                }

                #endregion

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            finally
            {
                if (exWB != null)
                    exWB.Close(false, Missing.Value, Missing.Value);

                ReleaseObject(exWB);
                exWB = null;

            }

            inpro.Close();

            return result;

        }

        //public static bool ReadDataFrom_LOUVERBOMXL(string FileName, Excel.Application exApp, Excel._Workbook exWB, bool CloseExcelApp)
        //{
        //    bool result = false;
        //    exWB = exApp.ActiveWorkbook;

        //    if (exWB != null)
        //        exWB.Close(false, Missing.Value, Missing.Value);

        //    try
        //    {
        //        exWB = (Excel._Workbook)(exApp.Workbooks.Open(FileName, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 0, 0));

        //        exApp.Visible = false;
        //        Excel.Worksheet tempSht = (Excel.Worksheet)exWB.Sheets.get_Item(1);

        //        tempSht.Select(Missing.Value);
        //        tempSht.Unprotect("#Oreca");

        //        #region User Details..
        //        var DetailerName = tempSht.Cells[2, 11].Value;
        //        var CheckerName = tempSht.Cells[3, 11].Value;
        //        var DateString = tempSht.Cells[4, 11].Value;
        //        #endregion

        //        #region Header JOB informations..

        //        int rowNum = 5;
        //        var jobId = tempSht.Cells[rowNum, 3].Value;

        //        string AreaCode = "";
        //        string JobNumber = "";

        //        if (jobId.Contains("-"))
        //        {
        //            string[] splitJobId = jobId.Split(new char[] { '-' });
        //            AreaCode = splitJobId[0].ToString().Trim();
        //            JobNumber = splitJobId[1].ToString().Trim();
        //        }
        //        else
        //        {
        //            JobNumber = jobId;
        //        }

        //        string PhNumber = tempSht.Cells[rowNum, 5].Text.ToString().Trim();
        //        PhNumber = PhNumber.Replace("\0", "");
        //        if (PhNumber.Length == 1) PhNumber = "00" + PhNumber;
        //        else if (PhNumber.Length == 2) PhNumber = "0" + PhNumber;
  
        //        rowNum = 6;
        //        string BldNumber = tempSht.Cells[rowNum, 3].Text.ToString().Trim();
        //        BldNumber = BldNumber.Replace("\0", "");
        //        if (BldNumber.Length == 1) BldNumber = "0" + BldNumber;

        //        string ReNumber = tempSht.Cells[rowNum, 5].Text;
        //        if (ReNumber.Trim() == "") ReNumber = "0";
        //        ReNumber = ReNumber.Replace("\0", "");
        //        ReNumber = int.Parse(ReNumber).ToString();
        //        string PhaseID = jobId + "-" + BldNumber + "-" + PhNumber;

        //        Cart.ThePhaseId = PhaseID;

        //        DataRow[] matchingRows = ExcelRelated.AllJobData.Select("PHASEID like '" + PhaseID + "' and YEAR = " + Cart.TheSelectedYear + " and MONTH like '" + Cart.TheSelectedMonth + "'");

        //        if (matchingRows.Length > 0)
        //        { throw new Exception("Exception: \n\nThis job: " + PhaseID + ", has already processed for the month of '" + Cart.TheSelectedMonth + ", " + Cart.TheSelectedYear + "'"); }

        //        DataTable AllSavedJobs = DBClasses.DBReader.AllSavedJobs(PhaseID);

        //        if (AllSavedJobs.Rows.Count > 0)
        //        {
        //            DialogResult dr = KryptonMessageBox.Show(PhaseID + "\n\nThis phase data was already saved for production update, do you want to process the data again?", "Process again..?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //            if (dr == DialogResult.No) { throw new Exception(""); }

        //            Cart.LoadTheBOMAgain = true;
        //        }

        //        #endregion


        //        //<<assembly data>>
        //        #region ASSEMBLY LOUVER DETAILS..

        //        int inc = 29;
        //        bool ValidHeader = false;

        //        var ItemCode = tempSht.Cells[inc, 2].Value.ToString().Trim();

        //        if (ItemCode.ToString().ToUpper() == "SPECIAL NOTES:")
        //            ValidHeader = true;

        //        if (ValidHeader)
        //        {
        //            Excel.Range lastCell = tempSht.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);

        //            int theCellindexVal = lastCell.Row;

        //            Excel.Range MyRowRange = tempSht.get_Range("B" + inc, "K" + theCellindexVal);

        //            object[,] values = (object[,])MyRowRange.Value2;

        //            int NumRow = 1;
        //            int TrmNumRow = 1;

        //            int PanelTrimNum = 0;

        //            while (NumRow < values.GetLength(0))
        //            {
        //                string AssmPos = "";

        //                if (Convert.ToString(values[NumRow, 1]).Trim() == "SPECIAL NOTES:")
        //                {
        //                    NumRow = NumRow + 2;
        //                    TrmNumRow = NumRow + 4;

        //                    //-----------------<<LOUVER ASSEMBLY DATA START>>----------------------

        //                    AssmPos = Convert.ToString(values[NumRow, 1]).Trim();
        //                    int AssmQty = Convert.ToInt32(values[NumRow, 2]);
        //                    var AssmUnitWt = Convert.ToString(values[NumRow, 7]).Trim();
        //                    var AssmTotWt = Convert.ToString(values[NumRow, 9]).Trim();



        //                    //-----------------<< LOUVER ASSEMBLY AND BO FOR SITE STARTED >>--------------------------------------
        //                    while (Convert.ToString(values[TrmNumRow, 7]).ToString().Trim() != "TOTAL BUYOUT WT(Kg)")
        //                    {
        //                        if (Convert.ToString(values[TrmNumRow, 1]).ToString().Trim() == "SHEETING MATERIALS")
        //                        {
        //                            TrmNumRow = TrmNumRow + 2;

        //                            string PanelMaterialGrade = Convert.ToString(values[TrmNumRow, 5]).ToString().Trim();

        //                            while (Convert.ToString(values[TrmNumRow, 1]).ToString().Trim() != "")
        //                            {
        //                                if (Convert.ToString(values[TrmNumRow, 1]).ToString().Trim() != "PART MARK")
        //                                {
        //                                    //-----------------<< TRIM ASSEMBLY RECORD >>-----------------------------

        //                                    string SubAssmPos = Convert.ToString(values[TrmNumRow, 1]).ToString().Trim() + "-T" + PanelTrimNum;
        //                                    string PartPos = Convert.ToString(values[TrmNumRow, 1]).ToString().Trim() + "-T" + PanelTrimNum;

        //                                    string TProfile = Convert.ToString(values[TrmNumRow, 6]).ToString().Trim();
        //                                    double TheTWeight = double.Parse(Convert.ToString(values[TrmNumRow, 7]).ToString().Trim());

        //                                    string[] splitTrimProfile = TProfile.Replace(" ", "").Replace("SH", "").Split(new char[] { 'x' });

        //                                    double widt = double.Parse(splitTrimProfile[0]);
        //                                    double thkn = double.Parse(splitTrimProfile[1]);
        //                                    double lent = double.Parse(splitTrimProfile[2]);

        //                                    string PartName = Convert.ToString(values[TrmNumRow, 4]).ToString().Trim();

        //                                    string ErpCode = Convert.ToString(values[TrmNumRow, 2]).ToString().Trim();

        //                                    string PartProfile = "SH" + thkn + "x" + widt;
        //                                    string PartLength = lent.ToString();

        //                                    double PartUnitArea = (widt * lent * 2) / 1000000;
        //                                    int PartQty = int.Parse(Convert.ToString(values[TrmNumRow, 9]).ToString().Trim());
        //                                    double PartTotArea = double.Parse(PartQty.ToString()) * double.Parse(PartUnitArea.ToString());

        //                                    string PartUnitWt = TheTWeight.ToString();
        //                                    string PartTotWt = Convert.ToString(values[TrmNumRow, 10]).ToString().Trim();
        //                                    string PartRemarks = "";


        //                                    TrmNumRow = TrmNumRow + 1;
        //                                }
        //                                else
        //                                {
        //                                    TrmNumRow = TrmNumRow + 1;
        //                                    PanelMaterialGrade = Convert.ToString(values[TrmNumRow, 5]).ToString().Trim();
        //                                }
        //                            }
        //                        }
        //                        else if (Convert.ToString(values[TrmNumRow, 1]).ToString().Trim() == "BUYOUT ITEMS")
        //                        {
        //                            TrmNumRow = TrmNumRow + 1;

        //                            while (Convert.ToString(values[TrmNumRow, 1]).ToString().Trim() != "")
        //                            {
        //                                if (Convert.ToString(values[TrmNumRow, 1]).ToString().Trim() != "PART MARK")
        //                                {
        //                                    string ErpCode = Convert.ToString(values[TrmNumRow, 2]).ToString().Trim();
        //                                    string BoPos = Convert.ToString(values[TrmNumRow, 1]).Trim().Replace("*", "x");
        //                                    string BoDes = Convert.ToString(values[TrmNumRow, 4]).Trim().Replace("*", "x");
        //                                    string BoQty = Convert.ToString(values[TrmNumRow, 9]).Trim();
        //                                    string BoUnt = Convert.ToString(values[TrmNumRow, 7]).Trim();
        //                                    string BoTwt = Convert.ToString(values[TrmNumRow, 10]).Trim();
        //                                    string BoRem = "";

        //                                    DataRow[] Dt002a = AllBuyoutData.Select("(BOPOS like '" + BoPos + "')");

        //                                    TrmNumRow = TrmNumRow + 1;

        //                                }
        //                                else
        //                                {
        //                                    TrmNumRow = TrmNumRow + 1;
        //                                }
        //                            }
        //                        }
        //                        else
        //                        {
        //                            TrmNumRow = TrmNumRow + 1;
        //                        }

        //                        NumRow = TrmNumRow;
        //                    }

        //                }

        //                NumRow = NumRow + 1;
        //            }
        //        }

        //        // Correct the louver assembly weight...
        //        // Compute the sum of the "Value" column
        //        foreach (DataRow dr in AllAssemblyData.Rows)
        //        {
        //            string theAssmPos = dr["ASSMPOS"].ToString();

        //            DataView tpdv = new DataView(AllAssemblyPartData);
        //            tpdv.RowFilter = "PARTASSMPOS = '" + theAssmPos + "'";

        //            object sumObject = tpdv.ToTable().Compute("SUM(PARTTOTWEIGHT)", string.Empty);
        //            double sum = sumObject != DBNull.Value ? Convert.ToDouble(sumObject) : 0;

        //            dr["ASSMTOTWEIGHT"] = sum;
        //            double Qt = double.Parse(dr["ASSMQTY"].ToString());
        //            dr["ASSMUNITWEIGHT"] = sum / Qt;
        //        }

        //        result = true;

        //        #endregion
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        result = false;
        //    }
        //    finally
        //    {
        //        if (exWB != null)
        //            exWB.Close(false, Missing.Value, Missing.Value);

        //        ReleaseObject(exWB);
        //        exWB = null;
        //    }

        //    return result;

        //}

        #endregion

        public static bool IsProcessOpen(string name)
        {
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                //now we're going to see if any of the running processes
                if (clsProcess.ProcessName.Contains(name))
                {
                    //if the process is found to be running then we
                    //return a true
                    return true;
                }
            }
            //otherwise we return a false
            return false;
        }

        public static bool CloseProcessOpened(string name)
        {
            bool result = false;
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                //now we're going to see if any of the running processes
                if (clsProcess.ProcessName.Contains(name))
                {
                    //if the process is found to be running then we will remove it and
                    //return a true value
                    clsProcess.Kill();
                    result = true;
                }
            }
            //otherwise we return a false
            return result;
        }

        public static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}