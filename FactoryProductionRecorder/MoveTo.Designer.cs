namespace FactoryProductionRecorder
{
    partial class MoveTo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQty = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kcbAllStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAssmPos = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPhaseId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.seqNum = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.StationPref = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPrev = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbAllStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seqNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StationPref)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(349, 36);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(113, 116);
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
            this.btnSend.MouseEnter += new System.EventHandler(this.tbAssmPos_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblQty);
            this.groupBox1.Controls.Add(this.kcbAllStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbAssmPos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPhaseId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.seqNum);
            this.groupBox1.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 120);
            this.groupBox1.TabIndex = 1279;
            this.groupBox1.TabStop = false;
            // 
            // lblQty
            // 
            this.lblQty.Location = new System.Drawing.Point(139, 50);
            this.lblQty.MaxLength = 150;
            this.lblQty.Name = "lblQty";
            this.lblQty.ReadOnly = true;
            this.lblQty.Size = new System.Drawing.Size(35, 28);
            this.lblQty.StateCommon.Back.Color1 = System.Drawing.Color.Azure;
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
            this.lblQty.TabIndex = 1306;
            this.lblQty.Tag = "Assembly Qty.";
            this.lblQty.Text = "0";
            this.lblQty.MouseEnter += new System.EventHandler(this.tbAssmPos_MouseEnter);
            // 
            // kcbAllStatus
            // 
            this.kcbAllStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.kcbAllStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.kcbAllStatus.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kcbAllStatus.DropDownHeight = 300;
            this.kcbAllStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcbAllStatus.DropDownWidth = 124;
            this.kcbAllStatus.Location = new System.Drawing.Point(175, 85);
            this.kcbAllStatus.MaxDropDownItems = 16;
            this.kcbAllStatus.Name = "kcbAllStatus";
            this.kcbAllStatus.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kcbAllStatus.Size = new System.Drawing.Size(149, 24);
            this.kcbAllStatus.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kcbAllStatus.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 12F);
            this.kcbAllStatus.TabIndex = 3;
            this.kcbAllStatus.Tag = "Stations";
            this.kcbAllStatus.SelectedIndexChanged += new System.EventHandler(this.kcbAllStatus_SelectedIndexChanged);
            this.kcbAllStatus.MouseEnter += new System.EventHandler(this.tbAssmPos_MouseEnter);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 1279;
            this.label4.Text = "To which station.? :";
            // 
            // tbAssmPos
            // 
            this.tbAssmPos.Location = new System.Drawing.Point(175, 50);
            this.tbAssmPos.MaxLength = 150;
            this.tbAssmPos.Name = "tbAssmPos";
            this.tbAssmPos.ReadOnly = true;
            this.tbAssmPos.Size = new System.Drawing.Size(149, 28);
            this.tbAssmPos.StateCommon.Back.Color1 = System.Drawing.Color.Azure;
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
            this.tbAssmPos.Tag = "Current Assembly Mark";
            this.tbAssmPos.Text = "ABC001";
            this.tbAssmPos.MouseEnter += new System.EventHandler(this.tbAssmPos_MouseEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 1277;
            this.label1.Text = "Assembly Pos:";
            // 
            // tbPhaseId
            // 
            this.tbPhaseId.Location = new System.Drawing.Point(139, 17);
            this.tbPhaseId.MaxLength = 150;
            this.tbPhaseId.Name = "tbPhaseId";
            this.tbPhaseId.ReadOnly = true;
            this.tbPhaseId.Size = new System.Drawing.Size(185, 28);
            this.tbPhaseId.StateCommon.Back.Color1 = System.Drawing.Color.Azure;
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
            this.tbPhaseId.Tag = "PHASE ID";
            this.tbPhaseId.Text = "AE-A0123-01-101";
            this.tbPhaseId.MouseEnter += new System.EventHandler(this.tbAssmPos_MouseEnter);
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
            // seqNum
            // 
            this.seqNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.seqNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.seqNum.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.seqNum.DropDownHeight = 300;
            this.seqNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seqNum.DropDownWidth = 124;
            this.seqNum.Enabled = false;
            this.seqNum.Location = new System.Drawing.Point(139, 85);
            this.seqNum.MaxDropDownItems = 16;
            this.seqNum.Name = "seqNum";
            this.seqNum.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.seqNum.Size = new System.Drawing.Size(97, 24);
            this.seqNum.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 12F);
            this.seqNum.TabIndex = 1304;
            this.seqNum.Tag = "Station Sequence";
            this.seqNum.MouseEnter += new System.EventHandler(this.tbAssmPos_MouseEnter);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(39, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 15);
            this.label3.TabIndex = 1280;
            this.label3.Text = "Return to a previous Station";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // StationPref
            // 
            this.StationPref.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.StationPref.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.StationPref.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.StationPref.DropDownHeight = 300;
            this.StationPref.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StationPref.DropDownWidth = 124;
            this.StationPref.Enabled = false;
            this.StationPref.Location = new System.Drawing.Point(145, 129);
            this.StationPref.MaxDropDownItems = 16;
            this.StationPref.Name = "StationPref";
            this.StationPref.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.StationPref.Size = new System.Drawing.Size(185, 24);
            this.StationPref.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 12F);
            this.StationPref.TabIndex = 1305;
            this.metroToolTip1.SetToolTip(this.StationPref, "Stations");
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
            // lblPrev
            // 
            this.lblPrev.BackColor = System.Drawing.Color.MintCream;
            this.lblPrev.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrev.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPrev.Location = new System.Drawing.Point(3, 155);
            this.lblPrev.Name = "lblPrev";
            this.lblPrev.Size = new System.Drawing.Size(163, 15);
            this.lblPrev.TabIndex = 1306;
            this.lblPrev.Text = "..";
            // 
            // MoveTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 170);
            this.Controls.Add(this.lblPrev);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StationPref);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(472, 170);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(472, 170);
            this.Name = "MoveTo";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.MoveTo_Load);
            this.MouseEnter += new System.EventHandler(this.MoveTo_MouseEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbAllStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seqNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StationPref)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbPhaseId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbAssmPos;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcbAllStatus;
        private System.Windows.Forms.Panel panel5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox seqNum;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox StationPref;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox lblQty;
        private System.Windows.Forms.Label lblPrev;
    }
}