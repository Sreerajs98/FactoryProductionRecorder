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
    public partial class BayTo : MetroFramework.Forms.MetroForm
    {
        public bool AllowToProceed = false;
        public string TheBay = ""; 

        public BayTo()
        {
            InitializeComponent();
        }

        private void BayTo_Load(object sender, EventArgs e)
        {
            kcbTheBay.Text = TheBay;

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DialogResult dr = KryptonMessageBox.Show("Do you want to change the BAY for the selected items to : " + kcbTheBay.Text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dr == DialogResult.Yes)
            {
                AllowToProceed = true;
            }
            this.Close();
        }
    }
}
