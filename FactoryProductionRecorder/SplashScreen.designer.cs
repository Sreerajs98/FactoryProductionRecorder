namespace FactoryProductionRecorder
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kcbAllStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.rbGI = new System.Windows.Forms.RadioButton();
            this.kcbAllDescrip = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.rbHR = new System.Windows.Forms.RadioButton();
            this.rbGen = new System.Windows.Forms.RadioButton();
            this.lblSeq = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbAllStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcbAllDescrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 249);
            this.panel1.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(230, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(35, 37);
            this.btnSave.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnSave.StateCommon.Border.Color1 = System.Drawing.Color.LightSteelBlue;
            this.btnSave.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.btnSave.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btnSave.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnSave.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 3;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.btnSave.TabIndex = 1142;
            this.btnSave.TabStop = false;
            this.btnSave.Values.Image = global::FactoryProductionRecorder.Properties.Resources.login;
            this.btnSave.Values.Text = "";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.kcbAllStatus);
            this.panel3.Controls.Add(this.rbGI);
            this.panel3.Controls.Add(this.kcbAllDescrip);
            this.panel3.Controls.Add(this.rbHR);
            this.panel3.Controls.Add(this.rbGen);
            this.panel3.Controls.Add(this.lblSeq);
            this.panel3.Location = new System.Drawing.Point(6, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 128);
            this.panel3.TabIndex = 1312;
            // 
            // kcbAllStatus
            // 
            this.kcbAllStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.kcbAllStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.kcbAllStatus.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kcbAllStatus.DropDownHeight = 300;
            this.kcbAllStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcbAllStatus.DropDownWidth = 124;
            this.kcbAllStatus.Location = new System.Drawing.Point(47, 89);
            this.kcbAllStatus.MaxDropDownItems = 16;
            this.kcbAllStatus.Name = "kcbAllStatus";
            this.kcbAllStatus.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kcbAllStatus.Size = new System.Drawing.Size(156, 27);
            this.kcbAllStatus.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbAllStatus.TabIndex = 1298;
            // 
            // rbGI
            // 
            this.rbGI.AutoSize = true;
            this.rbGI.BackColor = System.Drawing.Color.Transparent;
            this.rbGI.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGI.ForeColor = System.Drawing.Color.Black;
            this.rbGI.Location = new System.Drawing.Point(47, 58);
            this.rbGI.Name = "rbGI";
            this.rbGI.Size = new System.Drawing.Size(176, 27);
            this.rbGI.TabIndex = 1307;
            this.rbGI.TabStop = true;
            this.rbGI.Tag = "CF";
            this.rbGI.Text = "Secondary Steel (CF)";
            this.rbGI.UseVisualStyleBackColor = false;
            this.rbGI.CheckedChanged += new System.EventHandler(this.rbCheckChange);
            // 
            // kcbAllDescrip
            // 
            this.kcbAllDescrip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.kcbAllDescrip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.kcbAllDescrip.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kcbAllDescrip.DropDownHeight = 300;
            this.kcbAllDescrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcbAllDescrip.DropDownWidth = 124;
            this.kcbAllDescrip.Location = new System.Drawing.Point(133, 90);
            this.kcbAllDescrip.MaxDropDownItems = 16;
            this.kcbAllDescrip.Name = "kcbAllDescrip";
            this.kcbAllDescrip.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kcbAllDescrip.Size = new System.Drawing.Size(70, 24);
            this.kcbAllDescrip.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbAllDescrip.TabIndex = 1310;
            // 
            // rbHR
            // 
            this.rbHR.AutoSize = true;
            this.rbHR.BackColor = System.Drawing.Color.Transparent;
            this.rbHR.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHR.ForeColor = System.Drawing.Color.Black;
            this.rbHR.Location = new System.Drawing.Point(47, 31);
            this.rbHR.Name = "rbHR";
            this.rbHR.Size = new System.Drawing.Size(50, 27);
            this.rbHR.TabIndex = 1311;
            this.rbHR.TabStop = true;
            this.rbHR.Tag = "HR";
            this.rbHR.Text = "HR";
            this.rbHR.UseVisualStyleBackColor = false;
            this.rbHR.CheckedChanged += new System.EventHandler(this.rbCheckChange);
            // 
            // rbGen
            // 
            this.rbGen.AutoSize = true;
            this.rbGen.BackColor = System.Drawing.Color.Transparent;
            this.rbGen.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGen.ForeColor = System.Drawing.Color.Black;
            this.rbGen.Location = new System.Drawing.Point(47, 4);
            this.rbGen.Name = "rbGen";
            this.rbGen.Size = new System.Drawing.Size(49, 27);
            this.rbGen.TabIndex = 1306;
            this.rbGen.TabStop = true;
            this.rbGen.Tag = "BU";
            this.rbGen.Text = "BU";
            this.rbGen.UseVisualStyleBackColor = false;
            this.rbGen.CheckedChanged += new System.EventHandler(this.rbCheckChange);
            // 
            // lblSeq
            // 
            this.lblSeq.AutoSize = true;
            this.lblSeq.Location = new System.Drawing.Point(238, 2);
            this.lblSeq.Name = "lblSeq";
            this.lblSeq.Size = new System.Drawing.Size(13, 13);
            this.lblSeq.TabIndex = 1308;
            this.lblSeq.Text = "0";
            this.lblSeq.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(42, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(232, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 23);
            this.btnClose.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnClose.StateCommon.Border.Color1 = System.Drawing.Color.LightSteelBlue;
            this.btnClose.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.btnClose.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btnClose.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnClose.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 3;
            this.btnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.btnClose.TabIndex = 1312;
            this.btnClose.TabStop = false;
            this.btnClose.Values.Image = global::FactoryProductionRecorder.Properties.Resources.cancel_1;
            this.btnClose.Values.Text = "Quit";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 253);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Location = new System.Drawing.Point(120, 280);
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "SplashScreen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbAllStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcbAllDescrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private System.Windows.Forms.RadioButton rbHR;
        private System.Windows.Forms.RadioButton rbGI;
        private System.Windows.Forms.Label lblSeq;
        private System.Windows.Forms.RadioButton rbGen;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcbAllStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcbAllDescrip;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
    }
}