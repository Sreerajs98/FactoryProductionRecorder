using AppCode;
using ComponentFactory.Krypton.Toolkit;
using MyExcelClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FactoryProductionRecorder
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {

        SplashScreen NewSplash = new SplashScreen();

        public string CurrentStatus = "SWC";
        public string NextStatus = "SWQ";
        public bool isEntry = false;
        public string theDb = "";


        public DataTable AllStatus = new DataTable();

        public static event ePrmProdDelegates.ePrmProdCustomHandler PassStringArray;

        public MainForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            //// Get the screen where the current form is displayed
            //Screen currentScreen = Screen.FromControl(this);
            //Rectangle workingArea = currentScreen.WorkingArea;


            //// Set the desired dimensions
            //int desiredTop = workingArea.Top + 40;
            //int desiredHeight = workingArea.Height - 80;
            //int desiredWidth = workingArea.Width - 608;   //Custom padding


            //// Apply the layout to the form
            //this.StartPosition = FormStartPosition.Manual;
            //this.Top = desiredTop;
            //this.Height = desiredHeight;
            //this.Width = desiredWidth;

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            try
            {
                AllStatus = DBClasses.DBReader.AllStatusData(theDb);

                AppCode.Cart.EmployeeData = DBClasses.DBReader.GetEmployeeDetails(Cart.CurrentLoginUser);

                //1//rbGen.Checked = true;

            }
            catch (Exception epp)
            {
                MessageBox.Show(epp.Message);
                this.Close();
            }

            this.Opacity = 100;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;

            Cart.TheDBInstance = "PROD";            
            //Cart.TheDBInstance = "DEV";


            DBClasses.SqlServerDB.setInstance(Cart.TheDBInstance);
            if (Cart.TheDBInstance == "DEV") theDb = "_DEV";
            Cart.CurrentLoginUser = Environment.UserName;

        }

        public void kcbAllStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           //AfterPageLoading();
        }

        private void AfterPageLoading()
        {
            string selStatus = kcbAllStatus.Text.ToString();
            int theNex = 0;

            if (kcbAllStatus.Text.ToString() == "SWC" || kcbAllStatus.Text.ToString() == "CFC" || (rbHR.Checked && kcbAllStatus.Text.ToString() == "FBC"))
                isEntry = true;
            else
                isEntry = false;


            CurrentStatus = kcbAllStatus.Text.ToString();


            // Try to find an existing SearchTool form
            SearchTool existingForm = Application.OpenForms
                                    .OfType<SearchTool>()
                                    .FirstOrDefault();

            if (existingForm != null)
            {
                if (PassStringArray != null)
                {
                    ePrmProdDelegates.ePrmProdCustomEventArg newArg = new ePrmProdDelegates.ePrmProdCustomEventArg();
                    newArg.SelectedString = CurrentStatus;
                    PassStringArray(null, newArg);
                    Application.DoEvents();
                }
            }


            DataRow[] foundRows = AllStatus.Select("StatusLabel = '" + selStatus + "' AND StatusUsed = '" + lblSeq.Text + "'");

            if (foundRows.Length > 0)
            {
                int.TryParse(foundRows[0][0]?.ToString(), out theNex);
                theNex = theNex + 1;
            }

            foundRows = AllStatus.Select("Seq = '" + theNex + "' AND StatusUsed = '" + lblSeq.Text + "'");

            if (foundRows.Length > 0)
            {
                NextStatus = foundRows[0][1].ToString();

                refreshtheProcessingData();
                refreshtheNextStationData();

                btAdd.Enabled = true;
                panel4.Enabled = true;
                panel3.Enabled = true;
                kryptonGroupBox1.Enabled = true;
                groupboxBOM.Enabled = true;
                btnRefresh.Enabled = true;

                tslStatus.Text = "Data loaded successfully";
            }
            else
            {
                DgvNextStation.DataSource = null;
                DgvAssmData.DataSource = null;

                btAdd.Enabled = false;
                panel4.Enabled = false;
                panel3.Enabled = false;
                kryptonGroupBox1.Enabled = false;
                groupboxBOM.Enabled = false;
                btnRefresh.Enabled = false;

                tslStatus.Text = "!Data NOT loaded!";
            }
        }

        private void kcbAllDescrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "( " + kcbAllDescrip.Text + " )";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (kcbAllStatus.Text.ToString() != "")
            {
                BarCodeReader br = new BarCodeReader();
                br.IsEntry = isEntry;
                br.CurrentStatus = CurrentStatus;
                br.NextStatus = NextStatus;
                br.theDb = theDb;
                br.ShowDialog();

                if (br.IsUpdated)
                {
                    refreshtheProcessingData();
                    refreshtheNextStationData();                    
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshtheProcessingData();
            refreshtheNextStationData();

            tslStatus.Text = "Data loaded successfully";
        }

        private void refreshtheProcessingData()
        {
            DataTable AllProcessingData = DBClasses.DBReader.LoadAllProcessingDatas(theDb, CurrentStatus, NextStatus);

            DgvAssmData.DataSource = null;
            DgvAssmData.DataSource = AllProcessingData;
            Cart.FormatProcessingData(DgvAssmData);
        }

        private void refreshtheNextStationData()
        {

            DataTable AllNextStationData = DBClasses.DBReader.LoadAllNextStationData(theDb, NextStatus);

            DgvNextStation.DataSource = null;
            DgvNextStation.DataSource = AllNextStationData;
            Cart.FormatNextStationData(DgvNextStation);

            if (PassStringArray != null)
            {
                ePrmProdDelegates.ePrmProdCustomEventArg newArg = new ePrmProdDelegates.ePrmProdCustomEventArg();
                newArg.SelectedString = "Refresh";
                PassStringArray(null, newArg);
                Application.DoEvents();
            }
        }


        private void DgvAssmData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedRowsFromCurrent();

                if (PassStringArray != null)
                {
                    ePrmProdDelegates.ePrmProdCustomEventArg newArg = new ePrmProdDelegates.ePrmProdCustomEventArg();
                    newArg.SelectedString = "Refresh";
                    PassStringArray(null, newArg);
                    Application.DoEvents();
                }
            }
        }

        private void DeleteSelectedRowsFromCurrent()
        {
            if (DgvAssmData.Rows.Count > 0)
            {
                int selectedRowCount = DgvAssmData.Rows.GetRowCount(DataGridViewElementStates.Selected);

                if (selectedRowCount > 0)
                {
                    // Store selected rows to delete after processing
                    List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in DgvAssmData.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            string thePhaseId = row.Cells["PhaseId"].Value?.ToString();
                            string theAssmMak = row.Cells["AssmPos"].Value?.ToString();
                            string theStatus = row.Cells["Status"].Value?.ToString();
                            string theRefId = row.Cells["RefID"].Value?.ToString();

                            string thelock = "P";

                            string[] sqlQueries = new string[0]; // Re-initialize per record, or use List<string> if batching

                            if (!isEntry)
                            {
                                string[] splitids = row.Cells["RefID"].Value.ToString().Split(',');

                                if (splitids.Length > 0)
                                {
                                    foreach (string st in splitids)
                                    {
                                        DBClasses.DBUpdate.Update_DataAsHold(ref sqlQueries, thePhaseId, theAssmMak, theStatus, "P", "O", st);
                                    }
                                }
                            }
                            else
                            {
                                DBClasses.DBUpdate.Delete_Existing_Records(ref sqlQueries, thePhaseId, theAssmMak, theStatus, thelock);
                            }

                            if (DBClasses.SqlServerDB.ExecuteTheQuery5(sqlQueries))
                            {
                                rowsToDelete.Add(row);
                            }
                        }
                    }

                    // Now safely remove rows after processing
                    //foreach (DataGridViewRow row in rowsToDelete)
                    //{
                    //    DgvAssmData.Rows.Remove(row);
                    //}
                    // Refresh after all deletions
                    //if (rowsToDelete.Count > 0)
                    //{
                    //    refreshtheData();
                    //    refreshtheData_Next();
                    //}
                }
            }
        }


        private void btnAllTransferToNextStation_Click(object sender, EventArgs e)
        {
            if (rbDay.Checked || rbNight.Checked)
            {
               TransferSelectedData(DgvAssmData.Rows.Cast<DataGridViewRow>());
            }
            else
            {
                KryptonMessageBox.Show("Select the Shift (Day/Night)", "Shift?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSingleTransferToNextStation_Click(object sender, EventArgs e)
        {
            if (rbDay.Checked || rbNight.Checked)
            {
                TransferSelectedData(DgvAssmData.SelectedRows.Cast<DataGridViewRow>());
            }
            else
            {
                KryptonMessageBox.Show("Select the Shift (Day/Night)", "Shift?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSingleReturnToProcessing_Click(object sender, EventArgs e)
        {
            DialogResult dr = KryptonMessageBox.Show("Are you sure you want to return all selected data?", "Return?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) { return; }

            ReturnSelectedData(DgvNextStation.SelectedRows.Cast<DataGridViewRow>());
        }

        private void btnAllReturnToProcessing_Click(object sender, EventArgs e)
        {
            DialogResult dr = KryptonMessageBox.Show("Are you sure you want to return all transferred data?", "Return?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) { return; }

            ReturnSelectedData(DgvNextStation.Rows.Cast<DataGridViewRow>());
        }


        private void TransferSelectedData(IEnumerable<DataGridViewRow> theRows)
        {
            bool isSuccess = false;

            if (theRows.Count() <= 0)
            {
                KryptonMessageBox.Show("Data not found?", "Error..?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string theShift = "DAY";
            if (rbNight.Checked) theShift = "NIGHT";


            string[] sqlQueries = new string[0];

            string TheDataLog = "";

            foreach (DataGridViewRow row in theRows)
            {
                string thePhaseId = row.Cells["PhaseId"].Value?.ToString();
                string theAssmMak = row.Cells["AssmPos"].Value?.ToString();
                string theRefMak = row.Cells["RefId"].Value?.ToString();                

                string[] splitids = theRefMak.Split(',');

                if (splitids.Length > 0)
                {
                    foreach (string st in splitids)
                    {
                        if (DBClasses.DBReader.Select_TranferedData(thePhaseId, theAssmMak, CurrentStatus, "P", st))
                        {
                            if (isEntry)
                            {
                                //this will delete all the existing transfered data which are not locked, and upload all the new datas.
                                if (DBClasses.DBUpdate.Delete_TranferedData_WithOutID(ref sqlQueries, thePhaseId, theAssmMak, CurrentStatus, "P", NextStatus, "O"))
                                {
                                    if (DBClasses.DBInsert.Insert_toNextStation(ref sqlQueries, thePhaseId, theAssmMak, "P", "O", Cart.CurrentLoginUser, "Format(getdate(), 'dd-MMM-yyyy HH:mm:ss')", CurrentStatus, NextStatus, st, theShift))
                                    {
                                        if (DBClasses.DBUpdate.Update_Lock_ForTheSelectedData(ref sqlQueries, thePhaseId, theAssmMak, "L", "P", CurrentStatus, Cart.CurrentLoginUser, "Format(getdate(), 'dd-MMM-yyyy HH:mm:ss')", st, theShift))
                                        {
                                            isSuccess = true;
                                        }
                                    }
                                }
                                break; //IF REFID = 0, Means all data will be, so single delete/insert/modify will work for all.
                            }
                            else
                            {
                                //this will delete all the existing transfered data which are not locked, and upload all the new datas.
                                if (DBClasses.DBUpdate.Delete_TranferedData(ref sqlQueries, thePhaseId, theAssmMak, NextStatus, "O", st))
                                {
                                    if (DBClasses.DBInsert.Insert_toNextStation(ref sqlQueries, thePhaseId, theAssmMak, "P", "O", Cart.CurrentLoginUser, "Format(getdate(), 'dd-MMM-yyyy HH:mm:ss')", CurrentStatus, NextStatus, st, theShift))
                                    {
                                        if (DBClasses.DBUpdate.Update_Lock_ForTheSelectedData(ref sqlQueries, thePhaseId, theAssmMak, "L", "P", CurrentStatus, Cart.CurrentLoginUser, "Format(getdate(), 'dd-MMM-yyyy HH:mm:ss')", st, theShift))
                                        {
                                            isSuccess = true;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            TheDataLog = " - Some Qty not exist (someone moved)";
                        }
                    }
                }
            }

            if (isSuccess)
            {
                if (DBClasses.SqlServerDB.ExecuteTheQuery5(sqlQueries))
                {
                    isSuccess = true;
                    refreshtheProcessingData();
                    refreshtheNextStationData();
                    tslStatus.Text = "Data transfered successfully" + TheDataLog;
                }
                else
                {
                    isSuccess = false;
                }
            }
            else
            {
                refreshtheProcessingData();
                refreshtheNextStationData();
                tslStatus.Text = "#Unable to transfered data#" + TheDataLog;
            }
        }

        private void ReturnSelectedData(IEnumerable<DataGridViewRow> theRows)
        {
            bool isSuccess = false;


            if (theRows.Count() <= 0)
            {
                KryptonMessageBox.Show("Data not found?", "Error..?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] sqlQueries = new string[0];

            string TheDataLog = "";

            foreach (DataGridViewRow row in theRows)
            {
                string thePhaseId = row.Cells["PhaseId"].Value?.ToString();
                string theAssmMak = row.Cells["AssmPos"].Value?.ToString();
                string theRefMak = row.Cells["RefId"].Value?.ToString();

                string[] splitids = theRefMak.Split(',');

                if (splitids.Length > 0)
                {
                    foreach (string st in splitids)
                    {
                        if (DBClasses.DBReader.Select_TranferedData(thePhaseId, theAssmMak, NextStatus, "O", st))
                        {
                            if (isEntry)
                            {
                                //this will delete all the existing transfered data which are not locked, and upload all the new datas.
                                if (DBClasses.DBUpdate.Delete_TranferedData(ref sqlQueries, thePhaseId, theAssmMak, NextStatus, "O", st))
                                {
                                    if (DBClasses.DBUpdate.Update_Lock_ForTheSelectedData_WithOutId(ref sqlQueries, thePhaseId, theAssmMak, "P", "L", CurrentStatus, st))
                                    {
                                        isSuccess = true;
                                    }
                                }
                            }
                            else
                            {
                                //this will delete all the existing transfered data which are not locked, and upload all the new datas.
                                if (DBClasses.DBUpdate.Delete_TranferedData(ref sqlQueries, thePhaseId, theAssmMak, NextStatus, "O", st))
                                {
                                    if (DBClasses.DBUpdate.Update_Lock_ForTheSelectedData_WithId(ref sqlQueries, thePhaseId, theAssmMak, "P", "L", CurrentStatus, st))
                                    {
                                        isSuccess = true;
                                    }
                                }
                            }
                        }
                        else
                        {
                            TheDataLog = " - All Qty not exist (moved already)";
                        }
                    }
                }
            }

            if (isSuccess)
            {
                if (DBClasses.SqlServerDB.ExecuteTheQuery5(sqlQueries))
                {
                    isSuccess = true;
                    refreshtheProcessingData();
                    refreshtheNextStationData();
                    tslStatus.Text = "Data returned successfully" + TheDataLog;
                }
                else
                {
                    isSuccess = false;
                }
            }
        }


        private void DgvAssmData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void DgvNextStation_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void rbCheckChange(object sender, EventArgs e)
        {
            string theFilterString = "BU";

            RadioButton radioButton = (sender) as RadioButton;

            if (radioButton.Checked)
            {
                theFilterString = radioButton.Tag.ToString();
                lblSeq.Text = radioButton.Tag.ToString();

                DataView dview = new DataView(AllStatus);
                dview.RowFilter = "StatusUsed = '" + theFilterString + "'";

                DataTable dtv = dview.ToTable();

                kcbAllStatus.DataSource = dtv;
                kcbAllStatus.DisplayMember = "StatusLabel";
                
                kcbAllDescrip.DataSource = dtv;
                kcbAllDescrip.DisplayMember = "Description";

                kcbAllStatus.SelectedIndex = 0;

                //DataRow[] foundRows = AllStatus.Select("StatusUsed = '" + theFilterString + "'");

                //if (foundRows.Length > 0)
                //{
                //    kcbAllStatus.Items.Clear();

                //    foreach (DataRow dr in foundRows)
                //    {
                //        kcbAllStatus.Items.Add(dr[1].ToString());
                //    }

                //    kcbAllStatus.SelectedIndex = 0;
                //}
            }
        }

        
        private void msRename_Click(object sender, EventArgs e)
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

                    // Create and show the form at that position
                    Rename form = new Rename();
                    form.StartPosition = FormStartPosition.Manual;
                    screenPoint.X = screenPoint.X + 50 - form.Width;
                    screenPoint.Y = screenPoint.Y - 40;
                    form.Location = screenPoint;
                    form.ShowDialog();
                }
            }            
        }

        private void msMoveTo_Click(object sender, EventArgs e)
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

                    // Create and show the form at that position
                    MoveTo form = new MoveTo();
                    screenPoint.X = screenPoint.X + 50 - form.Width;
                    screenPoint.Y = screenPoint.Y - 10;
                    form.StartPosition = FormStartPosition.Manual;
                    form.Location = screenPoint;
                    form.ShowDialog();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Apply the layout to the form
            this.StartPosition = FormStartPosition.Manual;
            this.WindowState = FormWindowState.Normal;

            // Try to find an existing SearchTool form
            SearchTool existingForm = Application.OpenForms
                                    .OfType<SearchTool>()
                                    .FirstOrDefault();

            if (existingForm != null)
            {
                // If already open, bring it to front and optionally reposition it
                existingForm.BringToFront();
                existingForm.Activate();

                // Optionally reposition it
                Screen currentScreen = Screen.FromControl(this);
                Rectangle workingArea = currentScreen.WorkingArea;

                existingForm.Location = new Point(
                    workingArea.Right - existingForm.Width,
                    workingArea.Top + 40
                );
            }
            else
            {
                // Get the screen where the current form is displayed
                Screen currentScreen = Screen.FromControl(this);
                Rectangle workingArea = currentScreen.WorkingArea;

                // Create and show new SearchTool form
                SearchTool form = new SearchTool
                {
                    theDb = theDb,
                    CurrentStatus = CurrentStatus,
                    StartPosition = FormStartPosition.Manual,
                    Height = workingArea.Height - 80,
                    Width = 608 // Make sure to set this, otherwise Width might be 0 at this point
                };

                form.Location = new Point(
                                    workingArea.Right - form.Width,
                                    workingArea.Top + 40
                );

                form.AllStatus = (DataTable)kcbAllStatus.DataSource;
                form.StatusGroup = lblSeq.Text;
                form.Show();


                // Set the desired dimensions
                int desiredTop = workingArea.Top + 40;
                int desiredHeight = workingArea.Height - 80;
                int desiredWidth = workingArea.Width - form.Width; // Custom padding

                // Apply the layout to the form
                this.StartPosition = FormStartPosition.Manual;
                this.Top = desiredTop;
                this.Height = desiredHeight;
                this.Width = desiredWidth;


                //this.Location = new Point(workingArea.Left - desiredWidth - form.Width,
                //    workingArea.Top + 40
                //);
            }            
        }

        private void ViewDailyReportBtn_Click(object sender, EventArgs e)
        {
            Daily_Production_Status form = new Daily_Production_Status();
            form.theDb = theDb;
            form.AllStatus = DBClasses.DBReader.AllStatusData(theDb,"Q"); //AllStatusData
            form.StatusGroup = lblSeq.Text;
            form.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NewSplash.StartPosition = FormStartPosition.CenterScreen;
            NewSplash.Opacity = 100;
            NewSplash.ShowDialog();
            NewSplash.theDb = theDb;

            if (NewSplash.IsLogin)
            {
                if (rbGen.Name == NewSplash.rbTheSelected.Name)
                    rbGen.Checked = true;
                else if (rbGI.Name == NewSplash.rbTheSelected.Name)
                    rbGI.Checked = true;
                else if (rbHR.Name == NewSplash.rbTheSelected.Name)
                    rbHR.Checked = true;


                kcbAllStatus.SelectedIndex = NewSplash.cbTheSelected.SelectedIndex;

                AfterPageLoading();
            }
        }
    }
}
