namespace FactoryProductionRecorder
{
    partial class SearchTool
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
            this.cbHistory = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.DgvNextStation = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonGroupBox3 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.BtnSrch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rbAssembly = new System.Windows.Forms.RadioButton();
            this.tbSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.rbPhase = new System.Windows.Forms.RadioButton();
            this.lblActual = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsAssmPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDot = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsAssmQty = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.cms_AddEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsBay = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.msReturnto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsForwardTo = new System.Windows.Forms.ToolStripMenuItem();
            this.msRename = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditBay = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNextStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.cms_AddEdit.SuspendLayout();
            this.cmsBay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.cbHistory);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.kryptonGroupBox1);
            this.panel2.Controls.Add(this.kryptonGroupBox3);
            this.panel2.Controls.Add(this.lblActual);
            this.panel2.Location = new System.Drawing.Point(5, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 507);
            this.panel2.TabIndex = 1292;
            // 
            // cbHistory
            // 
            this.cbHistory.AutoSize = true;
            this.cbHistory.BackColor = System.Drawing.Color.RosyBrown;
            this.cbHistory.ForeColor = System.Drawing.Color.White;
            this.cbHistory.Location = new System.Drawing.Point(464, 9);
            this.cbHistory.Name = "cbHistory";
            this.cbHistory.Size = new System.Drawing.Size(79, 17);
            this.cbHistory.TabIndex = 1306;
            this.cbHistory.Text = "History Log";
            this.cbHistory.UseVisualStyleBackColor = false;
            this.cbHistory.CheckedChanged += new System.EventHandler(this.cbHistory_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 5);
            this.panel1.TabIndex = 1306;
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
            this.kryptonGroupBox1.Location = new System.Drawing.Point(3, 55);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            this.kryptonGroupBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.DgvNextStation);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(584, 449);
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
            this.DgvNextStation.Size = new System.Drawing.Size(580, 428);
            this.DgvNextStation.StateCommon.Background.Color1 = System.Drawing.Color.Gray;
            this.DgvNextStation.StateCommon.Background.Image = global::FactoryProductionRecorder.Properties.Resources.search_100;
            this.DgvNextStation.StateCommon.Background.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.BottomRight;
            this.DgvNextStation.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.DgvNextStation.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DgvNextStation.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.DgvNextStation.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.RosyBrown;
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
            this.DgvNextStation.StateSelected.HeaderRow.Back.Color1 = System.Drawing.Color.Cyan;
            this.DgvNextStation.TabIndex = 12;
            this.DgvNextStation.Tag = "0";
            this.DgvNextStation.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvNextStation_RowPostPaint);
            this.DgvNextStation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgvNextStation_MouseDown);
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonGroupBox3.CaptionOverlap = 0.1D;
            this.kryptonGroupBox3.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonGroupBox3.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbonAppMenu;
            this.kryptonGroupBox3.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonLowProfile;
            this.kryptonGroupBox3.Location = new System.Drawing.Point(3, 6);
            this.kryptonGroupBox3.Name = "kryptonGroupBox3";
            this.kryptonGroupBox3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // kryptonGroupBox3.Panel
            // 
            this.kryptonGroupBox3.Panel.Controls.Add(this.BtnSrch);
            this.kryptonGroupBox3.Panel.Controls.Add(this.rbAssembly);
            this.kryptonGroupBox3.Panel.Controls.Add(this.tbSearch);
            this.kryptonGroupBox3.Panel.Controls.Add(this.rbPhase);
            this.kryptonGroupBox3.Size = new System.Drawing.Size(584, 48);
            this.kryptonGroupBox3.StateCommon.Back.Color1 = System.Drawing.Color.RosyBrown;
            this.kryptonGroupBox3.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox3.TabIndex = 1302;
            this.kryptonGroupBox3.Values.Heading = "Search";
            // 
            // BtnSrch
            // 
            this.BtnSrch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSrch.Location = new System.Drawing.Point(539, 0);
            this.BtnSrch.Name = "BtnSrch";
            this.BtnSrch.Size = new System.Drawing.Size(38, 24);
            this.BtnSrch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSrch.StateCommon.Back.Image = global::FactoryProductionRecorder.Properties.Resources.search001;
            this.BtnSrch.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.BtnSrch.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.BtnSrch.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.BtnSrch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnSrch.StateCommon.Border.Rounding = 5;
            this.BtnSrch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtnSrch.TabIndex = 1303;
            this.BtnSrch.Values.Text = "";
            this.BtnSrch.Click += new System.EventHandler(this.BtnSrch_Click);
            // 
            // rbAssembly
            // 
            this.rbAssembly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(166)))), ((int)(((byte)(155)))));
            this.rbAssembly.Checked = true;
            this.rbAssembly.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.rbAssembly.Location = new System.Drawing.Point(111, 2);
            this.rbAssembly.Name = "rbAssembly";
            this.rbAssembly.Size = new System.Drawing.Size(124, 22);
            this.rbAssembly.TabIndex = 1304;
            this.rbAssembly.TabStop = true;
            this.rbAssembly.Tag = "CF";
            this.rbAssembly.Text = "Assembly wise";
            this.rbAssembly.UseVisualStyleBackColor = false;
            this.rbAssembly.CheckedChanged += new System.EventHandler(this.CommonCheckChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(239, 2);
            this.tbSearch.MaxLength = 150;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(294, 24);
            this.tbSearch.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tbSearch.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.tbSearch.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.tbSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSearch.StateCommon.Border.Rounding = 3;
            this.tbSearch.StateCommon.Border.Width = 1;
            this.tbSearch.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.TabIndex = 1165;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            this.tbSearch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseMove);
            // 
            // rbPhase
            // 
            this.rbPhase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(166)))), ((int)(((byte)(155)))));
            this.rbPhase.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPhase.Location = new System.Drawing.Point(3, 2);
            this.rbPhase.Name = "rbPhase";
            this.rbPhase.Size = new System.Drawing.Size(104, 22);
            this.rbPhase.TabIndex = 1303;
            this.rbPhase.Tag = "MS";
            this.rbPhase.Text = "Phase wise";
            this.rbPhase.UseVisualStyleBackColor = false;
            this.rbPhase.CheckedChanged += new System.EventHandler(this.CommonCheckChanged);
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(250, 5);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(35, 13);
            this.lblActual.TabIndex = 1303;
            this.lblActual.Text = "label1";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip2.AutoSize = false;
            this.statusStrip2.BackColor = System.Drawing.Color.RosyBrown;
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsAssmPos,
            this.tsDot,
            this.tsAssmQty,
            this.tsStatus});
            this.statusStrip2.Location = new System.Drawing.Point(5, 573);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(590, 31);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 1305;
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
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(547, 26);
            this.tsStatus.Spring = true;
            this.tsStatus.Text = "Ready";
            this.tsStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cms_AddEdit
            // 
            this.cms_AddEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cms_AddEdit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_AddEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msReturnto,
            this.tsForwardTo,
            this.toolStripSeparator1,
            this.msRename});
            this.cms_AddEdit.Name = "Menu1";
            this.cms_AddEdit.Size = new System.Drawing.Size(197, 85);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // cmsBay
            // 
            this.cmsBay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsBay.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsBay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEditBay});
            this.cmsBay.Name = "Menu1";
            this.cmsBay.Size = new System.Drawing.Size(181, 48);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::FactoryProductionRecorder.Properties.Resources.search0011;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(6, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(31, 31);
            this.panel5.TabIndex = 1302;
            // 
            // msReturnto
            // 
            this.msReturnto.AutoSize = false;
            this.msReturnto.BackColor = System.Drawing.Color.FloralWhite;
            this.msReturnto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.msReturnto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msReturnto.ForeColor = System.Drawing.Color.Black;
            this.msReturnto.Image = global::FactoryProductionRecorder.Properties.Resources.DL;
            this.msReturnto.Name = "msReturnto";
            this.msReturnto.Size = new System.Drawing.Size(274, 25);
            this.msReturnto.Text = "&ASSMPOS Return to";
            this.msReturnto.ToolTipText = "Move the Assembly to Another Station";
            this.msReturnto.Click += new System.EventHandler(this.msReturnto_Click);
            // 
            // tsForwardTo
            // 
            this.tsForwardTo.AutoSize = false;
            this.tsForwardTo.BackColor = System.Drawing.Color.FloralWhite;
            this.tsForwardTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsForwardTo.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsForwardTo.ForeColor = System.Drawing.Color.Black;
            this.tsForwardTo.Image = global::FactoryProductionRecorder.Properties.Resources.DR;
            this.tsForwardTo.Name = "tsForwardTo";
            this.tsForwardTo.Size = new System.Drawing.Size(274, 25);
            this.tsForwardTo.Text = "&ASSMPOS Forward to";
            this.tsForwardTo.ToolTipText = "Move the Assembly to Another Station";
            this.tsForwardTo.Click += new System.EventHandler(this.tsForwardTo_Click);
            // 
            // msRename
            // 
            this.msRename.AutoSize = false;
            this.msRename.BackColor = System.Drawing.Color.FloralWhite;
            this.msRename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.msRename.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msRename.ForeColor = System.Drawing.Color.IndianRed;
            this.msRename.Image = global::FactoryProductionRecorder.Properties.Resources.a_edit;
            this.msRename.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msRename.Name = "msRename";
            this.msRename.Size = new System.Drawing.Size(274, 25);
            this.msRename.Text = "\'&Rename\' ASSMPOS";
            this.msRename.ToolTipText = "Rename the Assembly Mark";
            this.msRename.Click += new System.EventHandler(this.msRename_Click);
            // 
            // tsEditBay
            // 
            this.tsEditBay.Name = "tsEditBay";
            this.tsEditBay.Size = new System.Drawing.Size(180, 22);
            this.tsEditBay.Text = "Edit Bay";
            this.tsEditBay.Click += new System.EventHandler(this.tsEditBay_Click);
            // 
            // SearchTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 608);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchTool";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "   Search Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchTool_FormClosing);
            this.Load += new System.EventHandler(this.SearchTool_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvNextStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            this.kryptonGroupBox3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.cms_AddEdit.ResumeLayout(false);
            this.cmsBay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DgvNextStation;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbPhase;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsAssmPos;
        private System.Windows.Forms.ToolStripStatusLabel tsDot;
        private System.Windows.Forms.ToolStripStatusLabel tsAssmQty;
        private System.Windows.Forms.ContextMenuStrip cms_AddEdit;
        private System.Windows.Forms.ToolStripMenuItem msReturnto;
        private System.Windows.Forms.ToolStripMenuItem msRename;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripMenuItem tsForwardTo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnSrch;
        private System.Windows.Forms.RadioButton rbAssembly;
        private System.Windows.Forms.CheckBox cbHistory;
        private System.Windows.Forms.ContextMenuStrip cmsBay;
        private System.Windows.Forms.ToolStripMenuItem tsEditBay;
    }
}