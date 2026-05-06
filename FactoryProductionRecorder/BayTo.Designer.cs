namespace FactoryProductionRecorder
{
    partial class BayTo
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
            this.btnSend = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kcbTheBay = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.kcbTheBay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(246, 39);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(113, 52);
            this.btnSend.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSend.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSend.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnSend.StateCommon.Border.Color1 = System.Drawing.Color.YellowGreen;
            this.btnSend.StateCommon.Border.Color2 = System.Drawing.Color.YellowGreen;
            this.btnSend.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btnSend.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnSend.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSend.StateCommon.Border.Rounding = 10;
            this.btnSend.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.TabIndex = 4;
            this.btnSend.Tag = "Button Move";
            this.btnSend.Values.Image = global::FactoryProductionRecorder.Properties.Resources.transfer1;
            this.btnSend.Values.Text = "Move";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // kcbTheBay
            // 
            this.kcbTheBay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.kcbTheBay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.kcbTheBay.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kcbTheBay.DropDownHeight = 300;
            this.kcbTheBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcbTheBay.DropDownWidth = 124;
            this.kcbTheBay.Items.AddRange(new object[] {
            "1",
            "4"});
            this.kcbTheBay.Location = new System.Drawing.Point(139, 19);
            this.kcbTheBay.MaxDropDownItems = 16;
            this.kcbTheBay.Name = "kcbTheBay";
            this.kcbTheBay.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kcbTheBay.Size = new System.Drawing.Size(82, 24);
            this.kcbTheBay.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kcbTheBay.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 12F);
            this.kcbTheBay.TabIndex = 3;
            this.kcbTheBay.Tag = "Stations";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 1279;
            this.label4.Text = "To which Bay.? :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(39, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 1280;
            this.label3.Text = "Edit Bay Line";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::FactoryProductionRecorder.Properties.Resources.transfer;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(6, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(33, 32);
            this.panel5.TabIndex = 1303;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kcbTheBay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 56);
            this.groupBox1.TabIndex = 1279;
            this.groupBox1.TabStop = false;
            // 
            // BayTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 98);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BayTo";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.BayTo_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcbTheBay;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}