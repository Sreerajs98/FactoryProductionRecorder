using ComponentFactory.Krypton.Toolkit;
using DBClasses;
using MyExcelClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCode
{
    internal class Cart
    {
        public static string AnPhaseId = "AE-A0123-01-202";
        public static string AnAssmPos = "SRV001";
        public static int AnAssmQty = 10;
        public static double AnAssmWeight = 0.0001;

        public static string TheDBInstance = "DEV";
        public static string IsTheDeveloper = "RY1CWZuf8aG+0/lZldK5X67Kn1j7W2fdKUKeCVqpkT0=";

        public static string ThePhaseId = "";
        public static bool IsTableDataRcd = false;
        public static string TheSelectedYear = "";
        public static string TheSelectedMonth = "";
        public static string ThePreviousMonth = "";
        public static bool LoadTheBOMAgain = false;


        public static List<string> AllShopBONames = new List<string>();
        public static string ThePimEstWt = "0";
        public static DataTable EmployeeData = new DataTable();

        public static string XlFileDateAndTime_Temp = string.Empty;
        public static string XlFileDateAndTime = string.Empty;

        public static DataTable DocumentTypes = new DataTable();

        public static string CurrentLoginUser = "";
        public static int CurrentUserEmpId = 0;
        public static string CurrentUserFullName = "";
        public static string CurrentUserIni = "";
        public static bool IsManager = false;
        public static bool IsBeManager = false;
        public static bool IsEngDirector = false;
        public static string PMDEngIni = "";
        public static int DepartmentID = 0;

        public static string InHouseAppPath = "\\\\abssrvfs01\\InHouseApps\\PDApplications";

        public static DataTable XlFiles = new DataTable();
        public static List<string> AllBOMName = new List<string>();
        public static string MySplkey = "ppd1_a5898a4e4133bbce2eg";

       

        public static string MakePersonSignature()
        {
            string result = "";

            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            string user1 = EmployeeData.Rows[0]["FirstName"].ToString().Trim() + " " + EmployeeData.Rows[0]["LastName"].ToString().Trim();     //Full Name
            string user2 = EmployeeData.Rows[0]["Desig"].ToString().Trim();       //Designation
            string user3 = EmployeeData.Rows[0]["DepName"].ToString().Trim();     //Department.

            //result = user1 + "\n" + user2 + "\n" + user3;
            result = "Regards, <br>" + user1 + " <br>" + user2 + "&nbsp;[" + user3 + "]";

            return result;
        }

        public static void GetEmailIDsToSendEmail(string EmailType, ref string toIDs, ref string ccIds)
        {
            DataTable CollectedEmailIDs = DBClasses.DBReader.EmailIdForRelease("1064", EmailType);

            string TempTO = "";
            string TempCC = "";

            if (CollectedEmailIDs.Rows.Count > 0)
            {
                foreach (DataRow drv in CollectedEmailIDs.Rows)
                {
                    object[] theVal = drv.ItemArray;
                    string EmpEmailID = drv["EmpEmailID"].ToString().Trim();
                    bool toEmailID = (bool)drv["EmailTO"];
                    bool ccEmailID = (bool)drv["EmailCC"];

                    if (toEmailID)
                    {
                        if (TempTO == "") TempTO = EmpEmailID;
                        else TempTO = TempTO + ";" + EmpEmailID;                            
                    }
                    else if (ccEmailID)
                    {
                        if (TempCC == "") TempCC = EmpEmailID;                            
                        else TempCC = TempCC + ";" + EmpEmailID;                            
                    }
                }

                toIDs = TempTO;
                ccIds = TempCC;
            }
        }

        public static object ValidateNullvalue(object givenVal, bool isString)
        {

            if (isString)
            {
                if (givenVal.ToString() == "")
                    return "NULL";
                else
                    return " '" + givenVal + "'";
            }
            else
            {
                try
                {

                    if (givenVal.ToString() == "")
                        return 0;
                    else
                    {
                        double theVal = double.Parse(givenVal.ToString());
                        return theVal;
                    }
                }
                catch
                {
                    return 0;
                }
            }
        }

        //public static string GetTheTotalWeight(DataTable TheTableVal)
        //{
        //    // LINQ query to calculate the total weight
        //    decimal totalWeight = TheTableVal.AsEnumerable()
        //                                .Sum(row => row.Field<decimal>("WEIGHT"));

        //    return totalWeight.ToString("N2");
        //}

        //public static string GetTheTotalBalQty(DataTable TheTableVal)
        //{
        //    // LINQ query to calculate the total weight
        //    decimal totalWeight = TheTableVal.AsEnumerable()
        //                                .Sum(row => row.Field<int>("BalQTY"));

        //    return totalWeight.ToString();
        //}

        //public static string GetTheTotalSentQty(DataTable TheTableVal)
        //{
        //    // LINQ query to calculate the total weight
        //    decimal totalWeight = TheTableVal.AsEnumerable()
        //                                .Sum(row => row.Field<int>("Sent"));

        //    return totalWeight.ToString();
        //}
        //public static string GetTheTotalProdQty(DataTable TheTableVal)
        //{
        //    // LINQ query to calculate the total weight
        //    decimal totalWeight = TheTableVal.AsEnumerable()
        //                                .Sum(row => row.Field<int>("ProdQTY"));

        //    return totalWeight.ToString();
        //}

        //public static string GetTheTotalQty(DataTable TheTableVal)
        //{
        //    // LINQ query to calculate the total weight
        //    decimal totalWeight = TheTableVal.AsEnumerable()
        //                                .Sum(row => row.Field<int>("QTY"));

        //    return totalWeight.ToString();
        //}

        public static string GetTotWeight(DataTable TheTableVal)
        {
            // LINQ query to calculate the total weight
            decimal totalWeight = TheTableVal.AsEnumerable()
                    .Sum(row => row.Field<int>("ASSMQTY") * row.Field<decimal>("UNITWEIGHT_ACT"));

            return totalWeight.ToString("N2");
        }

        public static string GetTotQty(DataTable TheTableVal)
        {
            // LINQ query to calculate the total weight
            decimal totalQty = TheTableVal.AsEnumerable()
                                  .Sum(row => row.Field<int>("ASSMQTY"));

            return totalQty.ToString("N0");
        }


        //public static string GetTheBalanceWeight(DataTable TheTableVal)
        //{
        //    // LINQ query to calculate the total weight
        //    decimal totalWeight = TheTableVal.AsEnumerable()
        //                                .Sum(row => row.Field<decimal>("BalWT"));

        //    return totalWeight.ToString("N2");
        //}

        public static bool IsInterger(string theText)
        {
            bool isSuccess = false;

            try
            {
                if (theText.Length >= 1)
                {
                    int i = int.Parse(theText);
                    isSuccess = true;
                }
            }
            catch
            {
                isSuccess = false;
            }

            return isSuccess;
        }

        public static void FormatProcessingData(KryptonDataGridView DgvAssmData)
        {
            DgvAssmData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            foreach (DataGridViewColumn dc in DgvAssmData.Columns)
            {
                if (dc.Name == "PHASEID")
                {
                    dc.Width = 125;
                    dc.HeaderText = "PhaseID";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dc.DefaultCellStyle.BackColor = Color.WhiteSmoke;

                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "ASSMPOS")
                {
                    dc.Width = 90;
                    dc.HeaderText = "AssmPos";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.BackColor = Color.Ivory;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "ASSMNAME")
                {
                    dc.Width = 120;
                    dc.HeaderText = "Name";
                    dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dc.DefaultCellStyle.BackColor = Color.Ivory;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "ASSMQTY")
                {
                    dc.Width = 70;
                    dc.HeaderText = "Assm_Qty";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.BackColor = Color.Ivory;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "PREVQTY")
                {
                    dc.Width = 70;
                    dc.HeaderText = "Prev_Qty";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.BackColor = Color.Ivory;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "BOMQTY")
                {
                    dc.Width = 80;
                    dc.HeaderText = "BOM_Qty";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    dc.DefaultCellStyle.ForeColor = Color.Red;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "UNITWEIGHT")
                {
                    dc.Width = 80;
                    dc.HeaderText = "U_Wt";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "ONDATE")
                {
                    dc.Width = 120;
                    dc.HeaderText = "P_Date";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    Font f = new Font("Arial", 11, FontStyle.Bold);//Segoe UI, 8.25pt
                    dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.Format = "dd-MMM-yyyy";
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "BAYID")
                {
                    dc.Width = 50;
                    dc.HeaderText = "BAY";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else
                {
                    dc.ReadOnly = true;
                    dc.Visible = false;
                }
            }
        }

        public static void FormatNextStationData(KryptonDataGridView DgvNextStation)
        {
            DgvNextStation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            foreach (DataGridViewColumn dc in DgvNextStation.Columns)
            {
                if (dc.Name == "PHASEID")
                {
                    dc.Width = 150;
                    dc.HeaderText = "PHASEID";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dc.DefaultCellStyle.BackColor = Color.WhiteSmoke;

                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "ASSMPOS")
                {
                    dc.Width = 100;
                    dc.HeaderText = "ASSMPOS";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.BackColor = Color.Ivory;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "ASSMNAME")
                {
                    dc.Width = 100;
                    dc.HeaderText = "Name";
                    dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dc.DefaultCellStyle.BackColor = Color.Ivory;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "ASSMQTY")
                {
                    dc.Width = 70;
                    dc.HeaderText = "ASSMQTY";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    Font f = new Font("Arial", 10, FontStyle.Bold);//Segoe UI, 8.25pt
                    dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.BackColor = Color.Ivory;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "BOMQTY")
                {
                    dc.Width = 70;
                    dc.HeaderText = "BOMQTY";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    dc.DefaultCellStyle.ForeColor = Color.Red;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "RECORDEDBY")
                {
                    dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dc.HeaderText = "RECORDEDBY";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "RECORDEDON")
                {
                    dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dc.HeaderText = "RECORDEDON";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    //Font f = new Font("Arial", 11, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.Format = "dd-MMM-yyyy";
                    dc.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "STATUS")
                {
                    dc.Width = 60;
                    dc.HeaderText = "STATUS";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "BAYID")
                {
                    dc.Width = 50;
                    dc.HeaderText = "BAY";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dc.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else
                {
                    dc.Visible = false;
                    dc.ReadOnly = true;
                    dc.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        public static void FormatStationData(KryptonDataGridView DgvNextStation)
        {
            DgvNextStation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DgvNextStation.ColumnHeadersHeight = 40;

            foreach (DataGridViewColumn dc in DgvNextStation.Columns)
            {
                if (dc.Name == "ASSMPOS")
                {
                    //dc.Width = 85;
                    dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dc.HeaderText = "ASSMPOS";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.BackColor = Color.SeaShell;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "Station")
                {
                    //dc.Width = 180;
                    dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dc.HeaderText = "Station";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    Font f = new Font("Arial", 10, FontStyle.Bold);//Segoe UI, 8.25pt
                    dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "THELOCK")
                {
                    dc.Width = 110;
                    dc.HeaderText = "Status";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.BackColor = Color.SeaShell;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "Remark")
                {
                    dc.Width = 110;
                    dc.HeaderText = "";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.BackColor = Color.SeaShell;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else
                {
                    dc.Visible = false;
                    dc.ReadOnly = true;
                    dc.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        public static void FormatStationLog(KryptonDataGridView DgvtStation)
        {
            DgvtStation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DgvtStation.ColumnHeadersHeight = 40;

            foreach (DataGridViewColumn dc in DgvtStation.Columns)
            {
                if (dc.Name == "PHASEID")
                {
                    dc.Visible = false;
                    //dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    //dc.HeaderText = "PHASEID";
                    //dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    //dc.Visible = true;
                    //dc.ReadOnly = true;
                }
                else if (dc.Name == "ASSMPOS")
                {
                    //dc.Width = 85;
                    dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dc.HeaderText = "ASSMPOS";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.BackColor = Color.MistyRose;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "ASSMNAME")
                {
                    //dc.Width = 85;
                    dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dc.HeaderText = "ASSMNAME";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.BackColor = Color.MistyRose;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name.EndsWith("PROCESSEDQTY"))
                {
                    dc.Width = 75;
                    dc.HeaderText = "PROCESSED\nQTY";
                    Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.ForeColor = Color.DarkOliveGreen;
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dc.DefaultCellStyle.BackColor = Color.MistyRose;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name.EndsWith("ENGBOMQTY"))
                {
                    dc.Width = 60;
                    dc.HeaderText = "ENG BOM\nQTY";
                    Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.ForeColor = Color.DarkOliveGreen;
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dc.DefaultCellStyle.BackColor = Color.MistyRose;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }

                else if (dc.Name.EndsWith("BALANCEQTY"))
                {
                    dc.Width = 60;
                    dc.HeaderText = "BALANCE\nQTY";
                    Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.ForeColor = Color.DarkOliveGreen;
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dc.DefaultCellStyle.BackColor = Color.MistyRose;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else
                {
                    dc.Width = 80;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                    dc.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        public static void FormatDailyData(KryptonDataGridView DgvtStation)
        {
            DgvtStation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //DgvtStation.ColumnHeadersHeight = 40;

            foreach (DataGridViewColumn dc in DgvtStation.Columns)
            {
                if (dc.Name == "PHASEID")
                {
                    dc.Width = 150;
                    //dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dc.HeaderText = "PHASEID";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    //dc.DefaultCellStyle.BackColor = Color.MistyRose;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "ASSMPOS")
                {
                    dc.Width = 85;
                    //dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dc.HeaderText = "ASSMPOS";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.BackColor = Color.LightYellow;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "ASSMNAME")
                {
                    dc.Width = 85;
                    dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dc.HeaderText = "ASSMNAME";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    //dc.DefaultCellStyle.BackColor = Color.MistyRose;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name == "BOMLENGTH")
                {
                    dc.Width = 75;
                    //dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dc.HeaderText = "Length";
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    //dc.DefaultCellStyle.BackColor = Color.MistyRose;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name.EndsWith("ASSMQTY"))
                {
                    dc.Width = 75;
                    dc.HeaderText = "Produced QTY";
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    //dc.DefaultCellStyle.ForeColor = Color.DarkOliveGreen;
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dc.DefaultCellStyle.BackColor = Color.Ivory;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name.EndsWith("UNITWEIGHT_ACT"))
                {
                    dc.Width = 90;
                    dc.HeaderText = "Unit WT";
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    dc.DefaultCellStyle.Format = "N2";
                    //dc.DefaultCellStyle.ForeColor = Color.DarkOliveGreen;
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dc.DefaultCellStyle.BackColor = Color.LightYellow;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name.EndsWith("SHIFT"))
                {
                    dc.Width = 60;
                    dc.HeaderText = "SHIFT";
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    //dc.DefaultCellStyle.ForeColor = Color.DarkOliveGreen;
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //dc.DefaultCellStyle.BackColor = Color.MistyRose;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name.EndsWith("BAYID"))
                {
                    dc.Width = 60;
                    dc.HeaderText = "BAY";
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    //dc.DefaultCellStyle.ForeColor = Color.DarkOliveGreen;
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //dc.DefaultCellStyle.BackColor = Color.MistyRose;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else if (dc.Name.EndsWith("TRANSFEREDON"))
                {
                    dc.Width = 100;
                    dc.HeaderText = "Date";
                    //Font f = new Font("Arial", 12, FontStyle.Bold);//Segoe UI, 8.25pt
                    //dc.DefaultCellStyle.Font = f; //Arial, 9.75pt
                    //dc.DefaultCellStyle.ForeColor = Color.DarkOliveGreen;
                    dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //dc.DefaultCellStyle.BackColor = Color.MistyRose;
                    dc.Visible = true;
                    dc.ReadOnly = true;
                }
                else
                {
                    //dc.Width = 80;
                    dc.Visible = false;
                    dc.ReadOnly = false;
                    dc.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }
    }
}
