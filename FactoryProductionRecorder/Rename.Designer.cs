namespace FactoryProductionRecorder
{
    partial class Rename
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQty = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbNewMark = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAssmPos = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPhaseId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPrev = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblQty);
            this.groupBox1.Controls.Add(this.tbNewMark);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbAssmPos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPhaseId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 120);
            this.groupBox1.TabIndex = 1275;
            this.groupBox1.TabStop = false;
            // 
            // lblQty
            // 
            this.lblQty.Enabled = false;
            this.lblQty.Location = new System.Drawing.Point(293, 50);
            this.lblQty.MaxLength = 150;
            this.lblQty.Name = "lblQty";
            this.lblQty.ReadOnly = true;
            this.lblQty.Size = new System.Drawing.Size(31, 28);
            this.lblQty.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.lblQty.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.lblQty.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.lblQty.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lblQty.StateCommon.Border.Rounding = 3;
            this.lblQty.StateCommon.Border.Width = 1;
            this.lblQty.StateCommon.Content.Color1 = System.Drawing.Color.Blue;
            this.lblQty.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.TabIndex = 1307;
            this.lblQty.Text = "0";
            this.metroToolTip1.SetToolTip(this.lblQty, "Current Assembly Mark");
            // 
            // tbNewMark
            // 
            this.tbNewMark.Location = new System.Drawing.Point(139, 83);
            this.tbNewMark.MaxLength = 150;
            this.tbNewMark.Name = "tbNewMark";
            this.tbNewMark.Size = new System.Drawing.Size(152, 28);
            this.tbNewMark.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tbNewMark.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.tbNewMark.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.tbNewMark.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbNewMark.StateCommon.Border.Rounding = 3;
            this.tbNewMark.StateCommon.Border.Width = 1;
            this.tbNewMark.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            this.tbNewMark.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewMark.TabIndex = 1278;
            this.metroToolTip1.SetToolTip(this.tbNewMark, "New Assembly Mark");
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 1279;
            this.label4.Text = "Assembly Pos (NEW):";
            // 
            // tbAssmPos
            // 
            this.tbAssmPos.Location = new System.Drawing.Point(139, 50);
            this.tbAssmPos.MaxLength = 150;
            this.tbAssmPos.Name = "tbAssmPos";
            this.tbAssmPos.ReadOnly = true;
            this.tbAssmPos.Size = new System.Drawing.Size(152, 28);
            this.tbAssmPos.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tbAssmPos.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.tbAssmPos.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.tbAssmPos.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbAssmPos.StateCommon.Border.Rounding = 3;
            this.tbAssmPos.StateCommon.Border.Width = 1;
            this.tbAssmPos.StateCommon.Content.Color1 = System.Drawing.Color.Blue;
            this.tbAssmPos.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAssmPos.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.tbAssmPos, "Current Assembly Mark");
            this.tbAssmPos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAssmPos_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 1277;
            this.label1.Text = "Assembly Pos (OLD):";
            // 
            // tbPhaseId
            // 
            this.tbPhaseId.Location = new System.Drawing.Point(139, 17);
            this.tbPhaseId.MaxLength = 150;
            this.tbPhaseId.Name = "tbPhaseId";
            this.tbPhaseId.ReadOnly = true;
            this.tbPhaseId.Size = new System.Drawing.Size(185, 28);
            this.tbPhaseId.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tbPhaseId.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.tbPhaseId.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.tbPhaseId.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPhaseId.StateCommon.Border.Rounding = 3;
            this.tbPhaseId.StateCommon.Border.Width = 1;
            this.tbPhaseId.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhaseId.TabIndex = 1;
            this.tbPhaseId.Text = "AE-A0123-01-101";
            this.tbPhaseId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhaseId_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 1273;
            this.label2.Text = "Phase ID:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(145, 171);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(192, 68);
            this.btnSend.StateCommon.Back.Color2 = System.Drawing.Color.LightSlateGray;
            this.btnSend.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSend.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnSend.StateCommon.Border.Color1 = System.Drawing.Color.PowderBlue;
            this.btnSend.StateCommon.Border.Color2 = System.Drawing.Color.PowderBlue;
            this.btnSend.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btnSend.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnSend.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSend.StateCommon.Border.Rounding = 10;
            this.btnSend.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.TabIndex = 5;
            this.btnSend.Values.Image = global::FactoryProductionRecorder.Properties.Resources.Proceed;
            this.btnSend.Values.Text = "Rename";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(24, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 1276;
            this.label3.Text = "Edit Assembly Mark";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::FactoryProductionRecorder.Properties.Resources.a_edit;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(0, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(22, 24);
            this.panel5.TabIndex = 1302;
            // 
            // lblPrev
            // 
            this.lblPrev.BackColor = System.Drawing.Color.MintCream;
            this.lblPrev.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrev.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPrev.Location = new System.Drawing.Point(3, 226);
            this.lblPrev.Name = "lblPrev";
            this.lblPrev.Size = new System.Drawing.Size(136, 15);
            this.lblPrev.TabIndex = 1307;
            this.lblPrev.Text = "..";
            // 
            // Rename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 250);
            this.Controls.Add(this.lblPrev);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(342, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(342, 250);
            this.Name = "Rename";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Confirm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSend;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbPhaseId;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbAssmPos;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbNewMark;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.Panel panel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox lblQty;
        private System.Windows.Forms.Label lblPrev;
    }
}