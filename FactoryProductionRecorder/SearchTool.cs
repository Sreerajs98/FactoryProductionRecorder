using AppCode;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FactoryProductionRecorder
{
    public partial class SearchTool : MetroFramework.Forms.MetroForm
    {
        public DataTable AllStatus = new DataTable();

        public string theDb = "";
        public string CurrentStatus = "SWC";
        public string StatusGroup = "";

        public SearchTool()
        {
            InitializeComponent();

            this.Visible = false;

            MainForm.PassStringArray += new ePrmProdDelegates.ePrmProdCustomHandler(MainForm_PassStringArray);
        }

        private void MainForm_PassStringArray(object sender, ePrmProdDelegates.ePrmProdCustomEventArg e)
        {
            try
            {
                if (e.SelectedString != null)
                {
                    if (e.SelectedString == "Refresh")
                    {
                        if (rbPhase.Checked)
                            FilterTheSelectedPhaseData();
                        else if (rbAssembly.Checked)
                            GetAssemblyDistributionList();
                    }
                    else
                    {
                        CurrentStatus = e.SelectedString;

                        if (CurrentStatus != "PPD")
                            DgvNextStation.ContextMenuStrip = null;

                        if (rbPhase.Checked)
                            FilterTheSelectedPhaseData();
                        else if (rbAssembly.Checked)
                            GetAssemblyDistributionList();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void SearchTool_Load(object sender, EventArgs e)
        {
            lblActual.Text = "";

            this.BeginInvoke(new MethodInvoker(() =>
            {
                tbSearch.Select();
                tbSearch.SelectAll();
            }));
        }

        private void cbHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAssembly.Checked && cbHistory.Checked)
                kryptonGroupBox1.Text = "Assembly change history log";

            GetAssemblyDistributionList();

        }

        private void CommonCheckChanged(object sender, EventArgs e)
        {
            tsAssmPos.Visible = false;
            tsAssmQty.Visible = false;
            tsDot.Visible = false;
            tsStatus.Text = "";

            this.BeginInvoke(new MethodInvoker(() =>
            {
                tbSearch.Select();
                tbSearch.SelectAll();
            }));

            if (rbPhase.Checked)
            {
                cbHistory.Visible = false;

                kryptonGroupBox1.Text = "My Station log";

                if (lblActual.Text.ToString() == "") return;
                tbSearch.Text = lblActual.Text;
                FilterTheSelectedPhaseData();
            }
            else if (rbAssembly.Checked)
            {
                cbHistory.Visible = true;

                kryptonGroupBox1.Text = "Assembly Distribution List";

                if (lblActual.Text.ToString() == "") return;

                tbSearch.Text = lblActual.Text;
                GetAssemblyDistributionList();
            }

        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsStatus.Text = "";

                if (rbPhase.Checked)
                    FilterTheSelectedPhaseData();
                else if (rbAssembly.Checked)
                    GetAssemblyDistributionList();
            }
        }

        private void BtnSrch_Click(object sender, EventArgs e)
        {
            tsStatus.Text = "";

            if (rbPhase.Checked)
                FilterTheSelectedPhaseData();
            else if (rbAssembly.Checked)
                GetAssemblyDistributionList();
        }

        private void FilterTheSelectedPhaseData()
        {
            DgvNextStation.DataSource = null;

            if (tbSearch.Text.Contains("-") && tbSearch.Text.Length >= 12)
            {
                string[] splitParts = tbSearch.Text.Split('-');

                if (splitParts.Length < 3)
                {
                    KryptonMessageBox.Show("Invalid AssemblyID format. Expected format: Axxxx-xx-xxx-xx-XXxxx", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbSearch.Select();
                    tbSearch.SelectAll();
                    return;
                }

                string phaseId = $"{splitParts[0]}-{splitParts[1]}-{splitParts[2]}";
                //string phaseRev = splitParts[3];
                //string assmMark = splitParts[4];

                lblActual.Text = tbSearch.Text;
                tbSearch.Text = phaseId;

                DataTable AllProcessingData = DBClasses.DBReader.Load_AllAssembly_Log(theDb, phaseId, CurrentStatus);

                if (AllProcessingData.Rows.Count > 0)
                {
                    DgvNextStation.DataSource = AllProcessingData;
                    Cart.FormatStationLog(DgvNextStation);

                    tsStatus.Text = "Data loaded succesfully";
                }
            }

            tbSearch.Select();
            tbSearch.SelectAll();
        }


        private void GetAssemblyDistributionList()
        {
            DgvNextStation.DataSource = null;

            if (tbSearch.Text.Contains("-") && tbSearch.Text.Length > 18)
            {
                string[] splitParts = tbSearch.Text.Split('-');

                if (splitParts.Length != 5)
                {
                    KryptonMessageBox.Show("Invalid AssemblyID format. Expected format: Axxxx-xx-xxx-xx-XXxxx", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbSearch.Select();
                    tbSearch.SelectAll();
                    return;
                }

                lblActual.Text = tbSearch.Text;

                string phaseId = $"{splitParts[0]}-{splitParts[1]}-{splitParts[2]}";
                string phaseRev = splitParts[3];
                string assmMark = splitParts[4];

                if (!cbHistory.Checked)
                {
                    DataTable AllProcessingData = DBClasses.DBReader.Load_AllAssembly_DistributionDatas(theDb, phaseId, assmMark, StatusGroup);

                    if (AllProcessingData.Rows.Count > 0)
                    {
                        DgvNextStation.DataSource = AllProcessingData;
                        Cart.FormatStationData(DgvNextStation);

                        tsAssmPos.Visible = true; tsAssmPos.Text = assmMark;
                        tsAssmQty.Visible = true; tsAssmQty.Text = DgvNextStation.Rows.Count.ToString();
                        tsDot.Visible = true;

                        tsStatus.Text = "Data loaded succesfully";
                    }
                }
                else
                {
                    DataTable AllProcessingData = DBClasses.DBReader.Load_AllAssembly_LogDatas(theDb, phaseId, assmMark);

                    if (AllProcessingData.Rows.Count > 0)
                    {
                        DgvNextStation.DataSource = AllProcessingData;
                        DgvNextStation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                        tsAssmPos.Visible = false; 
                        tsAssmQty.Visible = false;
                        tsDot.Visible = false;

                        tsStatus.Text = "Data loaded succesfully";
                    }
                }
            }

            tbSearch.Select();
            tbSearch.SelectAll();
        }

        private void tbSearch_MouseMove(object sender, MouseEventArgs e)
        {
            tbSearch.Select();
        }       

        private void DgvNextStation_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = (DataGridView)sender;
            DataGridViewRow row = dgv.Rows[e.RowIndex];

            // Set alternating row style if not highlighted (Yellow)
            if (row.Cells[6].Value.ToString() == "Completed")
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.Cells[6].Style.BackColor = Color.Honeydew;
                row.DefaultCellStyle.ForeColor = Color.Brown;
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

        private void DgvNextStation_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && CurrentStatus == "PPD")
            {
                // Get the row index under the mouse pointer
                DataGridView.HitTestInfo hitTestInfo = DgvNextStation.HitTest(e.X, e.Y);

                if (hitTestInfo.RowIndex >= 0)
                {
                    DataGridViewRow clickedRow = DgvNextStation.Rows[hitTestInfo.RowIndex];

                    // Show context menu only if the clicked row is already selected
                    if (clickedRow.Selected && rbAssembly.Checked)
                    {
                        DgvNextStation.ContextMenuStrip = cms_AddEdit;
                        DgvNextStation.ContextMenuStrip.Show(DgvNextStation, new Point(e.X, e.Y));
                    }
                    else
                    {
                        DgvNextStation.ContextMenuStrip = null;
                    }
                }
                else
                {
                    DgvNextStation.ContextMenuStrip = null;
                }
            }
            else if(e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hitTestInfo = DgvNextStation.HitTest(e.X, e.Y);

                if (hitTestInfo.RowIndex >= 0)
                {
                    DataGridViewRow clickedRow = DgvNextStation.Rows[hitTestInfo.RowIndex];

                    // Show context menu only if the clicked row is already selected
                    if (clickedRow.Selected && rbPhase.Checked)
                    {
                        DgvNextStation.ContextMenuStrip = cmsBay;
                        //DgvNextStation.ContextMenuStrip.Show(DgvNextStation, new Point(e.X, e.Y));
                    }
                    else
                    {
                        DgvNextStation.ContextMenuStrip = null;
                    }
                }
                else
                {
                    DgvNextStation.ContextMenuStrip = null;
                }
            }
        }

        private void msReturnto_Click(object sender, EventArgs e)
        {

            // Get the menu item that triggered the click
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            if (menuItem != null)
            {
                // Get the owning ToolStrip (MenuStrip)
                ToolStrip toolStrip = menuItem.GetCurrentParent();

                if (toolStrip != null)
                {
                    // Get the position of the menu item within the ToolStrip
                    Rectangle itemBounds = menuItem.Bounds;

                    // Convert the menu item's bounds to screen coordinates
                    Point screenPoint = toolStrip.PointToScreen(new Point(itemBounds.X, itemBounds.Bottom));

                    Screen currentScreen = Screen.FromControl(this);
                    Rectangle workingArea = currentScreen.WorkingArea;

                    // Create and show the form at that position
                    MoveTo form = new MoveTo();
                    screenPoint.X = screenPoint.X + 50 - form.Width;
                    screenPoint.Y = screenPoint.Y - 10;

                    if (screenPoint.Y + form.Height > workingArea.Height)
                        screenPoint.Y = workingArea.Height - form.Height;

                    form.StartPosition = FormStartPosition.Manual;
                    form.Location = screenPoint;
                    form.AllowToProceed = false;
                    form.AllStatus = AllStatus;
                    form.IsReturn = true;
                    form.TheNextStatus = "";
                    form.TheNextStatusSeqNum = "";
                    form.AssmPhaseId = DgvNextStation.SelectedRows[0].Cells["ASSMPHASEID"].Value.ToString();
                    form.AssmPos = DgvNextStation.SelectedRows[0].Cells["Assmpos"].Value.ToString();
                    form.AssmPosQty = DgvNextStation.SelectedRows.Count.ToString();
                    form.ShowDialog();

                    if (form.AllowToProceed)
                    {
                        ReturnSelectedData(DgvNextStation.SelectedRows.Cast<DataGridViewRow>(), form.TheNextStatus, form.TheNextStatusSeqNum);
                    }
                }
            }
        }

        private void tsForwardTo_Click(object sender, EventArgs e)
        {
            // Get the menu item that triggered the click
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            if (menuItem != null)
            {
                // Get the owning ToolStrip (MenuStrip)
                ToolStrip toolStrip = menuItem.GetCurrentParent();

                if (toolStrip != null)
                {
                    // Get the position of the menu item within the ToolStrip
                    Rectangle itemBounds = menuItem.Bounds;

                    // Convert the menu item's bounds to screen coordinates
                    Point screenPoint = toolStrip.PointToScreen(new Point(itemBounds.X, itemBounds.Bottom));

                    Screen currentScreen = Screen.FromControl(this);
                    Rectangle workingArea = currentScreen.WorkingArea;

                    // Create and show the form at that position
                    MoveTo form = new MoveTo();
                    screenPoint.X = screenPoint.X + 50 - form.Width;
                    screenPoint.Y = screenPoint.Y - 10;

                    if (screenPoint.Y + form.Height > workingArea.Height)
                        screenPoint.Y = workingArea.Height - form.Height;

                    form.StartPosition = FormStartPosition.Manual;
                    form.Location = screenPoint;
                    form.AllowToProceed = false;
                    form.IsReturn = false;
                    form.AllStatus = AllStatus;
                    form.TheNextStatus = "";
                    form.TheNextStatusSeqNum = "";
                    form.AssmPhaseId = DgvNextStation.SelectedRows[0].Cells["ASSMPHASEID"].Value.ToString();
                    form.AssmPos = DgvNextStation.SelectedRows[0].Cells["Assmpos"].Value.ToString();
                    form.AssmPosQty = DgvNextStation.SelectedRows.Count.ToString();
                    form.ShowDialog();

                    if (form.AllowToProceed)
                    {
                        TransferSelectedData(DgvNextStation.SelectedRows.Cast<DataGridViewRow>(), form.TheNextStatus, form.TheNextStatusSeqNum);
                    }
                }
            }
        }

        private void ReturnSelectedData(IEnumerable<DataGridViewRow> theRows, string TheNextStatus, string TheNextStatusSeqNum)
        {
            bool isSuccess = false;

            if (theRows.Count() <= 0)
            {
                KryptonMessageBox.Show("Data not found?", "Error..?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] sqlQueries = new string[0];

            foreach (DataGridViewRow row in theRows)
            {
                string thePhaseId = row.Cells["ASSMPHASEID"].Value?.ToString();
                string theAssmMak = row.Cells["ASSMPOS"].Value?.ToString();
                string theCurrentStatus = row.Cells["STATUS"].Value?.ToString();
                string theSeqMak = row.Cells["StationSeq"].Value?.ToString();
                string theLock = row.Cells["ACTTHELOCK"].Value?.ToString();

                string theNewAssmMak =  "";

                string st = row.Cells["REFID"].Value?.ToString();
                string theShift = row.Cells["SHIFT"].Value?.ToString();
                string theBayId = row.Cells["BAYID"].Value?.ToString();

                int NewSeq = int.Parse(TheNextStatusSeqNum);
                int CurSeq = int.Parse(theSeqMak);


                if (NewSeq <= CurSeq)
                {
                    if (DBClasses.DBReader.Select_TranferedData(thePhaseId, theAssmMak, theCurrentStatus, theLock, st))
                    {
                        //this will delete all the existing transfered data which are not locked and upload all the new datas.
                        for (int i = NewSeq; i <= CurSeq; i++)
                        {
                            string theSta = AllStatus.Rows[i - 1][1].ToString();
                            DBClasses.DBUpdate.Delete_TranferedData(ref sqlQueries, thePhaseId, theAssmMak, theSta, st);
                            isSuccess = true;
                        }

                        if (DBClasses.DBInsert.Insert_toProdStatus_Record_Changes(ref sqlQueries,
                                                                                        thePhaseId,
                                                                                        theAssmMak,
                                                                                        theNewAssmMak,
                                                                                        theCurrentStatus,
                                                                                        TheNextStatus,
                                                                                        Cart.CurrentLoginUser,
                                                                                        "Format(getdate(), 'dd-MMM-yyyy HH:mm:ss')",
                                                                                        st, "Returned"))
                        {
                            if (NewSeq != 1)
                            {
                                object[] fVlas = new object[15];

                                fVlas[0] = Cart.ValidateNullvalue(row.Cells["ASSMPHASEID"].Value.ToString(), true) + ",";               //PHASEID
                                fVlas[1] = ",";                                                                                          //PHASEREV
                                fVlas[2] = Cart.ValidateNullvalue(row.Cells["ASSMPOS"].Value.ToString(), true) + ",";                   //AssmMark
                                fVlas[3] = Cart.ValidateNullvalue(row.Cells["ASSMNAME"].Value.ToString(), true) + ",";                  //AssmName
                                fVlas[4] = Cart.ValidateNullvalue(1, true) + ",";                                                       //AssemblyQty
                                fVlas[5] = Cart.ValidateNullvalue(row.Cells["ASSMUNITWEIGHT"].Value.ToString(), true) + ",";            //AssmUnitWT
                                fVlas[6] = "Format(getdate(), 'dd-MMM-yyyy HH:mm:ss')" + ",";                                           //DATE
                                fVlas[7] = Cart.ValidateNullvalue(Cart.CurrentLoginUser, true) + ",";                                   //Modifiedby
                                fVlas[8] = "Format(getdate(), 'dd-MMM-yyyy HH:mm:ss')" + ",";                                           //Modifiedon
                                fVlas[9] = Cart.ValidateNullvalue(TheNextStatus, true) + ",";                                           //Status
                                fVlas[10] = Cart.ValidateNullvalue("O", true) + ",";                                                    //O-open, P-Processing, L-Locked
                                fVlas[11] = Cart.ValidateNullvalue(st, true) + ",";                                                     //REFID
                                fVlas[12] = Cart.ValidateNullvalue(theShift, true) + ",";                                               //SHIFT
                                fVlas[13] = Cart.ValidateNullvalue(theBayId, true);                                                     //BAYID

                                if (DBClasses.DBInsert.Insert_MyStationData(ref sqlQueries, fVlas))
                                {
                                    isSuccess = true;

                                    row.Cells["Remark"].Value = "Moved";
                                    row.Cells["STATUS"].Value = TheNextStatus;
                                    row.Cells["Station"].Value = AllStatus.Rows[NewSeq - 1][3].ToString();
                                    row.Cells["StationSeq"].Value = NewSeq;
                                    row.Cells["THELOCK"].Value = "OPEN";
                                }
                            }
                            else
                            {

                            }
                        }
                    }
                    else
                    {
                        row.Cells["Remark"].Value = "Error: NOT EXIST";
                        tsStatus.Text = "#Error# Refresh the data and check";
                    }
                }
                else if (NewSeq < CurSeq)
                {
                    row.Cells["Remark"].Value = "Same";
                }
                else
                {
                    row.Cells["Remark"].Value = "#Error";
                }
            }

            if (isSuccess)
            {
                if (DBClasses.SqlServerDB.ExecuteTheQuery5(sqlQueries))
                {
                    isSuccess = true;

                    if (int.Parse(TheNextStatusSeqNum) == 1)
                        GetAssemblyDistributionList();

                    //refreshtheProcessingData();
                    //refreshtheNextStationData();
                    //tslStatus.Text = "Data transfered successfully";
                }
                else
                {
                    isSuccess = false;
                }
            }
        }

        private void TransferSelectedData(IEnumerable<DataGridViewRow> theRows, string TheNextStatus, string TheNextStatusSeqNum)
        {
            bool isSuccess = false;

            if (theRows.Count() <= 0)
            {
                KryptonMessageBox.Show("Data not found?", "Error..?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] sqlQueries = new string[0];

            foreach (DataGridViewRow row in theRows)
            {
                string thePhaseId = row.Cells["ASSMPHASEID"].Value?.ToString();
                string theAssmMak = row.Cells["ASSMPOS"].Value?.ToString();
                string theCurrentStatus = row.Cells["STATUS"].Value?.ToString();
                string theCurrentLock = row.Cells["ACTTHELOCK"].Value?.ToString();
                string theSeqMak = row.Cells["StationSeq"].Value?.ToString();

                string theLock = row.Cells["ACTTHELOCK"].Value?.ToString();
                string theNewAssmMak = "";

                string st = row.Cells["REFID"].Value?.ToString();
                string refst = row.Cells["REFID"].Value?.ToString();
                string theShift = row.Cells["SHIFT"].Value?.ToString();

                int NewSeq = int.Parse(TheNextStatusSeqNum);
                int CurSeq = int.Parse(theSeqMak);

                if (CurSeq <= NewSeq )
                {
                    if (DBClasses.DBReader.Select_TranferedData(thePhaseId, theAssmMak, theCurrentStatus, theLock, ref st))
                    {

                        if (DBClasses.DBInsert.Insert_toProdStatus_Record_Changes(ref sqlQueries,
                                                                                    thePhaseId,
                                                                                    theAssmMak,
                                                                                    theNewAssmMak,
                                                                                    theCurrentStatus,
                                                                                    TheNextStatus,
                                                                                    Cart.CurrentLoginUser,
                                                                                    "Format(getdate(), 'dd-MMM-yyyy HH:mm:ss')",
                                                                                    st, "Forwarded"))
                        {
                            string updatelock = theCurrentLock;

                            for (int i = CurSeq; i < NewSeq; i++)
                            {
                                string theCurSta = AllStatus.Rows[i - 1][1].ToString();
                                string theNextSta = AllStatus.Rows[i][1].ToString();

                                if (i != CurSeq) theShift = "";

                                if (refst == "0")
                                {
                                    refst = st;
                                    DBClasses.DBInsert.Insert_toNextStation_IDBased(ref sqlQueries, thePhaseId, theAssmMak, updatelock, "O", Cart.CurrentLoginUser, "Format(getdate(), 'dd-MMM-yyyy HH:mm:ss')", theCurSta, theNextSta, refst);
                                    DBClasses.DBUpdate.Update_Lock_ForTheSelectedData_IDBased(ref sqlQueries, thePhaseId, theAssmMak, "L", updatelock, theCurSta, Cart.CurrentLoginUser, "Format(getdate(), 'dd-MMM-yyyy HH:mm:ss')", refst);
                                }
                                else
                                {
                                    DBClasses.DBInsert.Insert_toNextStation(ref sqlQueries, thePhaseId, theAssmMak, updatelock, "O", Cart.CurrentLoginUser, "Format(getdate(), 'dd-MMM-yyyy HH:mm:ss')", theCurSta, theNextSta, refst, theShift);
                                    DBClasses.DBUpdate.Update_Lock_ForTheSelectedData(ref sqlQueries, thePhaseId, theAssmMak, "L", updatelock, theCurSta, Cart.CurrentLoginUser, "Format(getdate(), 'dd-MMM-yyyy HH:mm:ss')", refst, theShift);
                                }

                                refst = st;
                                updatelock = "O";
                                isSuccess = true;
                            }

                            if (DBClasses.SqlServerDB.ExecuteTheQuery5(sqlQueries))
                                sqlQueries = new string[0];
                        }

                        row.Cells["Remark"].Value = "Moved";
                        row.Cells["STATUS"].Value = TheNextStatus;
                        row.Cells["Station"].Value = AllStatus.Rows[NewSeq - 1][3].ToString();
                        row.Cells["StationSeq"].Value = NewSeq;
                        row.Cells["THELOCK"].Value = "OPEN";
                    }
                    else
                    {
                        row.Cells["Remark"].Value = "Error: NOT EXIST";
                        tsStatus.Text = "#Error# Refresh the data and check";
                    }
                }
                else if (NewSeq > CurSeq)
                {
                    row.Cells["Remark"].Value = "Same";
                }
                else
                {
                    row.Cells["Remark"].Value = "#Error";
                }
            }

            if (isSuccess)
            {
                //if (DBClasses.SqlServerDB.ExecuteTheQuery5(sqlQueries))
                //{
                    isSuccess = true;

                    if (int.Parse(TheNextStatusSeqNum) == 1)
                        GetAssemblyDistributionList();

                    //refreshtheProcessingData();
                    //refreshtheNextStationData();
                    //tslStatus.Text = "Data transfered successfully";
                //}
                //else
                //{
                //    isSuccess = false;
                //}
            }
        }

        

        private void msRename_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;

            // Get the menu item that triggered the click
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            if (menuItem != null)
            {
                // Get the owning ToolStrip (MenuStrip)
                ToolStrip toolStrip = menuItem.GetCurrentParent();

                if (toolStrip != null)
                {
                    // Get the position of the menu item within the ToolStrip
                    Rectangle itemBounds = menuItem.Bounds;

                    // Convert the menu item's bounds to screen coordinates
                    Point screenPoint = toolStrip.PointToScreen(new Point(itemBounds.X, itemBounds.Bottom));

                    Screen currentScreen = Screen.FromControl(this);
                    Rectangle workingArea = currentScreen.WorkingArea;

                    // Create and show the form at that position
                    Rename form = new Rename();
                    form.StartPosition = FormStartPosition.Manual;
                    screenPoint.X = screenPoint.X + 50 - form.Width;
                    screenPoint.Y = screenPoint.Y - 40;

                    if (screenPoint.Y + form.Height > workingArea.Height)
                        screenPoint.Y = workingArea.Height - form.Height;

                    form.Location = screenPoint;
                    form.AssmPhaseId = DgvNextStation.SelectedRows[0].Cells["ASSMPHASEID"].Value.ToString();
                    form.AssmPos = DgvNextStation.SelectedRows[0].Cells["Assmpos"].Value.ToString();
                    form.AssmPosQty = DgvNextStation.SelectedRows.Count.ToString();
                    form.theDb = theDb;
                    form.ShowDialog();


                    if (form.AllowToProceed)
                    {
                        string[] sqlQueries = new string[0];

                        DataTable AllProcessingVsBOMData = form.AllProcessingVsBOMData;

                        if (AllProcessingVsBOMData.Rows.Count > 0)
                        {
                            //string theAssmQty = AllProcessingVsBOMData.Rows[0]["PROCESSEDQTY"].ToString();
                            //string theEngQty = AllProcessingVsBOMData.Rows[0]["ENGBOMQTY"].ToString();
                            int theBalQty = int.Parse(AllProcessingVsBOMData.Rows[0]["BALANCEQTY"].ToString());

                            int theCurrentSelectedQty = int.Parse(form.AssmPosQty);

                            if (theBalQty >= theCurrentSelectedQty)
                            {
                                foreach (DataGridViewRow row in DgvNextStation.SelectedRows)
                                {
                                    string thePhaseId = row.Cells["ASSMPHASEID"].Value?.ToString();
                                    string theAssmMak = row.Cells["ASSMPOS"].Value?.ToString();
                                    string theCurrentStatus = row.Cells["STATUS"].Value?.ToString();
                                    string theCurrentLock = row.Cells["ACTTHELOCK"].Value?.ToString();
                                    string theSeqMak = row.Cells["StationSeq"].Value?.ToString();
                                    string st = row.Cells["REFID"].Value?.ToString();

                                    if (DBClasses.DBInsert.Insert_toProdStatus_Record_Changes(ref sqlQueries,
                                                            thePhaseId,
                                                            theAssmMak,
                                                            form.AssmPosNew,
                                                            theCurrentStatus,
                                                            "",
                                                            Cart.CurrentLoginUser,
                                                            "Format(getdate(), 'dd-MMM-yyyy HH:mm:ss')",
                                                            st, "Renamed"))
                                    {
                                        if (DBClasses.DBUpdate.Update_AssmPos_OfSelectedData(ref sqlQueries, form.AssmPhaseId, form.AssmPos, form.AssmPosNew, st))
                                        {
                                            isSuccess = true;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                tsStatus.Text = "Error##, Assembly qty exceeds the BOM qty";

                                foreach (DataGridViewRow row in DgvNextStation.SelectedRows)
                                {
                                    row.Cells["Remark"].Value = "#Error";
                                }
                            }                            
                        }
                        else
                        {
                            KryptonMessageBox.Show("The new proposed assembly mark [" + form.AssmPosNew + "] is not exist in BOM, please check.?", "Check", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }

                        //--
                        if (isSuccess)
                        {
                            if (DBClasses.SqlServerDB.ExecuteTheQuery5(sqlQueries))
                            {
                                GetAssemblyDistributionList();
                                tsStatus.Text = "Data loaded succesfully";
                            }
                        }
                    }
                }
            }
        }

        private void SearchTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void tsEditBay_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;

            // Get the menu item that triggered the click
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            if (menuItem != null)
            {
                // Get the owning ToolStrip (MenuStrip)
                ToolStrip toolStrip = menuItem.GetCurrentParent();

                if (toolStrip != null)
                {
                    // Get the position of the menu item within the ToolStrip
                    Rectangle itemBounds = menuItem.Bounds;

                    // Convert the menu item's bounds to screen coordinates
                    Point screenPoint = toolStrip.PointToScreen(new Point(itemBounds.X, itemBounds.Bottom));

                    Screen currentScreen = Screen.FromControl(this);
                    Rectangle workingArea = currentScreen.WorkingArea;

                    // Create and show the form at that position
                    BayTo form = new BayTo();
                    form.StartPosition = FormStartPosition.Manual;
                    screenPoint.X = screenPoint.X + 50 - form.Width;
                    screenPoint.Y = screenPoint.Y - 40;

                    if (screenPoint.Y + form.Height > workingArea.Height)
                        screenPoint.Y = workingArea.Height - form.Height;

                    form.TheBay = DgvNextStation.SelectedRows[0].Cells["BAYID"].Value.ToString();
                    form.Location = screenPoint;
                    form.ShowDialog();


                    if (form.AllowToProceed)
                    {
                        string[] sqlQueries = new string[0];

                        foreach (DataGridViewRow row in DgvNextStation.SelectedRows)
                        {
                            string thePhaseId = row.Cells["PHASEID"].Value?.ToString();
                            string theAssmMak = row.Cells["ASSMPOS"].Value?.ToString();
                            string theCurrentStatus = row.Cells["STATUS"].Value?.ToString();
                            string theCurrentLock = row.Cells["ACTTHELOCK"].Value?.ToString();
                            string theSeqMak = row.Cells["StationSeq"].Value?.ToString();
                            string st = row.Cells["REFID"].Value?.ToString();

                            //sr.[PHASEID],
                            //                    sr.[ASSMPOS],
                            //                    MAX(sr.[ASSMNAME]) AS ASSMNAME,
                            //                    sa.TotalAssmQty AS PROCESSEDQTY,
                            //                    MAX(AYT.[ASSMQTY]) AS ENGBOMQTY,
                            //                    MAX(AYT.[ASSMQTY]) -sa.TotalAssmQty as BALANCEQTY,
                            //                    CASE
                            //                            WHEN MAX(AYT.[ASSMQTY]) - sa.TotalAssmQty = 0 THEN 'Completed'
                            //                            ELSE 'Pending'
                            //                        END AS PRODSTATUS,
                            //                    MAX(sr.BAYID) as BAYID


                            //if (DBClasses.DBInsert.Insert_toProdStatus_Record_Changes(ref sqlQueries,
                            //                        thePhaseId,
                            //                        theAssmMak,
                            //                        form.AssmPosNew,
                            //                        theCurrentStatus,
                            //                        "",
                            //                        Cart.CurrentLoginUser,
                            //                        "Format(getdate(), 'dd-MMM-yyyy HH:mm:ss')",
                            //                        st, "Renamed"))
                            //{
                            //    if (DBClasses.DBUpdate.Update_AssmPos_OfSelectedData(ref sqlQueries, form.AssmPhaseId, form.AssmPos, form.AssmPosNew, st))
                            //    {
                            //        isSuccess = true;
                            //    }
                            //}
                        }

                        //--
                        if (isSuccess)
                        {
                            if (DBClasses.SqlServerDB.ExecuteTheQuery5(sqlQueries))
                            {
                                GetAssemblyDistributionList();
                                tsStatus.Text = "Data loaded succesfully";
                            }
                        }
                    }
                }
            }
        }

    }
}
