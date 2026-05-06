using AppCode;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace FactoryProductionRecorder
{
    public partial class SplashScreen : MetroFramework.Forms.MetroForm
    {
        public string theDb = "";
        public RadioButton rbTheSelected  = new RadioButton();
        public KryptonComboBox cbTheSelected = new KryptonComboBox();

        public DataTable AllStatus = new DataTable();

        public bool IsLogin = false;


        
        public SplashScreen()
        {
            InitializeComponent();        
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            try
            {
                AllStatus = DBClasses.DBReader.AllStatusData(theDb);
                rbGen.Checked = true;

            }
            catch (Exception epp)
            {
                MessageBox.Show(epp.Message);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LoginCheck();
        }

        private void LoginCheck()
        {
            if (rbGen.Checked) rbTheSelected = rbGen;
            else if (rbGI.Checked) rbTheSelected = rbGI;
            else if (rbHR.Checked) rbTheSelected = rbHR;

            cbTheSelected = kcbAllStatus;

            IsLogin = true;
            this.Close();
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

        private void tbUserPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginCheck();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            IsLogin = false;
            this.Close();
        }
    }
}