namespace Product_Manage_Tool_WF.Forms.Child_Forms
{
    partial class FrmAddProduct
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
            this.tlpInput = new System.Windows.Forms.TableLayoutPanel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblManufactureYear = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductionCompany = new System.Windows.Forms.Label();
            this.txbProductID = new System.Windows.Forms.TextBox();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.txbProductionCompany = new System.Windows.Forms.TextBox();
            this.mtbManufactureYear = new System.Windows.Forms.MaskedTextBox();
            this.mtbExpiryDate = new System.Windows.Forms.MaskedTextBox();
            this.cbbProductTypeName = new System.Windows.Forms.ComboBox();
            this.pnlPrimaryControls = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pnlSecondaryControls = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.lblProductTypeID = new System.Windows.Forms.Label();
            this.txbProductTypeID = new System.Windows.Forms.TextBox();
            this.ClnProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnProductname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnProductionCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnManufactureYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnProductTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpInput.SuspendLayout();
            this.pnlPrimaryControls.SuspendLayout();
            this.pnlSecondaryControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpInput
            // 
            this.tlpInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpInput.ColumnCount = 4;
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInput.Controls.Add(this.txbProductTypeID, 3, 5);
            this.tlpInput.Controls.Add(this.lblProductTypeID, 2, 5);
            this.tlpInput.Controls.Add(this.lblProductName, 0, 2);
            this.tlpInput.Controls.Add(this.lblExpiryDate, 0, 3);
            this.tlpInput.Controls.Add(this.lblManufactureYear, 2, 2);
            this.tlpInput.Controls.Add(this.lblProductType, 2, 3);
            this.tlpInput.Controls.Add(this.lblProductID, 0, 1);
            this.tlpInput.Controls.Add(this.lblProductionCompany, 2, 1);
            this.tlpInput.Controls.Add(this.txbProductID, 1, 1);
            this.tlpInput.Controls.Add(this.txbProductName, 1, 2);
            this.tlpInput.Controls.Add(this.txbProductionCompany, 3, 1);
            this.tlpInput.Controls.Add(this.mtbManufactureYear, 3, 2);
            this.tlpInput.Controls.Add(this.mtbExpiryDate, 1, 3);
            this.tlpInput.Controls.Add(this.cbbProductTypeName, 3, 3);
            this.tlpInput.Location = new System.Drawing.Point(16, 9);
            this.tlpInput.Name = "tlpInput";
            this.tlpInput.RowCount = 6;
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpInput.Size = new System.Drawing.Size(730, 148);
            this.tlpInput.TabIndex = 0;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductName.Location = new System.Drawing.Point(3, 37);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(89, 35);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Tên Hàng:";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExpiryDate.Enabled = false;
            this.lblExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblExpiryDate.Location = new System.Drawing.Point(3, 72);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(89, 35);
            this.lblExpiryDate.TabIndex = 2;
            this.lblExpiryDate.Text = "Hạn Dùng";
            this.lblExpiryDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblManufactureYear
            // 
            this.lblManufactureYear.AutoSize = true;
            this.lblManufactureYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblManufactureYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufactureYear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblManufactureYear.Location = new System.Drawing.Point(340, 37);
            this.lblManufactureYear.Name = "lblManufactureYear";
            this.lblManufactureYear.Size = new System.Drawing.Size(144, 35);
            this.lblManufactureYear.TabIndex = 4;
            this.lblManufactureYear.Text = "Năm Sản Xuất:";
            this.lblManufactureYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductType.Location = new System.Drawing.Point(340, 72);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(144, 35);
            this.lblProductType.TabIndex = 5;
            this.lblProductType.Text = "Loại Hàng:";
            this.lblProductType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductID.Location = new System.Drawing.Point(3, 2);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(89, 35);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Mã Hàng:";
            this.lblProductID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProductID.Click += new System.EventHandler(this.lblProductID_Click);
            // 
            // lblProductionCompany
            // 
            this.lblProductionCompany.AutoSize = true;
            this.lblProductionCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductionCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductionCompany.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductionCompany.Location = new System.Drawing.Point(340, 2);
            this.lblProductionCompany.Name = "lblProductionCompany";
            this.lblProductionCompany.Size = new System.Drawing.Size(144, 35);
            this.lblProductionCompany.TabIndex = 3;
            this.lblProductionCompany.Text = "Công Ty Sản Xuất:";
            this.lblProductionCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbProductID
            // 
            this.txbProductID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductID.Location = new System.Drawing.Point(98, 5);
            this.txbProductID.Name = "txbProductID";
            this.txbProductID.Size = new System.Drawing.Size(236, 26);
            this.txbProductID.TabIndex = 6;
            this.txbProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbProductID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbProductID_KeyDown);
            // 
            // txbProductName
            // 
            this.txbProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductName.Location = new System.Drawing.Point(98, 40);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.Size = new System.Drawing.Size(236, 26);
            this.txbProductName.TabIndex = 7;
            this.txbProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbProductName_KeyDown);
            // 
            // txbProductionCompany
            // 
            this.txbProductionCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbProductionCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductionCompany.Location = new System.Drawing.Point(490, 5);
            this.txbProductionCompany.Name = "txbProductionCompany";
            this.txbProductionCompany.Size = new System.Drawing.Size(237, 26);
            this.txbProductionCompany.TabIndex = 8;
            this.txbProductionCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbProductionCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbProductionCompany_KeyDown);
            // 
            // mtbManufactureYear
            // 
            this.mtbManufactureYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtbManufactureYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbManufactureYear.Location = new System.Drawing.Point(490, 40);
            this.mtbManufactureYear.Mask = "0000";
            this.mtbManufactureYear.Name = "mtbManufactureYear";
            this.mtbManufactureYear.Size = new System.Drawing.Size(237, 26);
            this.mtbManufactureYear.TabIndex = 9;
            this.mtbManufactureYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbManufactureYear.ValidatingType = typeof(int);
            this.mtbManufactureYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbManufactureYear_KeyDown);
            // 
            // mtbExpiryDate
            // 
            this.mtbExpiryDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtbExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbExpiryDate.Location = new System.Drawing.Point(98, 75);
            this.mtbExpiryDate.Mask = "00/00/0000";
            this.mtbExpiryDate.Name = "mtbExpiryDate";
            this.mtbExpiryDate.Size = new System.Drawing.Size(236, 26);
            this.mtbExpiryDate.TabIndex = 10;
            this.mtbExpiryDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbExpiryDate.ValidatingType = typeof(System.DateTime);
            this.mtbExpiryDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbExpiryDate_KeyDown);
            // 
            // cbbProductTypeName
            // 
            this.cbbProductTypeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbProductTypeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbProductTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProductTypeName.FormattingEnabled = true;
            this.cbbProductTypeName.Location = new System.Drawing.Point(490, 75);
            this.cbbProductTypeName.Name = "cbbProductTypeName";
            this.cbbProductTypeName.Size = new System.Drawing.Size(237, 28);
            this.cbbProductTypeName.TabIndex = 11;
            this.cbbProductTypeName.SelectedIndexChanged += new System.EventHandler(this.cbbProductType_SelectedIndexChanged);
            this.cbbProductTypeName.Click += new System.EventHandler(this.cbbProductType_Click);
            this.cbbProductTypeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbProductType_KeyDown);
            // 
            // pnlPrimaryControls
            // 
            this.pnlPrimaryControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrimaryControls.AutoSize = true;
            this.pnlPrimaryControls.Controls.Add(this.btnRemove);
            this.pnlPrimaryControls.Controls.Add(this.btnEdit);
            this.pnlPrimaryControls.Controls.Add(this.btnAddNew);
            this.pnlPrimaryControls.Location = new System.Drawing.Point(16, 163);
            this.pnlPrimaryControls.Name = "pnlPrimaryControls";
            this.pnlPrimaryControls.Size = new System.Drawing.Size(730, 44);
            this.pnlPrimaryControls.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRemove.Location = new System.Drawing.Point(615, 1);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 38);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "XÓA";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.Location = new System.Drawing.Point(498, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 38);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "SỬA";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddNew.Location = new System.Drawing.Point(380, 1);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(112, 38);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "THÊM MỚI";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pnlSecondaryControls
            // 
            this.pnlSecondaryControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSecondaryControls.AutoSize = true;
            this.pnlSecondaryControls.Controls.Add(this.btnCancel);
            this.pnlSecondaryControls.Controls.Add(this.btnConfirm);
            this.pnlSecondaryControls.Location = new System.Drawing.Point(16, 209);
            this.pnlSecondaryControls.Name = "pnlSecondaryControls";
            this.pnlSecondaryControls.Size = new System.Drawing.Size(730, 45);
            this.pnlSecondaryControls.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Location = new System.Drawing.Point(615, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfirm.Location = new System.Drawing.Point(498, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 38);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            this.btnConfirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnConfirm_KeyDown);
            // 
            // dgwProduct
            // 
            this.dgwProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnProductID,
            this.ClnProductname,
            this.ClnExpiryDate,
            this.ClnProductionCompany,
            this.ClnManufactureYear,
            this.clnProductTypeID,
            this.ClnProductType});
            this.dgwProduct.Location = new System.Drawing.Point(16, 257);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.ReadOnly = true;
            this.dgwProduct.Size = new System.Drawing.Size(730, 262);
            this.dgwProduct.TabIndex = 3;
            this.dgwProduct.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwProduct_CellMouseUp);
            this.dgwProduct.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgwProduct_RowsAdded);
            // 
            // lblProductTypeID
            // 
            this.lblProductTypeID.AutoSize = true;
            this.lblProductTypeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTypeID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductTypeID.Location = new System.Drawing.Point(340, 109);
            this.lblProductTypeID.Name = "lblProductTypeID";
            this.lblProductTypeID.Size = new System.Drawing.Size(144, 39);
            this.lblProductTypeID.TabIndex = 6;
            this.lblProductTypeID.Text = "Mã Loại Hàng:";
            this.lblProductTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbProductTypeID
            // 
            this.txbProductTypeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbProductTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductTypeID.Location = new System.Drawing.Point(490, 112);
            this.txbProductTypeID.Name = "txbProductTypeID";
            this.txbProductTypeID.ReadOnly = true;
            this.txbProductTypeID.Size = new System.Drawing.Size(237, 26);
            this.txbProductTypeID.TabIndex = 9;
            this.txbProductTypeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClnProductID
            // 
            this.ClnProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClnProductID.HeaderText = "Mã";
            this.ClnProductID.Name = "ClnProductID";
            this.ClnProductID.ReadOnly = true;
            this.ClnProductID.Width = 47;
            // 
            // ClnProductname
            // 
            this.ClnProductname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnProductname.HeaderText = "Tên Hàng";
            this.ClnProductname.Name = "ClnProductname";
            this.ClnProductname.ReadOnly = true;
            // 
            // ClnExpiryDate
            // 
            this.ClnExpiryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClnExpiryDate.HeaderText = "Hạn Dùng";
            this.ClnExpiryDate.Name = "ClnExpiryDate";
            this.ClnExpiryDate.ReadOnly = true;
            this.ClnExpiryDate.Width = 75;
            // 
            // ClnProductionCompany
            // 
            this.ClnProductionCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnProductionCompany.HeaderText = "Công Ty Sản Xuất";
            this.ClnProductionCompany.Name = "ClnProductionCompany";
            this.ClnProductionCompany.ReadOnly = true;
            // 
            // ClnManufactureYear
            // 
            this.ClnManufactureYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClnManufactureYear.HeaderText = "Năm Sản Xuất";
            this.ClnManufactureYear.Name = "ClnManufactureYear";
            this.ClnManufactureYear.ReadOnly = true;
            this.ClnManufactureYear.Width = 93;
            // 
            // clnProductTypeID
            // 
            this.clnProductTypeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnProductTypeID.HeaderText = "Mã Loại Hàng";
            this.clnProductTypeID.Name = "clnProductTypeID";
            this.clnProductTypeID.ReadOnly = true;
            this.clnProductTypeID.Width = 91;
            // 
            // ClnProductType
            // 
            this.ClnProductType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnProductType.HeaderText = "Loại Hàng";
            this.ClnProductType.Name = "ClnProductType";
            this.ClnProductType.ReadOnly = true;
            // 
            // FrmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(758, 531);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.pnlSecondaryControls);
            this.Controls.Add(this.pnlPrimaryControls);
            this.Controls.Add(this.tlpInput);
            this.Name = "FrmAddProduct";
            this.Text = "FrmAddProduct";
            this.Load += new System.EventHandler(this.FrmAddProduct_Load);
            this.tlpInput.ResumeLayout(false);
            this.tlpInput.PerformLayout();
            this.pnlPrimaryControls.ResumeLayout(false);
            this.pnlSecondaryControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpInput;
        private System.Windows.Forms.Panel pnlPrimaryControls;
        private System.Windows.Forms.Panel pnlSecondaryControls;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblManufactureYear;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductionCompany;
        private System.Windows.Forms.TextBox txbProductID;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.TextBox txbProductionCompany;
        private System.Windows.Forms.MaskedTextBox mtbManufactureYear;
        private System.Windows.Forms.MaskedTextBox mtbExpiryDate;
        private System.Windows.Forms.ComboBox cbbProductTypeName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txbProductTypeID;
        private System.Windows.Forms.Label lblProductTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProductname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProductionCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnManufactureYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnProductTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProductType;
    }
}