using AppCode;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryProductionRecorder
{
    public partial class Rename : MetroFramework.Forms.MetroForm
    {
        public bool AllowToProceed = false;
        public string AssmPos = "";
        public string AssmPosNew = "";

        public string AssmPosQty = "";
        public string AssmPhaseId = "";

        public string theDb = "";

        public DataTable AllProcessingVsBOMData = new DataTable();

        public Rename()
        {
            InitializeComponent();
        }

        private void Confirm_Load(object sender, EventArgs e)
        {
            tbPhaseId.Text = AssmPhaseId;
            tbAssmPos.Text = AssmPos;
            lblQty.Text = AssmPosQty.ToString();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbNewMark.Text == "")
            {
                lblPrev.Text = "Error# Invalid mark";
                return;
            }

            DialogResult dr = KryptonMessageBox.Show("Do you want to rename the assembly mark [" + AssmPos + "] to [" + tbNewMark.Text + "].?", "Rename", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) { return; }

            dr = KryptonMessageBox.Show("You may not able to UNDO this process, are you sure to proceed.?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel) { return; }


            AllProcessingVsBOMData = DBClasses.DBReader.Load_TheAssembly_Log(theDb, AssmPhaseId, tbNewMark.Text);

            if (AllProcessingVsBOMData.Rows.Count > 0)
            {
                AllowToProceed = true;
                AssmPosNew = tbNewMark.Text;
                this.Close();
            }
            else
            {
                KryptonMessageBox.Show("The new proposed assembly mark [" + tbNewMark.Text + "] is not exist in BOM, please check.?", "Check", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void tbPhaseId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevent space from being entered
            if (e.KeyChar == ' ')
            {
                e.Handled = true;  // Block space character
            }
        }

        private void tbAssmPos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevent space from being entered
            if (e.KeyChar == ' ')
            {
                e.Handled = true;  // Block space character
            }
        }

        private void tbAssmQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '-')
            {
                e.Handled = true;  // Prevent the key from being entered
            }
        }       
    }
}
