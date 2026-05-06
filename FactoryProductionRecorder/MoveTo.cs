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
    public partial class MoveTo : MetroFramework.Forms.MetroForm
    {
        public DataTable AllStatus = new DataTable();
        public bool IsReturn = true;
        public bool AllowToProceed = false;
        public string TheNextStatus = ""; 
        public string TheNextStatusSeqNum = "";
        public string AssmPos = "";
        public string AssmPosQty = "";
        public string AssmPhaseId = "";

        public bool IsLoading = true;

        public MoveTo()
        {
            InitializeComponent();
        }

        private void MoveTo_Load(object sender, EventArgs e)
        {
            tbPhaseId.Text = AssmPhaseId;

            tbAssmPos.Text = AssmPos;
            lblQty.Text = AssmPosQty.ToString();

            IsLoading = true;
            kcbAllStatus.DataSource = AllStatus;
            kcbAllStatus.DisplayMember = "Description";
            kcbAllStatus.SelectedIndex = -1;

            seqNum.DataSource = AllStatus;
            seqNum.DisplayMember = "Seq";

            StationPref.DataSource = AllStatus;
            StationPref.DisplayMember = "StatusLabel";

            IsLoading = false;

            if (IsReturn)
            {
                panel5.BackgroundImage = FactoryProductionRecorder.Properties.Resources.DL;
                btnSend.Values.Image = FactoryProductionRecorder.Properties.Resources.DL;
                label3.Text = "Return to a previous Station";
                kcbAllStatus.SelectedIndex = kcbAllStatus.Items.Count - 1;
            }
            else
            {
                panel5.BackgroundImage = FactoryProductionRecorder.Properties.Resources.DR;
                btnSend.Values.Image = FactoryProductionRecorder.Properties.Resources.DR;
                label3.Text = "Move to a new Station";
                kcbAllStatus.SelectedIndex = 0;
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string theMoveNote = "return";
            if (!IsReturn) theMoveNote = "move";

            DialogResult dr = KryptonMessageBox.Show("Do you want to "+ theMoveNote + " the [" + AssmPos + "] to [" + kcbAllStatus.Text + "] station.?", theMoveNote.ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) { return; }

            dr = KryptonMessageBox.Show("You may not able to UNDO this process, are you sure to proceed.?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel) { return; }

            AllowToProceed = true;
            TheNextStatus = StationPref.Text;
            TheNextStatusSeqNum = seqNum.Text;
            this.Close();
        }


        private void tbAssmPos_MouseEnter(object sender, EventArgs e)
        {
            KryptonTextBox tb = sender as KryptonTextBox;
            if (tb != null)
                lblPrev.Text = tb.Tag.ToString();


            KryptonComboBox cb = sender as KryptonComboBox;
            if (cb != null)
                lblPrev.Text = cb.Tag.ToString();


            KryptonButton btn = sender as KryptonButton;
            if (btn != null)
                lblPrev.Text = btn.Tag.ToString();

        }

        private void MoveTo_MouseEnter(object sender, EventArgs e)
        {
            lblPrev.Text = "";
        }

        private void kcbAllStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoading) return;

            if (IsReturn)
            {
                if (kcbAllStatus.SelectedIndex != kcbAllStatus.Items.Count - 1)
                    btnSend.Enabled = true;
                else
                    btnSend.Enabled = false;
            }
            else
            {
                if (kcbAllStatus.SelectedIndex != 0)
                    btnSend.Enabled = true;
                else
                    btnSend.Enabled = false;
            }
        }
    }
}
