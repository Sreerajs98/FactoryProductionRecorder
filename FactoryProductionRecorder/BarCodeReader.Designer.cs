namespace FactoryProductionRecorder
{
    partial class BarCodeReader
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSend = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DgvAssmData = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssemblyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhaseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhaseRev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssmMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssemblyQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrevQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOMQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssmUnitWT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtpikProd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kcbBaySel = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblBay = new System.Windows.Forms.Label();
            this.groupboxBOM = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvPendingData = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssmData)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbBaySel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupboxBOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupboxBOM.Panel)).BeginInit();
            this.groupboxBOM.Panel.SuspendLayout();
            this.groupboxBOM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(824, 7);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(130, 39);
            this.btnSend.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSend.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnSend.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnSend.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnSend.StateCommon.Border.Color2 = System.Drawing.Color.RosyBrown;
            this.btnSend.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.btnSend.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnSend.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSend.StateCommon.Border.Rounding = 3;
            this.btnSend.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.TabIndex = 1282;
            this.btnSend.Values.Image = global::FactoryProductionRecorder.Properties.Resources.Proceed;
            this.btnSend.Values.Text = "Save";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // DgvAssmData
            // 
            this.DgvAssmData.AllowUserToAddRows = false;
            this.DgvAssmData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAssmData.ColumnHeadersHeight = 25;
            this.DgvAssmData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvAssmData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AssemblyID,
            this.PhaseId,
            this.PhaseRev,
            this.AssmMark,
            this.AssmName,
            this.AssemblyQty,
            this.PrevQty,
            this.BOMQTY,
            this.AssmUnitWT,
            this.Date,
            this.Status,
            this.RefID});
            this.DgvAssmData.Location = new System.Drawing.Point(14, 51);
            this.DgvAssmData.Name = "DgvAssmData";
            this.DgvAssmData.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.DgvAssmData.RowHeadersWidth = 35;
            this.DgvAssmData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvAssmData.RowTemplate.Height = 30;
            this.DgvAssmData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAssmData.Size = new System.Drawing.Size(940, 311);
            this.DgvAssmData.StateCommon.Background.Color1 = System.Drawing.Color.DarkGray;
            this.DgvAssmData.StateCommon.Background.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.BottomMiddle;
            this.DgvAssmData.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.DgvAssmData.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(221)))), ((int)(((byte)(228)))));
            this.DgvAssmData.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DgvAssmData.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvAssmData.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Gainsboro;
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
            this.DgvAssmData.TabIndex = 1289;
            this.DgvAssmData.Tag = "0";
            this.DgvAssmData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAssmData_CellEndEdit);
            this.DgvAssmData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAssmData_CellEnter);
            this.DgvAssmData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAssmData_CellMouseDoubleClick);
            this.DgvAssmData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAssmData_CellValueChanged);
            this.DgvAssmData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvAssmData_RowPostPaint);
            this.DgvAssmData.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DgvAssmData_UserDeletedRow);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // AssemblyID
            // 
            this.AssemblyID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AssemblyID.FillWeight = 180F;
            this.AssemblyID.HeaderText = "AssemblyID";
            this.AssemblyID.Name = "AssemblyID";
            this.AssemblyID.Width = 180;
            // 
            // PhaseId
            // 
            this.PhaseId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PhaseId.DividerWidth = 5;
            this.PhaseId.FillWeight = 140F;
            this.PhaseId.HeaderText = "PhaseId";
            this.PhaseId.Name = "PhaseId";
            this.PhaseId.ReadOnly = true;
            this.PhaseId.Visible = false;
            this.PhaseId.Width = 140;
            // 
            // PhaseRev
            // 
            this.PhaseRev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PhaseRev.FillWeight = 60F;
            this.PhaseRev.HeaderText = "Rev";
            this.PhaseRev.Name = "PhaseRev";
            this.PhaseRev.ReadOnly = true;
            this.PhaseRev.Visible = false;
            this.PhaseRev.Width = 60;
            // 
            // AssmMark
            // 
            this.AssmMark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssmMark.DefaultCellStyle = dataGridViewCellStyle1;
            this.AssmMark.HeaderText = "Assm Mark";
            this.AssmMark.Name = "AssmMark";
            this.AssmMark.ReadOnly = true;
            // 
            // AssmName
            // 
            this.AssmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AssmName.DefaultCellStyle = dataGridViewCellStyle2;
            this.AssmName.HeaderText = "Assm Name";
            this.AssmName.Name = "AssmName";
            this.AssmName.ReadOnly = true;
            // 
            // AssemblyQty
            // 
            this.AssemblyQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssemblyQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.AssemblyQty.FillWeight = 70F;
            this.AssemblyQty.HeaderText = "CUR QTY";
            this.AssemblyQty.Name = "AssemblyQty";
            this.AssemblyQty.Width = 70;
            // 
            // PrevQty
            // 
            this.PrevQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F);
            this.PrevQty.DefaultCellStyle = dataGridViewCellStyle4;
            this.PrevQty.FillWeight = 70F;
            this.PrevQty.HeaderText = "OUT QTY";
            this.PrevQty.Name = "PrevQty";
            this.PrevQty.ReadOnly = true;
            this.PrevQty.Width = 70;
            // 
            // BOMQTY
            // 
            this.BOMQTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOMQTY.DefaultCellStyle = dataGridViewCellStyle5;
            this.BOMQTY.DividerWidth = 5;
            this.BOMQTY.FillWeight = 70F;
            this.BOMQTY.HeaderText = "BOM QTY";
            this.BOMQTY.Name = "BOMQTY";
            this.BOMQTY.ReadOnly = true;
            this.BOMQTY.Width = 70;
            // 
            // AssmUnitWT
            // 
            this.AssmUnitWT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.AssmUnitWT.DefaultCellStyle = dataGridViewCellStyle6;
            this.AssmUnitWT.DividerWidth = 5;
            this.AssmUnitWT.FillWeight = 80F;
            this.AssmUnitWT.HeaderText = "Unit Wt";
            this.AssmUnitWT.Name = "AssmUnitWT";
            this.AssmUnitWT.ReadOnly = true;
            this.AssmUnitWT.Width = 80;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Status
            // 
            this.Status.FillWeight = 65F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 65;
            // 
            // RefID
            // 
            this.RefID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RefID.FillWeight = 30F;
            this.RefID.HeaderText = "RefID";
            this.RefID.Name = "RefID";
            this.RefID.Visible = false;
            this.RefID.Width = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 1291;
            this.label1.Text = "Scan";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 765);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(967, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1293;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic);
            this.tslStatus.ForeColor = System.Drawing.Color.Red;
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(11, 19);
            this.tslStatus.Text = "..";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(179, 7);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(50, 39);
            this.BtnAdd.StateCommon.Back.Image = global::FactoryProductionRecorder.Properties.Resources.Add;
            this.BtnAdd.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.BtnAdd.StateCommon.Border.Color1 = System.Drawing.Color.Ivory;
            this.BtnAdd.StateCommon.Border.Color2 = System.Drawing.Color.Ivory;
            this.BtnAdd.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.BtnAdd.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.BtnAdd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnAdd.StateCommon.Border.Rounding = 5;
            this.BtnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.TabIndex = 1294;
            this.BtnAdd.Values.Text = "";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dtpikProd
            // 
            this.dtpikProd.CustomFormat = "dd-MMM-yyyy";
            this.dtpikProd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F);
            this.dtpikProd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpikProd.Location = new System.Drawing.Point(598, 10);
            this.dtpikProd.Name = "dtpikProd";
            this.dtpikProd.Size = new System.Drawing.Size(160, 32);
            this.dtpikProd.TabIndex = 1295;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(498, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 40);
            this.label2.TabIndex = 1296;
            this.label2.Text = "Production Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.kcbBaySel);
            this.panel1.Controls.Add(this.lblBay);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.DgvAssmData);
            this.panel1.Controls.Add(this.dtpikProd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 374);
            this.panel1.TabIndex = 1297;
            // 
            // kcbBaySel
            // 
            this.kcbBaySel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.kcbBaySel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.kcbBaySel.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kcbBaySel.DropDownHeight = 300;
            this.kcbBaySel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcbBaySel.DropDownWidth = 60;
            this.kcbBaySel.Items.AddRange(new object[] {
            "1",
            "4"});
            this.kcbBaySel.Location = new System.Drawing.Point(409, 11);
            this.kcbBaySel.MaxDropDownItems = 16;
            this.kcbBaySel.Name = "kcbBaySel";
            this.kcbBaySel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kcbBaySel.Size = new System.Drawing.Size(70, 30);
            this.kcbBaySel.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F);
            this.kcbBaySel.TabIndex = 1299;
            // 
            // lblBay
            // 
            this.lblBay.BackColor = System.Drawing.Color.LightGray;
            this.lblBay.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBay.Location = new System.Drawing.Point(341, 6);
            this.lblBay.Name = "lblBay";
            this.lblBay.Size = new System.Drawing.Size(147, 40);
            this.lblBay.TabIndex = 1298;
            this.lblBay.Text = "SAW - Bay:";
            this.lblBay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.groupboxBOM.Location = new System.Drawing.Point(14, 409);
            this.groupboxBOM.Name = "groupboxBOM";
            this.groupboxBOM.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // groupboxBOM.Panel
            // 
            this.groupboxBOM.Panel.Controls.Add(this.dgvPendingData);
            this.groupboxBOM.Size = new System.Drawing.Size(940, 350);
            this.groupboxBOM.StateCommon.Back.Color1 = System.Drawing.Color.SlateGray;
            this.groupboxBOM.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.groupboxBOM.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.groupboxBOM.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxBOM.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.groupboxBOM.TabIndex = 1300;
            this.groupboxBOM.Tag = "0";
            this.groupboxBOM.Values.Heading = "Received Data";
            this.groupboxBOM.Values.Image = global::FactoryProductionRecorder.Properties.Resources.Received;
            // 
            // dgvPendingData
            // 
            this.dgvPendingData.AllowDrop = true;
            this.dgvPendingData.AllowUserToAddRows = false;
            this.dgvPendingData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPendingData.ColumnHeadersHeight = 25;
            this.dgvPendingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPendingData.Location = new System.Drawing.Point(1, 3);
            this.dgvPendingData.Name = "dgvPendingData";
            this.dgvPendingData.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.dgvPendingData.RowHeadersWidth = 35;
            this.dgvPendingData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPendingData.RowTemplate.Height = 28;
            this.dgvPendingData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendingData.Size = new System.Drawing.Size(933, 319);
            this.dgvPendingData.StateCommon.Background.Color1 = System.Drawing.Color.DarkGray;
            this.dgvPendingData.StateCommon.Background.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.BottomMiddle;
            this.dgvPendingData.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvPendingData.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(221)))), ((int)(((byte)(228)))));
            this.dgvPendingData.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvPendingData.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPendingData.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.LightSlateGray;
            this.dgvPendingData.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.LightSteelBlue;
            this.dgvPendingData.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.dgvPendingData.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvPendingData.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgvPendingData.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPendingData.StateCommon.HeaderColumn.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvPendingData.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.dgvPendingData.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.dgvPendingData.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.DarkGray;
            this.dgvPendingData.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPendingData.TabIndex = 1290;
            this.dgvPendingData.Tag = "0";
            this.dgvPendingData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPendingData_RowPostPaint);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::FactoryProductionRecorder.Properties.Resources.barCode;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(10, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(31, 31);
            this.panel2.TabIndex = 1297;
            // 
            // BarCodeReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 791);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupboxBOM);
            this.Controls.Add(this.panel1);
            this.Name = "BarCodeReader";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.BarCodeReader_Load);
            this.Shown += new System.EventHandler(this.BarCodeReader_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssmData)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbBaySel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupboxBOM.Panel)).EndInit();
            this.groupboxBOM.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupboxBOM)).EndInit();
            this.groupboxBOM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSend;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DgvAssmData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnAdd;
        private System.Windows.Forms.DateTimePicker dtpikProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox groupboxBOM;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvPendingData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBay;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcbBaySel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssemblyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhaseRev;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssmMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssemblyQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrevQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOMQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssmUnitWT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefID;
    }
}