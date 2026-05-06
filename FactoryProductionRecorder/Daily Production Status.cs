using AppCode;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using Excel = Microsoft.Office.Interop.Excel;

namespace FactoryProductionRecorder
{
    public partial class Daily_Production_Status : MetroFramework.Forms.MetroForm
    {
        public DataTable AllStatus = new DataTable();
        public DataTable TheHandedOverData = new DataTable();

        public string theDb = "";
        public string CurrentStatus = "";
        public string CurrentShift = "";
        public string StatusGroup = "";

        public bool IsLoading = false;

        string TheBay = "";
        string TheStatus = "";

        public Daily_Production_Status()
        {
            InitializeComponent();
        }

        private void Daily_Production_Status_Load(object sender, EventArgs e)
        {
            dtpikProd.Value = DateTime.Now;
            dtpikProd.MaxDate = DateTime.Now;
            rbDaily.Checked = true;

            TheHandedOverData = DBClasses.DBReader.LoadGivenStationDataFull(theDb, Convert.ToDateTime(dtpikProd.Value).ToString("yyyy-MM-dd"), rbDaily.Checked, rbMonthly.Checked, rbYearly.Checked);    //'2025-10-07'
        }


        private void DgvStationData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void BtnSrch_Click(object sender, EventArgs e)
        {
            LoadBayDetails();
        }

        private void dtpikProd_ValueChanged(object sender, EventArgs e)
        {
            TheHandedOverData = DBClasses.DBReader.LoadGivenStationDataFull(theDb, Convert.ToDateTime(dtpikProd.Value).ToString("yyyy-MM-dd"), rbDaily.Checked, rbMonthly.Checked, rbYearly.Checked);    //'2025-10-07'
            LoadBayDetails();
        }


        private void lbStations_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (IsLoading) return;

            CurrentStatus = "";

            foreach (int index in lbStations.CheckedIndices)
            {
                IsLoading = true;

                if (index != e.Index)
                    lbStations.SetItemCheckState(index, CheckState.Unchecked);

                IsLoading = false;
            }

            if (e.NewValue == CheckState.Checked)
                CurrentStatus = lbStations.Items[e.Index].ToString();

            LoadBayDetails();
        }

        private void LoadBayDetails()
        {
            string theShiftFilter = "";

            if (CurrentShift != "")
            { theShiftFilter = " AND SHIFT = '" + CurrentShift + "' "; }

            string theBayFilter = "";
            TheStatus = "";

            if (CurrentStatus == "SAW1")
            { TheStatus = "SWQ"; TheBay = "1"; theBayFilter = " AND (ASSMREMARKS IS NULL OR ASSMREMARKS NOT LIKE '%DSW%') AND BAYID = '1'"; }

            else if (CurrentStatus == "SAW2")
            { TheStatus = "SWQ"; TheBay = "4"; theBayFilter = " AND (ASSMREMARKS IS NULL OR ASSMREMARKS NOT LIKE '%DSW%') AND BAYID = '4'"; }

            else if (CurrentStatus == "DSW1")
            { TheStatus = "SWQ"; TheBay = "1"; theBayFilter = " AND ASSMREMARKS LIKE '%DSW%' AND BAYID = '1'"; }

            else if (CurrentStatus == "DSW2")
            { TheStatus = "SWQ"; TheBay = "4"; theBayFilter = " AND ASSMREMARKS LIKE '%DSW%' AND BAYID = '4'"; }

            else if (CurrentStatus == "FAB")
            { TheStatus = "FBQ"; TheBay = ""; theBayFilter = ""; }

            else if (CurrentStatus == "WELD")
            { TheStatus = "WLQ"; TheBay = ""; theBayFilter = ""; }

            else if (CurrentStatus == "PAINT")
            { TheStatus = "PNQ"; TheBay = ""; theBayFilter = ""; }

            else if (CurrentStatus == "CF")
            { TheStatus = "CFQ"; TheBay = ""; theBayFilter = ""; }


            if (TheStatus != "")
            {
                DataView dv = new DataView(TheHandedOverData);
                dv.RowFilter = "STATUS = '" + TheStatus + "'" + theBayFilter + theShiftFilter;
                //dv.Sort = "JOBIDKEY DESC, PHASEIDKEY ASC, TASKREVISION DESC";
                DgvStationData.DataSource = dv.ToTable();
                Cart.FormatDailyData(DgvStationData);

                tbtotWeight.Text = Cart.GetTotWeight(dv.ToTable());
                tbtotQty.Text = Cart.GetTotQty(dv.ToTable());
            }
            else
            {
                DgvStationData.DataSource = null;

                tbtotWeight.Text = "0";
                tbtotQty.Text = "0";
            }
        }

        private void lbShifts_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (IsLoading) return;

            foreach (int index in lbShifts.CheckedIndices)
            {
                IsLoading = true;

                if (index != e.Index)
                    lbShifts.SetItemCheckState(index, CheckState.Unchecked);

                IsLoading = false;
            }

            if (e.NewValue == CheckState.Checked)
                CurrentShift = lbShifts.Items[e.Index].ToString();
            else
                CurrentShift = "";

            LoadBayDetails();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            labelPath.Visible = false;
            string defPath = @"C:\InHouseApps\FPR";

            try
            {
                labelPath.Text = "Open File Location";
                labelPath.Tag = defPath;

                if (!Directory.Exists(defPath)) Directory.CreateDirectory(defPath);

                string datePrefix = DateTime.Now.ToString("yyyyMMdd");
                string labell = "_" + CurrentStatus + "_" + CurrentShift;
                string folderName = $"{datePrefix}{labell}.xlsx";
                string finalPath = Path.Combine(defPath, folderName);

                ExportDataGridViewToExcel(DgvStationData, finalPath);

                labelPath.Tag = finalPath;
                labelPath.Visible = true;
                labelPath.Text = "View File";
            }
            catch
            {
                labelPath.Text = "Open File Location";
                labelPath.Tag = defPath;
                labelPath.Visible = false;
            }
            
        }

        public static void ExportDataGridViewToExcel(DataGridView dgv, string savePath)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            try
            {
                // Start Excel application
                var excelApp = new Excel.Application();
                excelApp.Visible = false;
                excelApp.DisplayAlerts = false;

                // Create new workbook
                var workBook = excelApp.Workbooks.Add();
                var workSheet = (Excel.Worksheet)workBook.Sheets[1];
                workSheet.Name = "ExportedData";

                // Add headers
                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    workSheet.Cells[1, col + 1] = dgv.Columns[col].HeaderText;
                    workSheet.Cells[1, col + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);

                    // Optional: Bold text
                    workSheet.Cells[1, col + 1].Font.Bold = true;
                }

                // Add rows
                for (int row = 0; row < dgv.Rows.Count; row++)
                {
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        workSheet.Cells[row + 2, col + 1] = dgv.Rows[row].Cells[col].Value?.ToString();
                    }
                }

                // Save the workbook
                workBook.SaveAs(savePath);
                workBook.Close(false);
                excelApp.Quit();

                // Clean up
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                MessageBox.Show("Export successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel: " + ex.Message);
            }
        }

        private void labelPath_Click(object sender, EventArgs e)
        {
            if (labelPath.Tag.ToString() != "")
            {
                System.Diagnostics.Process.Start("explorer.exe", labelPath.Tag.ToString());
            }
        }

        private void ProdutionFilterSwitchChecked(object sender, EventArgs e)
        {
            string theFilterDateString = Convert.ToDateTime(dtpikProd.Value).ToString("yyyy-MM-dd");

            if (rbDaily.Checked)
            {
                dtpikProd.Format = DateTimePickerFormat.Custom;
                dtpikProd.CustomFormat = "dd-MMM-yyyyy"; // Display Month and Year only
                dtpikProd.ShowUpDown = false;           // Use up-down buttons instead of calendar drop-down
                theFilterDateString = Convert.ToDateTime(dtpikProd.Value).ToString("yyyy-MM-dd");
                //dtpikProd.Width = 150;
            }
            else if (rbMonthly.Checked)
            {
                dtpikProd.Format = DateTimePickerFormat.Custom;
                dtpikProd.CustomFormat = "MMM-yyyyy";  // Display Month and Year only
                dtpikProd.ShowUpDown = true;           // Use up-down buttons instead of calendar drop-down
                theFilterDateString = Convert.ToDateTime(dtpikProd.Value).ToString("yyyy-MM");
                //dtpikProd.Width = 150;
            }
            else if (rbYearly.Checked)
            {
                dtpikProd.Format = DateTimePickerFormat.Custom;
                dtpikProd.CustomFormat = "yyyyy";  // Display Month and Year only
                dtpikProd.ShowUpDown = true;           // Use up-down buttons instead of calendar drop-down
                theFilterDateString = Convert.ToDateTime(dtpikProd.Value).ToString("yyyy");
                //dtpikProd.Width = 150;
            }

            TheHandedOverData = DBClasses.DBReader.LoadGivenStationDataFull(theDb, theFilterDateString, rbDaily.Checked, rbMonthly.Checked, rbYearly.Checked);    //'2025-10-07'
            LoadBayDetails();
        }
    }
}
