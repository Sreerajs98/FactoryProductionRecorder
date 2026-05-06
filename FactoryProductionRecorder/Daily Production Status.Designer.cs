namespace FactoryProductionRecorder
{
    partial class Daily_Production_Status
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbYearly = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox3 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbShifts = new System.Windows.Forms.CheckedListBox();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbStations = new System.Windows.Forms.CheckedListBox();
            this.BtnSrch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtpikProd = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.DgvStationData = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbtotQty = new System.Windows.Forms.TextBox();
            this.tbtotWeight = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStationData)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.rbYearly);
            this.panel2.Controls.Add(this.rbMonthly);
            this.panel2.Controls.Add(this.rbDaily);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.kryptonGroupBox3);
            this.panel2.Controls.Add(this.kryptonGroupBox2);
            this.panel2.Controls.Add(this.BtnSrch);
            this.panel2.Controls.Add(this.dtpikProd);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.kryptonGroupBox1);
            this.panel2.Location = new System.Drawing.Point(8, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 569);
            this.panel2.TabIndex = 1293;
            // 
            // rbYearly
            // 
            this.rbYearly.AutoSize = true;
            this.rbYearly.Location = new System.Drawing.Point(1019, 11);
            this.rbYearly.Name = "rbYearly";
            this.rbYearly.Size = new System.Drawing.Size(54, 17);
            this.rbYearly.TabIndex = 1320;
            this.rbYearly.TabStop = true;
            this.rbYearly.Text = "Yearly";
            this.rbYearly.UseVisualStyleBackColor = true;
            this.rbYearly.CheckedChanged += new System.EventHandler(this.ProdutionFilterSwitchChecked);
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Location = new System.Drawing.Point(957, 11);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(62, 17);
            this.rbMonthly.TabIndex = 1319;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            this.rbMonthly.CheckedChanged += new System.EventHandler(this.ProdutionFilterSwitchChecked);
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Location = new System.Drawing.Point(909, 11);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(48, 17);
            this.rbDaily.TabIndex = 1318;
            this.rbDaily.TabStop = true;
            this.rbDaily.Text = "Daily";
            this.rbDaily.UseVisualStyleBackColor = true;
            this.rbDaily.CheckedChanged += new System.EventHandler(this.ProdutionFilterSwitchChecked);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(974, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 43);
            this.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnSave.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btnSave.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnSave.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 5;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.btnSave.TabIndex = 1317;
            this.toolTip1.SetToolTip(this.btnSave, "Export Report");
            this.btnSave.Values.Image = global::FactoryProductionRecorder.Properties.Resources.report;
            this.btnSave.Values.Text = "Export";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonGroupBox3.CaptionOverlap = 0.1D;
            this.kryptonGroupBox3.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonGroupBox3.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonNavigatorMini;
            this.kryptonGroupBox3.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonLowProfile;
            this.kryptonGroupBox3.Location = new System.Drawing.Point(909, 311);
            this.kryptonGroupBox3.Name = "kryptonGroupBox3";
            this.kryptonGroupBox3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // kryptonGroupBox3.Panel
            // 
            this.kryptonGroupBox3.Panel.Controls.Add(this.lbShifts);
            this.kryptonGroupBox3.Size = new System.Drawing.Size(165, 128);
            this.kryptonGroupBox3.StateCommon.Back.Color1 = System.Drawing.Color.LightSlateGray;
            this.kryptonGroupBox3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox3.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonGroupBox3.TabIndex = 1316;
            this.kryptonGroupBox3.Tag = "0";
            this.kryptonGroupBox3.Values.Heading = "Shifts:";
            this.kryptonGroupBox3.Values.Image = global::FactoryProductionRecorder.Properties.Resources.edit;
            // 
            // lbShifts
            // 
            this.lbShifts.CheckOnClick = true;
            this.lbShifts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbShifts.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.lbShifts.FormattingEnabled = true;
            this.lbShifts.Items.AddRange(new object[] {
            "DAY",
            "NIGHT"});
            this.lbShifts.Location = new System.Drawing.Point(0, 0);
            this.lbShifts.Name = "lbShifts";
            this.lbShifts.Size = new System.Drawing.Size(161, 107);
            this.lbShifts.TabIndex = 1318;
            this.lbShifts.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lbShifts_ItemCheck);
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonGroupBox2.CaptionOverlap = 0.1D;
            this.kryptonGroupBox2.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonNavigatorMini;
            this.kryptonGroupBox2.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonLowProfile;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(909, 98);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            this.kryptonGroupBox2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbStations);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(165, 204);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.LightSlateGray;
            this.kryptonGroupBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonGroupBox2.TabIndex = 1315;
            this.kryptonGroupBox2.Tag = "0";
            this.kryptonGroupBox2.Values.Heading = "Stations:";
            this.kryptonGroupBox2.Values.Image = global::FactoryProductionRecorder.Properties.Resources.edit;
            // 
            // lbStations
            // 
            this.lbStations.CheckOnClick = true;
            this.lbStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStations.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.lbStations.FormattingEnabled = true;
            this.lbStations.Items.AddRange(new object[] {
            "SAW1",
            "SAW2",
            "DSW1",
            "DSW2",
            "FAB",
            "WELD",
            "PAINT",
            "CF"});
            this.lbStations.Location = new System.Drawing.Point(0, 0);
            this.lbStations.Name = "lbStations";
            this.lbStations.Size = new System.Drawing.Size(161, 183);
            this.lbStations.TabIndex = 1317;
            this.lbStations.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lbStations_ItemCheck);
            // 
            // BtnSrch
            // 
            this.BtnSrch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSrch.Location = new System.Drawing.Point(974, 467);
            this.BtnSrch.Name = "BtnSrch";
            this.BtnSrch.Size = new System.Drawing.Size(100, 44);
            this.BtnSrch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSrch.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.BtnSrch.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.BtnSrch.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.BtnSrch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnSrch.StateCommon.Border.Rounding = 5;
            this.BtnSrch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnSrch.TabIndex = 1304;
            this.toolTip1.SetToolTip(this.BtnSrch, "Search");
            this.BtnSrch.Values.Image = global::FactoryProductionRecorder.Properties.Resources.search001;
            this.BtnSrch.Values.Text = "Search";
            this.BtnSrch.Click += new System.EventHandler(this.BtnSrch_Click);
            // 
            // dtpikProd
            // 
            this.dtpikProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpikProd.CustomFormat = "dd-MMM-yyyy";
            this.dtpikProd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F);
            this.dtpikProd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpikProd.Location = new System.Drawing.Point(912, 54);
            this.dtpikProd.Name = "dtpikProd";
            this.dtpikProd.Size = new System.Drawing.Size(158, 32);
            this.dtpikProd.TabIndex = 1297;
            this.dtpikProd.ValueChanged += new System.EventHandler(this.dtpikProd_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 5);
            this.panel1.TabIndex = 1306;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(909, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 52);
            this.label2.TabIndex = 1298;
            this.label2.Text = "Production Date:";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonGroupBox1.CaptionOverlap = 0.1D;
            this.kryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonNavigatorMini;
            this.kryptonGroupBox1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonLowProfile;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(2, 5);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            this.kryptonGroupBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.DgvStationData);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(900, 560);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.LightSlateGray;
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonGroupBox1.TabIndex = 1263;
            this.kryptonGroupBox1.Tag = "0";
            this.kryptonGroupBox1.Values.Heading = "Assembly Distribution List";
            this.kryptonGroupBox1.Values.Image = global::FactoryProductionRecorder.Properties.Resources.edit;
            // 
            // DgvStationData
            // 
            this.DgvStationData.AllowUserToAddRows = false;
            this.DgvStationData.AllowUserToDeleteRows = false;
            this.DgvStationData.ColumnHeadersHeight = 25;
            this.DgvStationData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvStationData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvStationData.Location = new System.Drawing.Point(0, 0);
            this.DgvStationData.Name = "DgvStationData";
            this.DgvStationData.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.DgvStationData.RowHeadersWidth = 35;
            this.DgvStationData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvStationData.RowTemplate.Height = 28;
            this.DgvStationData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvStationData.Size = new System.Drawing.Size(896, 539);
            this.DgvStationData.StateCommon.Background.Color1 = System.Drawing.Color.Gray;
            this.DgvStationData.StateCommon.Background.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.BottomRight;
            this.DgvStationData.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.DgvStationData.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DgvStationData.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.DgvStationData.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.LightSteelBlue;
            this.DgvStationData.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.DgvStationData.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.DgvStationData.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DgvStationData.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.DgvStationData.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvStationData.StateCommon.HeaderColumn.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DgvStationData.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.DgvStationData.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.DgvStationData.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.DarkGray;
            this.DgvStationData.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvStationData.StateSelected.HeaderRow.Back.Color1 = System.Drawing.Color.Cyan;
            this.DgvStationData.TabIndex = 12;
            this.DgvStationData.Tag = "0";
            this.DgvStationData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvStationData_RowPostPaint);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            // 
            // tbtotQty
            // 
            this.tbtotQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbtotQty.BackColor = System.Drawing.Color.Azure;
            this.tbtotQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbtotQty.Font = new System.Drawing.Font("Arial", 12F);
            this.tbtotQty.ForeColor = System.Drawing.Color.Blue;
            this.tbtotQty.Location = new System.Drawing.Point(501, 651);
            this.tbtotQty.Name = "tbtotQty";
            this.tbtotQty.ReadOnly = true;
            this.tbtotQty.Size = new System.Drawing.Size(76, 19);
            this.tbtotQty.TabIndex = 1317;
            this.tbtotQty.Text = "0";
            this.tbtotQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.tbtotQty, "Total Assm Qty.");
            // 
            // tbtotWeight
            // 
            this.tbtotWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbtotWeight.BackColor = System.Drawing.Color.Azure;
            this.tbtotWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbtotWeight.Font = new System.Drawing.Font("Arial", 12F);
            this.tbtotWeight.ForeColor = System.Drawing.Color.Blue;
            this.tbtotWeight.Location = new System.Drawing.Point(637, 651);
            this.tbtotWeight.Name = "tbtotWeight";
            this.tbtotWeight.ReadOnly = true;
            this.tbtotWeight.Size = new System.Drawing.Size(96, 19);
            this.tbtotWeight.TabIndex = 1318;
            this.tbtotWeight.Text = "0";
            this.tbtotWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.tbtotWeight, "Total Assm Wt.");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.LightGray;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelPath});
            this.statusStrip1.Location = new System.Drawing.Point(8, 648);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1082, 31);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1316;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelPath
            // 
            this.labelPath.IsLink = true;
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(106, 26);
            this.labelPath.Tag = "C:\\InHouseApps\\FPR";
            this.labelPath.Text = "Open File Location";
            this.labelPath.Click += new System.EventHandler(this.labelPath_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::FactoryProductionRecorder.Properties.Resources.report;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(12, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(36, 40);
            this.panel5.TabIndex = 1319;
            // 
            // Daily_Production_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 682);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.tbtotQty);
            this.Controls.Add(this.tbtotWeight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Daily_Production_Status";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "    Daily Production Status";
            this.Load += new System.EventHandler(this.Daily_Production_Status_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStationData)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DgvStationData;
        private System.Windows.Forms.DateTimePicker dtpikProd;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnSrch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox tbtotQty;
        private System.Windows.Forms.TextBox tbtotWeight;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private System.Windows.Forms.CheckedListBox lbStations;
        private System.Windows.Forms.CheckedListBox lbShifts;
        private System.Windows.Forms.Panel panel5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private System.Windows.Forms.ToolStripStatusLabel labelPath;
        private System.Windows.Forms.RadioButton rbDaily;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.RadioButton rbYearly;
    }
}