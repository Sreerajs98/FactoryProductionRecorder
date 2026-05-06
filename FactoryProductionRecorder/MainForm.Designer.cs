namespace FactoryProductionRecorder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DgvAssmData = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.DgvNextStation = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.groupboxBOM = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rbHR = new System.Windows.Forms.RadioButton();
            this.rbGI = new System.Windows.Forms.RadioButton();
            this.lblSeq = new System.Windows.Forms.Label();
            this.rbGen = new System.Windows.Forms.RadioButton();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kcbAllStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kcbAllDescrip = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnAllTransferToNextStation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAllReturnToProcessing = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSingleReturnToProcessing = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSingleTransferToNextStation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.rbNight = new System.Windows.Forms.RadioButton();
            this.ViewDailyReportBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsAssmPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDot = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsAssmQty = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssmData)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNextStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupboxBOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupboxBOM.Panel)).BeginInit();
            this.groupboxBOM.Panel.SuspendLayout();
            this.groupboxBOM.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbAllStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcbAllDescrip)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(612, 13);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(113, 48);
            this.btAdd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btAdd.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btAdd.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btAdd.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btAdd.StateCommon.Border.Color2 = System.Drawing.Color.RosyBrown;
            this.btAdd.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btAdd.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btAdd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btAdd.StateCommon.Border.Rounding = 3;
            this.btAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.TabIndex = 1280;
            this.metroToolTip1.SetToolTip(this.btAdd, "Add/Edit records");
            this.btAdd.Values.Image = global::FactoryProductionRecorder.Properties.Resources.barCode;
            this.btAdd.Values.Text = "Add/Edit";
            this.btAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DgvAssmData
            // 
            this.DgvAssmData.AllowDrop = true;
            this.DgvAssmData.AllowUserToAddRows = false;
            this.DgvAssmData.ColumnHeadersHeight = 25;
            this.DgvAssmData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvAssmData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAssmData.Location = new System.Drawing.Point(0, 0);
            this.DgvAssmData.Name = "DgvAssmData";
            this.DgvAssmData.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.DgvAssmData.RowHeadersWidth = 35;
            this.DgvAssmData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvAssmData.RowTemplate.Height = 30;
            this.DgvAssmData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAssmData.Size = new System.Drawing.Size(720, 549);
            this.DgvAssmData.StateCommon.Background.Color1 = System.Drawing.Color.DarkGray;
            this.DgvAssmData.StateCommon.Background.Image = global::FactoryProductionRecorder.Properties.Resources.AceroA;
            this.DgvAssmData.StateCommon.Background.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.BottomLeft;
            this.DgvAssmData.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.DgvAssmData.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(221)))), ((int)(((byte)(228)))));
            this.DgvAssmData.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DgvAssmData.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvAssmData.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.LightSteelBlue;
            this.DgvAssmData.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.LightSlateGray;
            this.DgvAssmData.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.DgvAssmData.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DgvAssmData.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.DgvAssmData.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvAssmData.StateCommon.HeaderColumn.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DgvAssmData.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.DgvAssmData.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.DgvAssmData.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.DarkGray;
            this.DgvAssmData.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvAssmData.TabIndex = 1290;
            this.DgvAssmData.Tag = "0";
            this.DgvAssmData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvAssmData_RowPostPaint);
            this.DgvAssmData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvAssmData_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.kryptonGroupBox1);
            this.panel2.Location = new System.Drawing.Point(798, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 640);
            this.panel2.TabIndex = 1291;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(434, 5);
            this.panel6.TabIndex = 1307;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(364, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 48);
            this.btnSearch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSearch.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnSearch.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnSearch.StateCommon.Border.Color2 = System.Drawing.Color.RosyBrown;
            this.btnSearch.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btnSearch.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StateCommon.Border.Rounding = 3;
            this.btnSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.TabIndex = 1304;
            this.metroToolTip1.SetToolTip(this.btnSearch, "Search Tool");
            this.btnSearch.Values.Image = global::FactoryProductionRecorder.Properties.Resources.search_40;
            this.btnSearch.Values.Text = "";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.kryptonGroupBox1.Location = new System.Drawing.Point(3, 69);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            this.kryptonGroupBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.DgvNextStation);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(428, 570);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.SlateGray;
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonGroupBox1.TabIndex = 1263;
            this.kryptonGroupBox1.Tag = "0";
            this.kryptonGroupBox1.Values.Heading = "Next Station Data";
            this.kryptonGroupBox1.Values.Image = global::FactoryProductionRecorder.Properties.Resources.read1;
            // 
            // DgvNextStation
            // 
            this.DgvNextStation.AllowUserToAddRows = false;
            this.DgvNextStation.AllowUserToDeleteRows = false;
            this.DgvNextStation.ColumnHeadersHeight = 25;
            this.DgvNextStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvNextStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvNextStation.Location = new System.Drawing.Point(0, 0);
            this.DgvNextStation.Name = "DgvNextStation";
            this.DgvNextStation.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.DgvNextStation.RowHeadersWidth = 35;
            this.DgvNextStation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvNextStation.RowTemplate.Height = 28;
            this.DgvNextStation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvNextStation.Size = new System.Drawing.Size(424, 549);
            this.DgvNextStation.StateCommon.Background.Color1 = System.Drawing.Color.DarkGray;
            this.DgvNextStation.StateCommon.Background.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.BottomMiddle;
            this.DgvNextStation.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.DgvNextStation.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DgvNextStation.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.DgvNextStation.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.LightSteelBlue;
            this.DgvNextStation.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.LightSlateGray;
            this.DgvNextStation.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.DgvNextStation.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DgvNextStation.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.DgvNextStation.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvNextStation.StateCommon.HeaderColumn.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DgvNextStation.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.DgvNextStation.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.DgvNextStation.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.DarkGray;
            this.DgvNextStation.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvNextStation.StateSelected.HeaderRow.Back.Color1 = System.Drawing.Color.Khaki;
            this.DgvNextStation.TabIndex = 12;
            this.DgvNextStation.Tag = "0";
            this.DgvNextStation.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvNextStation_RowPostPaint);
            // 
            // groupboxBOM
            // 
            this.groupboxBOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupboxBOM.CaptionOverlap = 0.1D;
            this.groupboxBOM.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.groupboxBOM.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonNavigatorMini;
            this.groupboxBOM.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonLowProfile;
            this.groupboxBOM.Location = new System.Drawing.Point(3, 69);
            this.groupboxBOM.Name = "groupboxBOM";
            this.groupboxBOM.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // groupboxBOM.Panel
            // 
            this.groupboxBOM.Panel.Controls.Add(this.DgvAssmData);
            this.groupboxBOM.Size = new System.Drawing.Size(724, 570);
            this.groupboxBOM.StateCommon.Back.Color1 = System.Drawing.Color.SlateGray;
            this.groupboxBOM.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.groupboxBOM.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.groupboxBOM.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxBOM.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.groupboxBOM.TabIndex = 1292;
            this.groupboxBOM.Tag = "0";
            this.groupboxBOM.Values.Heading = "My Station Data";
            this.groupboxBOM.Values.Image = global::FactoryProductionRecorder.Properties.Resources.star;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.rbHR);
            this.panel1.Controls.Add(this.rbGI);
            this.panel1.Controls.Add(this.lblSeq);
            this.panel1.Controls.Add(this.rbGen);
            this.panel1.Controls.Add(this.kryptonGroupBox2);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.groupboxBOM);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.kcbAllDescrip);
            this.panel1.Location = new System.Drawing.Point(6, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 642);
            this.panel1.TabIndex = 1293;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SteelBlue;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(730, 5);
            this.panel7.TabIndex = 1308;
            // 
            // rbHR
            // 
            this.rbHR.AutoSize = true;
            this.rbHR.BackColor = System.Drawing.Color.Silver;
            this.rbHR.Location = new System.Drawing.Point(325, 16);
            this.rbHR.Name = "rbHR";
            this.rbHR.Size = new System.Drawing.Size(41, 17);
            this.rbHR.TabIndex = 1305;
            this.rbHR.TabStop = true;
            this.rbHR.Tag = "HR";
            this.rbHR.Text = "HR";
            this.rbHR.UseVisualStyleBackColor = false;
            this.rbHR.CheckedChanged += new System.EventHandler(this.rbCheckChange);
            // 
            // rbGI
            // 
            this.rbGI.AutoSize = true;
            this.rbGI.BackColor = System.Drawing.Color.Silver;
            this.rbGI.Location = new System.Drawing.Point(371, 16);
            this.rbGI.Name = "rbGI";
            this.rbGI.Size = new System.Drawing.Size(125, 17);
            this.rbGI.TabIndex = 1297;
            this.rbGI.TabStop = true;
            this.rbGI.Tag = "CF";
            this.rbGI.Text = "Secondary Steel (CF)";
            this.rbGI.UseVisualStyleBackColor = false;
            this.rbGI.CheckedChanged += new System.EventHandler(this.rbCheckChange);
            // 
            // lblSeq
            // 
            this.lblSeq.AutoSize = true;
            this.lblSeq.Location = new System.Drawing.Point(515, 18);
            this.lblSeq.Name = "lblSeq";
            this.lblSeq.Size = new System.Drawing.Size(13, 13);
            this.lblSeq.TabIndex = 1299;
            this.lblSeq.Text = "0";
            this.lblSeq.Visible = false;
            // 
            // rbGen
            // 
            this.rbGen.AutoSize = true;
            this.rbGen.BackColor = System.Drawing.Color.Silver;
            this.rbGen.Location = new System.Drawing.Point(280, 16);
            this.rbGen.Name = "rbGen";
            this.rbGen.Size = new System.Drawing.Size(40, 17);
            this.rbGen.TabIndex = 1296;
            this.rbGen.TabStop = true;
            this.rbGen.Tag = "BU";
            this.rbGen.Text = "BU";
            this.rbGen.UseVisualStyleBackColor = false;
            this.rbGen.CheckedChanged += new System.EventHandler(this.rbCheckChange);
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.CaptionOverlap = 0.1D;
            this.kryptonGroupBox2.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbonAppMenu;
            this.kryptonGroupBox2.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonLowProfile;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(277, 12);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            this.kryptonGroupBox2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.kcbAllStatus);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(238, 51);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.kryptonGroupBox2.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.TabIndex = 1303;
            this.kryptonGroupBox2.Values.Heading = ".";
            // 
            // kcbAllStatus
            // 
            this.kcbAllStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.kcbAllStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.kcbAllStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kcbAllStatus.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kcbAllStatus.DropDownHeight = 300;
            this.kcbAllStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcbAllStatus.DropDownWidth = 124;
            this.kcbAllStatus.Location = new System.Drawing.Point(0, 6);
            this.kcbAllStatus.MaxDropDownItems = 16;
            this.kcbAllStatus.Name = "kcbAllStatus";
            this.kcbAllStatus.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kcbAllStatus.Size = new System.Drawing.Size(234, 24);
            this.kcbAllStatus.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbAllStatus.TabIndex = 1298;
            this.metroToolTip1.SetToolTip(this.kcbAllStatus, "Stations");
            this.kcbAllStatus.SelectedIndexChanged += new System.EventHandler(this.kcbAllStatus_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 48);
            this.btnRefresh.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefresh.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnRefresh.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnRefresh.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnRefresh.StateCommon.Border.Color2 = System.Drawing.Color.RosyBrown;
            this.btnRefresh.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btnRefresh.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnRefresh.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRefresh.StateCommon.Border.Rounding = 3;
            this.btnRefresh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.TabIndex = 1295;
            this.metroToolTip1.SetToolTip(this.btnRefresh, "Refresh");
            this.btnRefresh.Values.Image = global::FactoryProductionRecorder.Properties.Resources.refresh2;
            this.btnRefresh.Values.Text = "";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // kcbAllDescrip
            // 
            this.kcbAllDescrip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.kcbAllDescrip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.kcbAllDescrip.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kcbAllDescrip.DropDownHeight = 300;
            this.kcbAllDescrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcbAllDescrip.DropDownWidth = 124;
            this.kcbAllDescrip.Location = new System.Drawing.Point(435, 35);
            this.kcbAllDescrip.MaxDropDownItems = 16;
            this.kcbAllDescrip.Name = "kcbAllDescrip";
            this.kcbAllDescrip.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kcbAllDescrip.Size = new System.Drawing.Size(80, 24);
            this.kcbAllDescrip.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbAllDescrip.TabIndex = 1304;
            this.kcbAllDescrip.SelectedIndexChanged += new System.EventHandler(this.kcbAllDescrip_SelectedIndexChanged);
            // 
            // btnAllTransferToNextStation
            // 
            this.btnAllTransferToNextStation.Location = new System.Drawing.Point(3, 6);
            this.btnAllTransferToNextStation.Name = "btnAllTransferToNextStation";
            this.btnAllTransferToNextStation.Size = new System.Drawing.Size(44, 97);
            this.btnAllTransferToNextStation.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAllTransferToNextStation.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnAllTransferToNextStation.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnAllTransferToNextStation.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnAllTransferToNextStation.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.btnAllTransferToNextStation.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btnAllTransferToNextStation.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnAllTransferToNextStation.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAllTransferToNextStation.StateCommon.Border.Rounding = 3;
            this.btnAllTransferToNextStation.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllTransferToNextStation.TabIndex = 1294;
            this.metroToolTip1.SetToolTip(this.btnAllTransferToNextStation, "Transfer ALL");
            this.btnAllTransferToNextStation.Values.Image = global::FactoryProductionRecorder.Properties.Resources.DR;
            this.btnAllTransferToNextStation.Values.Text = "";
            this.btnAllTransferToNextStation.Click += new System.EventHandler(this.btnAllTransferToNextStation_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.LightGray;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(6, 715);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(730, 31);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1294;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslStatus.ForeColor = System.Drawing.Color.Red;
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(48, 26);
            this.tslStatus.Text = "Ready";
            // 
            // btnAllReturnToProcessing
            // 
            this.btnAllReturnToProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAllReturnToProcessing.Location = new System.Drawing.Point(4, 61);
            this.btnAllReturnToProcessing.Name = "btnAllReturnToProcessing";
            this.btnAllReturnToProcessing.Size = new System.Drawing.Size(44, 97);
            this.btnAllReturnToProcessing.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAllReturnToProcessing.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAllReturnToProcessing.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnAllReturnToProcessing.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnAllReturnToProcessing.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnAllReturnToProcessing.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.btnAllReturnToProcessing.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btnAllReturnToProcessing.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnAllReturnToProcessing.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAllReturnToProcessing.StateCommon.Border.Rounding = 3;
            this.btnAllReturnToProcessing.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllReturnToProcessing.TabIndex = 1295;
            this.metroToolTip1.SetToolTip(this.btnAllReturnToProcessing, "Return ALL");
            this.btnAllReturnToProcessing.Values.Image = global::FactoryProductionRecorder.Properties.Resources.DL;
            this.btnAllReturnToProcessing.Values.Text = "";
            this.btnAllReturnToProcessing.Click += new System.EventHandler(this.btnAllReturnToProcessing_Click);
            // 
            // btnSingleReturnToProcessing
            // 
            this.btnSingleReturnToProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSingleReturnToProcessing.Location = new System.Drawing.Point(4, 5);
            this.btnSingleReturnToProcessing.Name = "btnSingleReturnToProcessing";
            this.btnSingleReturnToProcessing.Size = new System.Drawing.Size(44, 50);
            this.btnSingleReturnToProcessing.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSingleReturnToProcessing.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSingleReturnToProcessing.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSingleReturnToProcessing.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnSingleReturnToProcessing.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnSingleReturnToProcessing.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.btnSingleReturnToProcessing.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btnSingleReturnToProcessing.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnSingleReturnToProcessing.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSingleReturnToProcessing.StateCommon.Border.Rounding = 3;
            this.btnSingleReturnToProcessing.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleReturnToProcessing.TabIndex = 1297;
            this.metroToolTip1.SetToolTip(this.btnSingleReturnToProcessing, "Return the Selected Data");
            this.btnSingleReturnToProcessing.Values.Image = global::FactoryProductionRecorder.Properties.Resources.SL;
            this.btnSingleReturnToProcessing.Values.Text = "";
            this.btnSingleReturnToProcessing.Click += new System.EventHandler(this.btnSingleReturnToProcessing_Click);
            // 
            // btnSingleTransferToNextStation
            // 
            this.btnSingleTransferToNextStation.Location = new System.Drawing.Point(3, 107);
            this.btnSingleTransferToNextStation.Name = "btnSingleTransferToNextStation";
            this.btnSingleTransferToNextStation.Size = new System.Drawing.Size(44, 50);
            this.btnSingleTransferToNextStation.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSingleTransferToNextStation.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSingleTransferToNextStation.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnSingleTransferToNextStation.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnSingleTransferToNextStation.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.btnSingleTransferToNextStation.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btnSingleTransferToNextStation.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnSingleTransferToNextStation.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSingleTransferToNextStation.StateCommon.Border.Rounding = 3;
            this.btnSingleTransferToNextStation.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleTransferToNextStation.TabIndex = 1296;
            this.metroToolTip1.SetToolTip(this.btnSingleTransferToNextStation, "Transfer the Selected Data");
            this.btnSingleTransferToNextStation.Values.Image = global::FactoryProductionRecorder.Properties.Resources.SR;
            this.btnSingleTransferToNextStation.Values.Text = "";
            this.btnSingleTransferToNextStation.Click += new System.EventHandler(this.btnSingleTransferToNextStation_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // rbDay
            // 
            this.rbDay.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rbDay.Location = new System.Drawing.Point(2, 163);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(50, 17);
            this.rbDay.TabIndex = 1297;
            this.rbDay.TabStop = true;
            this.rbDay.Tag = "";
            this.rbDay.Text = "Day";
            this.metroToolTip1.SetToolTip(this.rbDay, "Shift");
            this.rbDay.UseVisualStyleBackColor = false;
            // 
            // rbNight
            // 
            this.rbNight.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rbNight.Location = new System.Drawing.Point(2, 184);
            this.rbNight.Name = "rbNight";
            this.rbNight.Size = new System.Drawing.Size(50, 17);
            this.rbNight.TabIndex = 1306;
            this.rbNight.TabStop = true;
            this.rbNight.Tag = "";
            this.rbNight.Text = "Night";
            this.metroToolTip1.SetToolTip(this.rbNight, "Shift");
            this.rbNight.UseVisualStyleBackColor = false;
            // 
            // ViewDailyReportBtn
            // 
            this.ViewDailyReportBtn.Location = new System.Drawing.Point(798, 25);
            this.ViewDailyReportBtn.Name = "ViewDailyReportBtn";
            this.ViewDailyReportBtn.Size = new System.Drawing.Size(40, 42);
            this.ViewDailyReportBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ViewDailyReportBtn.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.ViewDailyReportBtn.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.ViewDailyReportBtn.StateCommon.Border.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.ViewDailyReportBtn.StateCommon.Border.Color2 = System.Drawing.Color.PaleTurquoise;
            this.ViewDailyReportBtn.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.ViewDailyReportBtn.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.ViewDailyReportBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ViewDailyReportBtn.StateCommon.Border.Rounding = 3;
            this.ViewDailyReportBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDailyReportBtn.TabIndex = 1305;
            this.metroToolTip1.SetToolTip(this.ViewDailyReportBtn, "Report Viewer");
            this.ViewDailyReportBtn.Values.Image = global::FactoryProductionRecorder.Properties.Resources.report;
            this.ViewDailyReportBtn.Values.Text = "";
            this.ViewDailyReportBtn.Click += new System.EventHandler(this.ViewDailyReportBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.rbNight);
            this.panel3.Controls.Add(this.btnAllTransferToNextStation);
            this.panel3.Controls.Add(this.btnSingleTransferToNextStation);
            this.panel3.Controls.Add(this.rbDay);
            this.panel3.Location = new System.Drawing.Point(736, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(52, 205);
            this.panel3.TabIndex = 1299;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.btnSingleReturnToProcessing);
            this.panel4.Controls.Add(this.btnAllReturnToProcessing);
            this.panel4.Location = new System.Drawing.Point(747, 528);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(52, 162);
            this.panel4.TabIndex = 1300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 26);
            this.label1.TabIndex = 1302;
            this.label1.Text = "Factory Production Recorder :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Ivory;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(303, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 1303;
            this.label2.Text = "[]";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip2.AutoSize = false;
            this.statusStrip2.BackColor = System.Drawing.Color.LightGray;
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsAssmPos,
            this.tsDot,
            this.tsAssmQty});
            this.statusStrip2.Location = new System.Drawing.Point(798, 715);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(434, 31);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 1304;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(28, 26);
            this.toolStripStatusLabel1.Text = "       ";
            // 
            // tsAssmPos
            // 
            this.tsAssmPos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsAssmPos.ForeColor = System.Drawing.Color.Black;
            this.tsAssmPos.Name = "tsAssmPos";
            this.tsAssmPos.Size = new System.Drawing.Size(30, 26);
            this.tsAssmPos.Text = "AA";
            this.tsAssmPos.ToolTipText = "Assembly Mark";
            this.tsAssmPos.Visible = false;
            // 
            // tsDot
            // 
            this.tsDot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsDot.ForeColor = System.Drawing.Color.Black;
            this.tsDot.Name = "tsDot";
            this.tsDot.Size = new System.Drawing.Size(12, 26);
            this.tsDot.Text = ":";
            this.tsDot.Visible = false;
            // 
            // tsAssmQty
            // 
            this.tsAssmQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsAssmQty.ForeColor = System.Drawing.Color.Black;
            this.tsAssmQty.Name = "tsAssmQty";
            this.tsAssmQty.Size = new System.Drawing.Size(26, 26);
            this.tsAssmQty.Text = "00";
            this.tsAssmQty.ToolTipText = "Assembly Qty.";
            this.tsAssmQty.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(1163, 716);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(65, 29);
            this.btnLogin.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogin.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnLogin.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnLogin.StateCommon.Border.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.btnLogin.StateCommon.Border.Color2 = System.Drawing.Color.PaleTurquoise;
            this.btnLogin.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btnLogin.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnLogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateCommon.Border.Rounding = 3;
            this.btnLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.TabIndex = 1306;
            this.metroToolTip1.SetToolTip(this.btnLogin, "Login");
            this.btnLogin.Values.Image = global::FactoryProductionRecorder.Properties.Resources.login;
            this.btnLogin.Values.Text = "";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::FactoryProductionRecorder.Properties.Resources.barCode;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(7, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(31, 31);
            this.panel5.TabIndex = 1301;
            this.metroToolTip1.SetToolTip(this.panel5, "Acero FPR");
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(211, 11);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(330, 51);
            this.panel8.TabIndex = 1309;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 750);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.ViewDailyReportBtn);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssmData)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvNextStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupboxBOM.Panel)).EndInit();
            this.groupboxBOM.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupboxBOM)).EndInit();
            this.groupboxBOM.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcbAllStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcbAllDescrip)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DgvAssmData;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DgvNextStation;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox groupboxBOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssmMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssemblyQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssmUnitWT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAllTransferToNextStation;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRefresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAllReturnToProcessing;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSingleReturnToProcessing;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSingleTransferToNextStation;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.RadioButton rbGen;
        private System.Windows.Forms.RadioButton rbGI;
        private System.Windows.Forms.Label lblSeq;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcbAllStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcbAllDescrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel tsAssmPos;
        private System.Windows.Forms.ToolStripStatusLabel tsDot;
        private System.Windows.Forms.ToolStripStatusLabel tsAssmQty;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private System.Windows.Forms.RadioButton rbHR;
        private System.Windows.Forms.RadioButton rbNight;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ViewDailyReportBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogin;
        private System.Windows.Forms.Panel panel8;
    }
}