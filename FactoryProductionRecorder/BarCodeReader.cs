using AppCode;
using MyExcelClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using ComponentFactory.Krypton.Toolkit;
using System.IO;

namespace FactoryProductionRecorder
{
    public partial class BarCodeReader : MetroFramework.Forms.MetroForm
    {
        public bool IsEntry = false;
        public string CurrentStatus = "";
        public string NextStatus = "";

        public string theDb = "";

        private int scanCount = 0;
        private string theValue = "";
        DataTable BarCodeData = new DataTable();
        public string TheCurrentQtyValue;
        public string TheCurrentAssmIdValue;
        public bool IsValueChanged = false;
        public bool IsUpdated = false;
        public List<string> barlabels = new List<string> ();


        int theQty = 0;

        public BarCodeReader()
        {
            InitializeComponent();
        }

        private void BarCodeReader_Shown(object sender, EventArgs e)
        {
            this.Refresh();

            // Ensure the grid is ready
            DgvAssmData.Rows.Clear();      // Clear existing rows
            DgvAssmData.Rows.Add();        // Add a new empty row

            DgvAssmData.Focus();

            // Set current cell to AssemblyID cell (adjust index if needed)
            DgvAssmData.CurrentCell = DgvAssmData.Rows[0].Cells["AssemblyID"];
            DgvAssmData.BeginEdit(true);

            if (barlabels.Count > 0)
            {
                foreach (string str in barlabels)
                {
                    DgvAssmData.Rows[0].Cells["AssemblyID"].Value = str;
                    DgvAssmData.CurrentCell = DgvAssmData.Rows[0].Cells["AssmMark"];
                    DgvAssmData.BeginEdit(true);
                }
            }
            
            this.Opacity = 100;
        }

        private void BarCodeReader_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;

            dtpikProd.Value = DateTime.Now;
            dtpikProd.MaxDate = DateTime.Now;

            kcbBaySel.Visible = false;
            lblBay.Visible = false;

            if (!IsEntry)
            { 
                DgvAssmData.Columns["BOMQTY"].HeaderText = "IN QTY";
                //this.Height = 703;

                groupboxBOM.Visible = true;
                groupboxBOM.Text = "Received Data";

                DataTable TheHandedOverData = DBClasses.DBReader.LoadGivenStationData(theDb, CurrentStatus);
                dgvPendingData.DataSource = TheHandedOverData;
                Cart.FormatNextStationData(dgvPendingData);
            }
            else
            {
                this.Height = 408;

                if (CurrentStatus == "SWC")
                {
                    kcbBaySel.Visible = true;
                    lblBay.Visible = true;
                }

                //groupboxBOM.Visible = true;
                //groupboxBOM.Text = "My Station log";
            }

        }

        private void ShowAlert(string message)
        {
            if (!File.Exists(@"C:\InHouseApps\ViolationAlert.wav"))
            {
                File.Copy(@"Y:\\PDApplications\\ClickOnce\\FPR\\ViolationAlert.wav", @"C:\InHouseApps\ViolationAlert.wav", true);
            }

            tslStatus.Text = message;
            var player = new SoundPlayer(@"C:\InHouseApps\ViolationAlert.wav");
            player.Play();
        }

        private void DgvAssmData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var currentRow = DgvAssmData.Rows[e.RowIndex];
            var assmQtyCell = currentRow.Cells["AssemblyQty"];
            var PrevQtyCell = currentRow.Cells["PrevQty"];
            var bomQtyCell = currentRow.Cells["BOMQTY"];


            if (assmQtyCell?.Value == null) return;


            int.TryParse(assmQtyCell.Value.ToString(), out int asmQty);
            int.TryParse(PrevQtyCell.Value.ToString(), out int prvQty);
            int.TryParse(bomQtyCell.Value.ToString(), out int bomQty);


            if (asmQty + prvQty < bomQty)
                assmQtyCell.Value = asmQty + 1;

        }

        private void DgvAssmData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TheCurrentAssmIdValue = DgvAssmData.Rows[e.RowIndex].Cells["AssemblyID"].Value?.ToString();
            TheCurrentQtyValue = DgvAssmData.Rows[e.RowIndex].Cells["AssemblyQty"].Value?.ToString();           
        }

        private void DgvAssmData_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (DgvAssmData.Rows.Count == 0)
                DgvAssmData.Rows.Add();
        }

        private void DgvAssmData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = (DataGridView)sender;
            DataGridViewRow row = dgv.Rows[e.RowIndex];

            // Set alternating row style if not highlighted (Yellow)
            if (row.DefaultCellStyle.BackColor != Color.Yellow)
            {
                row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                row.Cells["AssemblyID"].Style.BackColor = Color.White;
                row.Cells["AssemblyQty"].Style.BackColor = Color.White;
            }

            // Format row number with leading zeros
            string strRowNumber = (e.RowIndex + 1).ToString("D" + dgv.RowCount.ToString().Length);

            // Measure size of the string
            SizeF size = e.Graphics.MeasureString(strRowNumber, dgv.ColumnHeadersDefaultCellStyle.Font);

            // Adjust row header width if necessary
            int requiredWidth = (int)(size.Width + 12);
            if (dgv.RowHeadersWidth < requiredWidth)
                dgv.RowHeadersWidth = requiredWidth;

            // Draw row number
            using (Brush brush = new SolidBrush(Color.Gray))
            {
                float x = e.RowBounds.Left + 8;
                float y = e.RowBounds.Top + (e.RowBounds.Height - size.Height) / 2;
                e.Graphics.DrawString(strRowNumber, dgv.ColumnHeadersDefaultCellStyle.Font, brush, x, y);
            }
        }

        private void DgvAssmData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            IsValueChanged = true;

            if (e.RowIndex == -1) return;


            var cellValue1 = DgvAssmData.Rows[e.RowIndex].Cells["AssemblyID"].Value;
            var cellValue2 = DgvAssmData.Rows[e.RowIndex].Cells["AssemblyQty"].Value;

            
            if (cellValue1 == null) return;
            if (cellValue2 == null) return;


            if (!Cart.IsInterger(cellValue2.ToString()))
            {
                DgvAssmData.Rows[e.RowIndex].Cells["AssemblyQty"].Value = TheCurrentQtyValue;
            }
        }

        private void DgvAssmData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsValueChanged) return;
            if (e.RowIndex < 0 || DgvAssmData.Rows[e.RowIndex].IsNewRow) return;

            var currentRow = DgvAssmData.Rows[e.RowIndex];
            var assemblyCell = currentRow.Cells["AssemblyID"];
            var assmMarkCell = currentRow.Cells["AssmMark"];

            if (assemblyCell?.Value == null) return;

            bool isValueExist = assmMarkCell?.Value != null;
            string enteredValue = assemblyCell.Value.ToString().Trim();
            string[] splitParts = enteredValue.Split('-');

            if (splitParts.Length != 5)
            {
                this.BeginInvoke(new MethodInvoker(() =>
                {
                    KryptonMessageBox.Show("Invalid AssemblyID format. Expected format: Axxxx-xx-xxx-xx-XXxxx", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DgvAssmData.CurrentCell = DgvAssmData.Rows[e.RowIndex].Cells["AssemblyID"];
                    DgvAssmData.BeginEdit(true);
                }));

                return;
            }

            string phaseId = $"{splitParts[0]}-{splitParts[1]}-{splitParts[2]}";
            string phaseRev = splitParts[3];
            string assmMark = splitParts[4];


            bool isDuplicate = false;
            int rowToRemoveIndex = -1;
            tslStatus.Text = "";


            //GET THE ASSEMBLY DATA WHICH WAS HANDED OVER TO NEXT STATION..
            DataTable TheHandedOverData = DBClasses.DBReader.Load_Assembly_Datas_Next(theDb, phaseId, assmMark,CurrentStatus, NextStatus);
            int prevQty = 0;
            int AssmQty = 0;

            DataTable assmData = new DataTable();
            if (IsEntry)
            {
                //LOAD ENGINEERING BOM DATA, BASED ON THE MAX ASSEMBLY REVISION
                assmData = DBClasses.DBReader.EngineeringBOMData(phaseId, assmMark, phaseRev);
            }
            else
            {
                // LOAD CURRENT PROCESSING DATA
                assmData = DBClasses.DBReader.Load_Assembly_Datas_Current(theDb, phaseId, assmMark, CurrentStatus);
            }


            //CHECK IF THE HANDED OVER ASSEMBLY QTY IS EXCEEDED THE BOM/CURRENT QTY..
            if (TheHandedOverData.Rows.Count > 0 && assmData.Rows.Count > 0)
            {
                //IF IT IS ENTRY
                prevQty = TheHandedOverData.Rows.Count;
                AssmQty = int.Parse(assmData.Rows[0]["ASSMQTY"]?.ToString());

                //IF NOT ENTRY
                if (!IsEntry)
                {
                    AssmQty = assmData.Rows.Count;

                    // Compare by ID, and return matching values in Value column
                    DataTable result = GetMatchingRows(TheHandedOverData, assmData, "ASSMPOS", "REFID");

                    prevQty = result.Rows.Count;
                }

                if (prevQty + 1 > AssmQty)
                {
                    ShowAlert($"{assmMark} - Full Quantity processed already!");
                    currentRow.Cells["AssemblyID"].Value = "";
                    return;
                }
            }


            if (assmData.Rows.Count > 0)
            {
                // MODIFY THE EXISTING ROW
                AssmPos_AlreadyExist(e, enteredValue, assmMark, ref isDuplicate, ref rowToRemoveIndex, prevQty);

                // ADD A NEW ROW
                AssmPos_NotExist(e, isDuplicate, assmData, currentRow, assmMark, rowToRemoveIndex, prevQty);


                // ADD A NEW BLANK ROW IF NEEDED
                if (!isValueExist && !DgvAssmData.Rows[DgvAssmData.Rows.Count - 1].IsNewRow)
                {
                    DgvAssmData.Rows.Add();
                }

                // MOVE FOCUS TO NEW ROW
                BeginInvoke(new MethodInvoker(() =>
                {
                    int newRowIndex = DgvAssmData.Rows.Count - 1;
                    if (DgvAssmData.Columns.Contains("AssemblyID"))
                    {
                        DgvAssmData.CurrentCell = DgvAssmData.Rows[newRowIndex].Cells["AssemblyID"];
                        DgvAssmData.BeginEdit(true);
                    }
                }));
            }
            else
            {
                ShowAlert($"{assmMark} - Data not available");
                // Optionally remove invalid row
                DgvAssmData.Rows.RemoveAt(e.RowIndex);
                DgvAssmData.Rows.Add();
                DgvAssmData.CurrentCell = DgvAssmData.Rows[DgvAssmData.Rows.Count - 1].Cells["AssemblyID"];
            }

            IsValueChanged = false;

        }

        public DataTable GetMatchingRows(DataTable dt1, DataTable dt2, string keyColumn, string compareColumn)
        {
            // Create a result DataTable with desired columns
            DataTable result = new DataTable();
            result.Columns.Add(keyColumn, dt1.Columns[keyColumn].DataType);
            result.Columns.Add(compareColumn, dt1.Columns[compareColumn].DataType);

            // Find matching rows based on key and column value
            var matchingRows = from row1 in dt1.AsEnumerable()
                               join row2 in dt2.AsEnumerable()
                               on row1[keyColumn] equals row2[keyColumn]
                               where row1[compareColumn].Equals(row2[compareColumn])
                               select new
                               {
                                   Key = row1[keyColumn],
                                   Value = row1[compareColumn]
                               };

            // Add matches to result table
            foreach (var match in matchingRows)
            {
                result.Rows.Add(match.Key, match.Value);
            }

            return result;
        }

        private void AssmPos_AlreadyExist(DataGridViewCellEventArgs e, string enteredValue, string assmMark, ref bool isDuplicate, ref int rowToRemoveIndex, int prevQty)
        {
            foreach (DataGridViewRow row in DgvAssmData.Rows)
            {
                if (row.Index == e.RowIndex || row.IsNewRow) continue;

                row.DefaultCellStyle.BackColor = Color.White;

                string existingValue = row.Cells["AssemblyID"].Value?.ToString();
                if (existingValue != enteredValue) continue;

                int.TryParse(row.Cells["BOMQTY"].Value?.ToString(), out int bomQty);
                int qty = 0;

                if (int.TryParse(row.Cells["AssemblyQty"].Value?.ToString(), out qty))
                {
                    if (qty + prevQty >= bomQty)
                    {
                        ShowAlert($"{assmMark} - Quantity exceeded");

                        // Defer re-entering edit mode to avoid recursion
                        this.BeginInvoke(new MethodInvoker(() =>
                        {
                            KryptonMessageBox.Show($"{assmMark} - Quantity cannot be more than BOM/INPUT Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            DgvAssmData.CurrentCell = DgvAssmData.Rows[DgvAssmData.Rows.Count - 1].Cells["AssemblyID"];
                            DgvAssmData.BeginEdit(true);

                        }));

                        //return;
                    }
                    else
                    {
                        row.Cells["AssemblyQty"].Value = qty + 1;
                    }
                }
                else
                {
                    row.Cells["AssemblyQty"].Value = 1;
                }

                row.DefaultCellStyle.BackColor = Color.Yellow;

                // Mark current row for removal (duplicate)
                rowToRemoveIndex = e.RowIndex;
                isDuplicate = true;
            }
        }

        private void AssmPos_NotExist(DataGridViewCellEventArgs e, bool isDuplicate, DataTable assmData, DataGridViewRow currentRow, string assmMark, int rowToRemoveIndex, int prevQty)
        {
            if (!isDuplicate)
            {
                if (assmData.Rows.Count > 0)
                {
                    string theRefId = "";

                    foreach (DataRow dr in assmData.Rows)
                    {
                        string CurID = dr["RefID"].ToString();
                        theRefId = theRefId + "," + CurID;
                    }

                    theRefId = theRefId.TrimStart(',');

                    var dataRow = assmData.Rows[0];

                    string assmPhaseId = dataRow["ASSMPHASEID"].ToString();
                    string assmName = dataRow["ASSMNAME"].ToString();

                    int.TryParse(dataRow["ASSMQTY"].ToString(), out int assmBomQty);
                    if (!IsEntry) assmBomQty = assmData.Rows.Count;

                    string assmUnitWt = dataRow["ASSMUNITWEIGHT"].ToString();

                    string prodDate = Convert.ToDateTime(dtpikProd.Value).ToString("dd-MMM-yyyy"); //("dd-MMM-yyyy HH:mm:ss");

                    string currentQtyStr = currentRow.Cells["AssemblyQty"].Value?.ToString();
                    string PrevQtyStr = currentRow.Cells["PrevQty"].Value?.ToString();

                    int.TryParse(currentQtyStr, out int currentQty);
                    int.TryParse(PrevQtyStr, out int PrvQty);
                    //int.TryParse(assmBomQty, out int bomQty);

                    if (currentQtyStr == null)
                    {
                        currentRow.Cells["AssemblyQty"].Value = 1;
                    }
                    else if (currentQty + PrvQty > assmBomQty)
                    {
                        //currentRow.Cells["AssemblyQty"].Value = bomQty;
                        ShowAlert($"{assmMark} - Quantity exceeded");

                        // Defer re-entering edit mode to avoid recursion
                        this.BeginInvoke(new MethodInvoker(() =>
                        {
                            KryptonMessageBox.Show($"{assmMark} - Quantity cannot be more than BOM/INPUT Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            DgvAssmData.CurrentCell = currentRow.Cells["AssemblyQty"];
                            DgvAssmData.BeginEdit(true);
                            IsValueChanged = true;
                        }));

                        //return;
                    }
                    else if (currentQty > 0)
                    {
                        currentRow.Cells["AssemblyQty"].Value = currentQty;
                    }
                    else
                    {
                        // Defer re-entering edit mode to avoid recursion
                        DgvAssmData.Rows.RemoveAt(e.RowIndex);
                        return;
                    }

                    // Fill in row values
                    currentRow.Cells["PhaseId"].Value = assmPhaseId;
                    currentRow.Cells["PhaseRev"].Value = ""; //phaseRev";
                    currentRow.Cells["AssmMark"].Value = assmMark;
                    currentRow.Cells["AssmName"].Value = assmName;
                    currentRow.Cells["PrevQty"].Value = prevQty;
                    currentRow.Cells["BOMQTY"].Value = assmBomQty;
                    currentRow.Cells["AssmUnitWT"].Value = assmUnitWt;
                    currentRow.Cells["Date"].Value = prodDate;
                    currentRow.Cells["Status"].Value = CurrentStatus;
                    currentRow.Cells["RefID"].Value = theRefId;

                    currentRow.DefaultCellStyle.BackColor = Color.Yellow;

                    // Optional: Reset previous row color
                    if (e.RowIndex > 0)
                    {
                        DgvAssmData.Rows[e.RowIndex - 1].DefaultCellStyle.BackColor = Color.White;
                    }
                }
                else
                {
                    ShowAlert("BOM Data missing");
                    // Optionally remove invalid row
                    DgvAssmData.Rows.RemoveAt(e.RowIndex);
                }
            }
            else if (rowToRemoveIndex >= 0)
            {
                DgvAssmData.Rows.RemoveAt(rowToRemoveIndex);
            }
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var assemblyCell = DgvAssmData.Rows[DgvAssmData.Rows.Count - 1].Cells["AssemblyID"];

            if (assemblyCell?.Value == null) return;

            DgvAssmData.Rows.Add();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SaveTheData();
        }
        
        private void SaveTheData()
        {
            bool isSuccess = false;
            IsUpdated = false;

            if (kcbBaySel.Visible && kcbBaySel.SelectedIndex == -1)
            {
                KryptonMessageBox.Show("Select the SAW - Bay (1 or 4) ", "Bay selection !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tslStatus.Text = "! Select the SAW - Bay (1 or 4) ";
                return;
            }

            if (DgvAssmData.Rows.Count <= 0)
            {
                KryptonMessageBox.Show("Data not found?", "Error..?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tslStatus.Text = "! Data not found ";
                return;
            }

            string[] sqlQueries = new string[0];

            foreach (DataGridViewRow row in DgvAssmData.Rows)
            {
                var phaseValue = row.Cells["PhaseId"];

                if (phaseValue?.Value != null)
                {
                    object[] fVlas = new object[15];

                    int.TryParse(row.Cells["AssemblyQty"].Value.ToString(), out int asmQty);
                    string thePhaseId = row.Cells["PhaseId"].Value.ToString();
                    string theAssmMak = row.Cells["AssmMark"].Value.ToString();
                    string theStatus = row.Cells["Status"].Value.ToString();
                    string theBay = kcbBaySel.Text;
                    //string thelock = "P";


                    string[] splitids = row.Cells["RefID"].Value.ToString().Split(',');

                    DataTable assmData = DBClasses.DBReader.Load_OpenedAssembly_Datas(theDb, thePhaseId, theAssmMak, CurrentStatus);


                    if (asmQty > 0)
                    {
                        int inc = 1;

                        if (assmData.Rows.Count > 0)
                        {
                            foreach (string refId in splitids)
                            {
                                if (asmQty >= inc)
                                {
                                    DataRow[] foundRows = assmData.Select("REFID = '" + refId + "'");

                                    if (foundRows.Length > 0)
                                    {
                                        NewMethod(ref isSuccess, ref sqlQueries, row, fVlas, thePhaseId, theAssmMak, theStatus, "P", refId, theBay);
                                        inc = inc + 1;
                                    }                                   
                                }
                            }
                        }
                        else
                        {
                            if (row.Cells["RefID"].Value.ToString() == "0")
                            {
                                while (asmQty >= inc)
                                {
                                    //if (inc == 1) //because the first time the REFID is '0' for all duplicates.
                                    //    DBClasses.DBUpdate.Delete_Existing_Records(ref sqlQueries, thePhaseId, theAssmMak, theStatus, "P");

                                    NewMethod(ref isSuccess, ref sqlQueries, row, fVlas, thePhaseId, theAssmMak, theStatus, "P", row.Cells["RefID"].Value.ToString(), theBay);
                                    inc = inc + 1;
                                }
                            }
                        }
                    }
                }
            }

            if (isSuccess)
            {
                if (DBClasses.SqlServerDB.ExecuteTheQuery5(sqlQueries))
                {
                    isSuccess = true;
                    IsUpdated = true;
                    this.Close();
                    //tsStatus.Text = "Data saved successfully";
                    //Application.DoEvents();
                }
                else
                {
                    isSuccess = false;
                    IsUpdated = false;
                    //tsStatus.Text = "Error: unable to save the DB";
                    //Application.DoEvents();
                }
            }
        }

        private void NewMethod(ref bool isSuccess, ref string[] sqlQueries, DataGridViewRow row, object[] fVlas, string thePhaseId, string theAssmMak, string theStatus, string thelock, string refId, string theBay)
        {

            if (IsEntry)
            {
                fVlas[0] = Cart.ValidateNullvalue(row.Cells["PhaseId"].Value.ToString(), true) + ",";                   //PHASEID
                fVlas[1] = "";//Cart.ValidateNullvalue(row.Cells["PhaseRev"].Value, true) + ",";                             //PHASEREV
                fVlas[2] = Cart.ValidateNullvalue(row.Cells["AssmMark"].Value.ToString(), true) + ",";                  //AssmMark
                fVlas[3] = Cart.ValidateNullvalue(row.Cells["AssmName"].Value.ToString(), true) + ",";                  //AssmName
                fVlas[4] = Cart.ValidateNullvalue(1, true) + ",";                                                       //AssemblyQty
                fVlas[5] = Cart.ValidateNullvalue(row.Cells["AssmUnitWT"].Value.ToString(), true) + ",";                //AssmUnitWT
                fVlas[6] = Cart.ValidateNullvalue(row.Cells["Date"].Value.ToString(), true) + ",";                      //DATE
                fVlas[7] = Cart.ValidateNullvalue(Cart.CurrentLoginUser, true) + ",";                                   //Modifiedby
                fVlas[8] = "Format(getdate(), 'dd-MMM-yyyy HH:mm:ss')" + ",";                                           //Modifiedon
                fVlas[9] = Cart.ValidateNullvalue(row.Cells["Status"].Value.ToString(), true) + ",";                    //Status
                fVlas[10] = Cart.ValidateNullvalue(thelock, true) + ",";                                                //O-open, P-Processing, L-Locked
                fVlas[11] = Cart.ValidateNullvalue(refId, true) + ",";
                fVlas[12] = Cart.ValidateNullvalue("", true) + ",";                                                     //SHIFT AS NULL
                fVlas[13] = Cart.ValidateNullvalue(theBay, true);                                                       //BAY AS NULL

                if (DBClasses.DBInsert.Insert_MyStationData(ref sqlQueries, fVlas))
                {
                    isSuccess = true;
                }
            }
            else
            {
                DBClasses.DBUpdate.Delete_Existing_Records(ref sqlQueries, thePhaseId, theAssmMak, theStatus, thelock, refId);
                DBClasses.DBUpdate.Update_DataAsHold(ref sqlQueries, thePhaseId, theAssmMak, theStatus, "O", "P", refId);

                isSuccess = true;
            }            

        }       

        
        private void dgvPendingData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = (DataGridView)sender;
            DataGridViewRow row = dgv.Rows[e.RowIndex];

            // Format row number with leading zeros
            string strRowNumber = (e.RowIndex + 1).ToString("D" + dgv.RowCount.ToString().Length);

            // Measure size of the string
            SizeF size = e.Graphics.MeasureString(strRowNumber, dgv.ColumnHeadersDefaultCellStyle.Font);

            // Adjust row header width if necessary
            int requiredWidth = (int)(size.Width + 12);
            if (dgv.RowHeadersWidth < requiredWidth)
                dgv.RowHeadersWidth = requiredWidth;

            // Draw row number
            using (Brush brush = new SolidBrush(Color.Gray))
            {
                float x = e.RowBounds.Left + 8;
                float y = e.RowBounds.Top + (e.RowBounds.Height - size.Height) / 2;
                e.Graphics.DrawString(strRowNumber, dgv.ColumnHeadersDefaultCellStyle.Font, brush, x, y);
            }
        }
    }
}

