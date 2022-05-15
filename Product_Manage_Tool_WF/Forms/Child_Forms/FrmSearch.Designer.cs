namespace Product_Manage_Tool_WF.Forms.Child_Forms
{
    partial class FrmSearch
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
            this.btnClearSearchInfo = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.tlpInput = new System.Windows.Forms.TableLayoutPanel();
            this.cbbProductTypeName = new System.Windows.Forms.ComboBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txbProductID = new System.Windows.Forms.TextBox();
            this.lblProductTypeID = new System.Windows.Forms.Label();
            this.txbProductTypeID = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.ClnProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnProductname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnProductionCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnManufactureYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnProductTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInfo.SuspendLayout();
            this.tlpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearSearchInfo
            // 
            this.btnClearSearchInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSearchInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnClearSearchInfo.FlatAppearance.BorderSize = 0;
            this.btnClearSearchInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearchInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearchInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClearSearchInfo.Location = new System.Drawing.Point(483, 42);
            this.btnClearSearchInfo.Name = "btnClearSearchInfo";
            this.btnClearSearchInfo.Size = new System.Drawing.Size(244, 33);
            this.btnClearSearchInfo.TabIndex = 2;
            this.btnClearSearchInfo.Text = "XÓA THÔNG TIN TÌM KIẾM";
            this.btnClearSearchInfo.UseVisualStyleBackColor = false;
            this.btnClearSearchInfo.Click += new System.EventHandler(this.btnClearSearchInfo_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfo.AutoSize = true;
            this.pnlInfo.Controls.Add(this.lblInfo1);
            this.pnlInfo.Location = new System.Drawing.Point(16, 12);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(730, 35);
            this.pnlInfo.TabIndex = 5;
            // 
            // lblInfo1
            // 
            this.lblInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfo1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.Color.White;
            this.lblInfo1.Location = new System.Drawing.Point(0, 0);
            this.lblInfo1.Margin = new System.Windows.Forms.Padding(0);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(730, 35);
            this.lblInfo1.TabIndex = 0;
            this.lblInfo1.Text = "Nhập mã hàng, mã loại hàng hoặc chọn loại hàng để tìm kiếm";
            this.lblInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo1.UseCompatibleTextRendering = true;
            // 
            // tlpInput
            // 
            this.tlpInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpInput.ColumnCount = 4;
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInput.Controls.Add(this.btnClearSearchInfo, 3, 1);
            this.tlpInput.Controls.Add(this.cbbProductTypeName, 3, 0);
            this.tlpInput.Controls.Add(this.lblProductType, 2, 0);
            this.tlpInput.Controls.Add(this.lblProductID, 0, 1);
            this.tlpInput.Controls.Add(this.txbProductID, 1, 1);
            this.tlpInput.Controls.Add(this.lblProductTypeID, 0, 0);
            this.tlpInput.Controls.Add(this.txbProductTypeID, 1, 0);
            this.tlpInput.Location = new System.Drawing.Point(16, 53);
            this.tlpInput.Name = "tlpInput";
            this.tlpInput.RowCount = 2;
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInput.Size = new System.Drawing.Size(730, 78);
            this.tlpInput.TabIndex = 6;
            // 
            // cbbProductTypeName
            // 
            this.cbbProductTypeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbProductTypeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProductTypeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbProductTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProductTypeName.FormattingEnabled = true;
            this.cbbProductTypeName.Location = new System.Drawing.Point(483, 3);
            this.cbbProductTypeName.Name = "cbbProductTypeName";
            this.cbbProductTypeName.Size = new System.Drawing.Size(244, 28);
            this.cbbProductTypeName.TabIndex = 12;
            this.cbbProductTypeName.SelectedIndexChanged += new System.EventHandler(this.cbbProductType_SelectedIndexChanged);
            this.cbbProductTypeName.Click += new System.EventHandler(this.cbbProductType_Click);
            this.cbbProductTypeName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbbProductType_MouseClick);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductType.Location = new System.Drawing.Point(383, 0);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(94, 39);
            this.lblProductType.TabIndex = 8;
            this.lblProductType.Text = "Loại Hàng:";
            this.lblProductType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductID.Location = new System.Drawing.Point(3, 39);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(124, 39);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "Mã Hàng:";
            this.lblProductID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbProductID
            // 
            this.txbProductID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductID.Location = new System.Drawing.Point(133, 42);
            this.txbProductID.Name = "txbProductID";
            this.txbProductID.Size = new System.Drawing.Size(244, 26);
            this.txbProductID.TabIndex = 7;
            this.txbProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbProductID_KeyUp);
            // 
            // lblProductTypeID
            // 
            this.lblProductTypeID.AutoSize = true;
            this.lblProductTypeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTypeID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductTypeID.Location = new System.Drawing.Point(3, 0);
            this.lblProductTypeID.Name = "lblProductTypeID";
            this.lblProductTypeID.Size = new System.Drawing.Size(124, 39);
            this.lblProductTypeID.TabIndex = 13;
            this.lblProductTypeID.Text = "Mã Loại Hàng:";
            this.lblProductTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbProductTypeID
            // 
            this.txbProductTypeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbProductTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductTypeID.Location = new System.Drawing.Point(133, 3);
            this.txbProductTypeID.Name = "txbProductTypeID";
            this.txbProductTypeID.Size = new System.Drawing.Size(244, 26);
            this.txbProductTypeID.TabIndex = 9;
            this.txbProductTypeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbProductTypeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbProductTypeID_KeyUp);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(12, 143);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(88, 19);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "KẾT QUẢ:";
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
            this.dgwProduct.Location = new System.Drawing.Point(16, 165);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.ReadOnly = true;
            this.dgwProduct.Size = new System.Drawing.Size(730, 354);
            this.dgwProduct.TabIndex = 8;
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
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(758, 531);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tlpInput);
            this.Controls.Add(this.pnlInfo);
            this.Name = "FrmSearch";
            this.Text = "FrmSearch";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.pnlInfo.ResumeLayout(false);
            this.tlpInput.ResumeLayout(false);
            this.tlpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClearSearchInfo;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.TableLayoutPanel tlpInput;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txbProductID;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cbbProductTypeName;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.Label lblProductTypeID;
        private System.Windows.Forms.TextBox txbProductTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProductname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProductionCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnManufactureYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnProductTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProductType;
    }
}