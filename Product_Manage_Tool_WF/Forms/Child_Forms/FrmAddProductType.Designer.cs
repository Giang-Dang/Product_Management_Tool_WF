namespace Product_Manage_Tool_WF.Forms.Child_Forms
{
    partial class FrmAddProductType
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
            this.pnlSecondaryControls = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlPrimaryControls = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.tlpInput = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefreshTypeTable = new System.Windows.Forms.Button();
            this.txbProductTypeName = new System.Windows.Forms.TextBox();
            this.lblProductTypeID = new System.Windows.Forms.Label();
            this.txbProductTypeID = new System.Windows.Forms.TextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.ClnProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnProductname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnProductionCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnManufactureYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnProductTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwType = new System.Windows.Forms.DataGridView();
            this.ClnTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInfoProductTable = new System.Windows.Forms.Panel();
            this.lblInfoProductTable = new System.Windows.Forms.Label();
            this.pnlInfoInput = new System.Windows.Forms.Panel();
            this.lblInfoInput = new System.Windows.Forms.Label();
            this.pnlSecondaryControls.SuspendLayout();
            this.pnlPrimaryControls.SuspendLayout();
            this.tlpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwType)).BeginInit();
            this.pnlInfoProductTable.SuspendLayout();
            this.pnlInfoInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSecondaryControls
            // 
            this.pnlSecondaryControls.AutoSize = true;
            this.pnlSecondaryControls.Controls.Add(this.btnCancel);
            this.pnlSecondaryControls.Controls.Add(this.btnConfirm);
            this.pnlSecondaryControls.Location = new System.Drawing.Point(14, 196);
            this.pnlSecondaryControls.Name = "pnlSecondaryControls";
            this.pnlSecondaryControls.Size = new System.Drawing.Size(362, 45);
            this.pnlSecondaryControls.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Location = new System.Drawing.Point(247, 4);
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
            this.btnConfirm.Location = new System.Drawing.Point(129, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 38);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnlPrimaryControls
            // 
            this.pnlPrimaryControls.AutoSize = true;
            this.pnlPrimaryControls.Controls.Add(this.btnRemove);
            this.pnlPrimaryControls.Controls.Add(this.btnEdit);
            this.pnlPrimaryControls.Controls.Add(this.btnAddNew);
            this.pnlPrimaryControls.Location = new System.Drawing.Point(14, 150);
            this.pnlPrimaryControls.Name = "pnlPrimaryControls";
            this.pnlPrimaryControls.Size = new System.Drawing.Size(362, 44);
            this.pnlPrimaryControls.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRemove.Location = new System.Drawing.Point(247, 3);
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
            this.btnEdit.Location = new System.Drawing.Point(129, 3);
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
            this.btnAddNew.Location = new System.Drawing.Point(11, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(112, 38);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "THÊM MỚI";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // tlpInput
            // 
            this.tlpInput.ColumnCount = 3;
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpInput.Controls.Add(this.btnRefreshTypeTable, 2, 0);
            this.tlpInput.Controls.Add(this.txbProductTypeName, 0, 1);
            this.tlpInput.Controls.Add(this.lblProductTypeID, 0, 0);
            this.tlpInput.Controls.Add(this.txbProductTypeID, 1, 0);
            this.tlpInput.Controls.Add(this.lblProductType, 0, 1);
            this.tlpInput.Location = new System.Drawing.Point(14, 62);
            this.tlpInput.Name = "tlpInput";
            this.tlpInput.RowCount = 2;
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInput.Size = new System.Drawing.Size(362, 81);
            this.tlpInput.TabIndex = 5;
            // 
            // btnRefreshTypeTable
            // 
            this.btnRefreshTypeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btnRefreshTypeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefreshTypeTable.FlatAppearance.BorderSize = 0;
            this.btnRefreshTypeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshTypeTable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshTypeTable.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRefreshTypeTable.Image = global::Product_Manage_Tool_WF.Properties.Resources.icons8_synchronize_30;
            this.btnRefreshTypeTable.Location = new System.Drawing.Point(323, 3);
            this.btnRefreshTypeTable.Name = "btnRefreshTypeTable";
            this.btnRefreshTypeTable.Size = new System.Drawing.Size(36, 34);
            this.btnRefreshTypeTable.TabIndex = 11;
            this.btnRefreshTypeTable.UseVisualStyleBackColor = false;
            this.btnRefreshTypeTable.Click += new System.EventHandler(this.btnRefreshTypeTable_Click);
            // 
            // txbProductTypeName
            // 
            this.tlpInput.SetColumnSpan(this.txbProductTypeName, 2);
            this.txbProductTypeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbProductTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductTypeName.Location = new System.Drawing.Point(133, 43);
            this.txbProductTypeName.Name = "txbProductTypeName";
            this.txbProductTypeName.Size = new System.Drawing.Size(226, 26);
            this.txbProductTypeName.TabIndex = 14;
            this.txbProductTypeName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbProductTypeName_KeyUp);
            // 
            // lblProductTypeID
            // 
            this.lblProductTypeID.AutoSize = true;
            this.lblProductTypeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTypeID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductTypeID.Location = new System.Drawing.Point(3, 0);
            this.lblProductTypeID.Name = "lblProductTypeID";
            this.lblProductTypeID.Size = new System.Drawing.Size(124, 40);
            this.lblProductTypeID.TabIndex = 7;
            this.lblProductTypeID.Text = "Mã Loại Hàng:";
            // 
            // txbProductTypeID
            // 
            this.txbProductTypeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbProductTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductTypeID.Location = new System.Drawing.Point(133, 3);
            this.txbProductTypeID.Name = "txbProductTypeID";
            this.txbProductTypeID.Size = new System.Drawing.Size(184, 26);
            this.txbProductTypeID.TabIndex = 13;
            this.txbProductTypeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbProductTypeID_KeyUp);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductType.Location = new System.Drawing.Point(3, 40);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(124, 41);
            this.lblProductType.TabIndex = 6;
            this.lblProductType.Text = "Tên Loại Hàng:";
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
            this.dgwProduct.Location = new System.Drawing.Point(14, 291);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.ReadOnly = true;
            this.dgwProduct.Size = new System.Drawing.Size(625, 271);
            this.dgwProduct.TabIndex = 6;
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
            // dgwType
            // 
            this.dgwType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.dgwType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnTypeID,
            this.ClnTypeName});
            this.dgwType.Location = new System.Drawing.Point(382, 62);
            this.dgwType.Name = "dgwType";
            this.dgwType.ReadOnly = true;
            this.dgwType.Size = new System.Drawing.Size(257, 180);
            this.dgwType.TabIndex = 7;
            this.dgwType.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwType_CellMouseUp);
            this.dgwType.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgwType_RowsAdded);
            // 
            // ClnTypeID
            // 
            this.ClnTypeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClnTypeID.HeaderText = "Mã Loại Hàng";
            this.ClnTypeID.Name = "ClnTypeID";
            this.ClnTypeID.ReadOnly = true;
            this.ClnTypeID.Width = 91;
            // 
            // ClnTypeName
            // 
            this.ClnTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnTypeName.HeaderText = "Tên Loại Hàng";
            this.ClnTypeName.Name = "ClnTypeName";
            this.ClnTypeName.ReadOnly = true;
            // 
            // pnlInfoProductTable
            // 
            this.pnlInfoProductTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfoProductTable.AutoSize = true;
            this.pnlInfoProductTable.Controls.Add(this.lblInfoProductTable);
            this.pnlInfoProductTable.Location = new System.Drawing.Point(16, 254);
            this.pnlInfoProductTable.Name = "pnlInfoProductTable";
            this.pnlInfoProductTable.Size = new System.Drawing.Size(357, 35);
            this.pnlInfoProductTable.TabIndex = 8;
            // 
            // lblInfoProductTable
            // 
            this.lblInfoProductTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoProductTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfoProductTable.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoProductTable.ForeColor = System.Drawing.Color.White;
            this.lblInfoProductTable.Location = new System.Drawing.Point(0, 0);
            this.lblInfoProductTable.Margin = new System.Windows.Forms.Padding(0);
            this.lblInfoProductTable.Name = "lblInfoProductTable";
            this.lblInfoProductTable.Size = new System.Drawing.Size(357, 35);
            this.lblInfoProductTable.TabIndex = 0;
            this.lblInfoProductTable.Text = "Danh sách các mặt hàng";
            this.lblInfoProductTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfoProductTable.UseCompatibleTextRendering = true;
            // 
            // pnlInfoInput
            // 
            this.pnlInfoInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfoInput.AutoSize = true;
            this.pnlInfoInput.Controls.Add(this.lblInfoInput);
            this.pnlInfoInput.Location = new System.Drawing.Point(14, 7);
            this.pnlInfoInput.Name = "pnlInfoInput";
            this.pnlInfoInput.Size = new System.Drawing.Size(625, 49);
            this.pnlInfoInput.TabIndex = 10;
            // 
            // lblInfoInput
            // 
            this.lblInfoInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfoInput.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoInput.ForeColor = System.Drawing.Color.White;
            this.lblInfoInput.Location = new System.Drawing.Point(0, 0);
            this.lblInfoInput.Margin = new System.Windows.Forms.Padding(0);
            this.lblInfoInput.Name = "lblInfoInput";
            this.lblInfoInput.Size = new System.Drawing.Size(625, 49);
            this.lblInfoInput.TabIndex = 0;
            this.lblInfoInput.Text = "Nhấn thêm mới để thêm loại hàng mới. Nhập vào ô mã hoặc tên loại hàng để tìm kiếm" +
    ". Chọn loại hàng ở bảng để thao tác.";
            this.lblInfoInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfoInput.UseCompatibleTextRendering = true;
            // 
            // FrmAddProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(653, 574);
            this.Controls.Add(this.pnlInfoInput);
            this.Controls.Add(this.pnlInfoProductTable);
            this.Controls.Add(this.dgwType);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.tlpInput);
            this.Controls.Add(this.pnlSecondaryControls);
            this.Controls.Add(this.pnlPrimaryControls);
            this.Name = "FrmAddProductType";
            this.Text = "FrmAddProductType";
            this.Load += new System.EventHandler(this.FrmAddProductType_Load);
            this.pnlSecondaryControls.ResumeLayout(false);
            this.pnlPrimaryControls.ResumeLayout(false);
            this.tlpInput.ResumeLayout(false);
            this.tlpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwType)).EndInit();
            this.pnlInfoProductTable.ResumeLayout(false);
            this.pnlInfoInput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSecondaryControls;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel pnlPrimaryControls;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TableLayoutPanel tlpInput;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductTypeID;
        private System.Windows.Forms.TextBox txbProductTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProductname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProductionCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnManufactureYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnProductTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProductType;
        private System.Windows.Forms.DataGridView dgwType;
        private System.Windows.Forms.Panel pnlInfoProductTable;
        private System.Windows.Forms.Label lblInfoProductTable;
        private System.Windows.Forms.Panel pnlInfoInput;
        private System.Windows.Forms.Label lblInfoInput;
        private System.Windows.Forms.TextBox txbProductTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnTypeName;
        private System.Windows.Forms.Button btnRefreshTypeTable;
    }
}