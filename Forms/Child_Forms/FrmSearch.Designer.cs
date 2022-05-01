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
            this.pnlPrimaryControls = new System.Windows.Forms.Panel();
            this.btnClearSearchInfo = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.tlpInput = new System.Windows.Forms.TableLayoutPanel();
            this.cbbProductType = new System.Windows.Forms.ComboBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.txbProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.ClnProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnProductname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnProductionCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnManufactureYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPrimaryControls.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.tlpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrimaryControls
            // 
            this.pnlPrimaryControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrimaryControls.AutoSize = true;
            this.pnlPrimaryControls.Controls.Add(this.btnClearSearchInfo);
            this.pnlPrimaryControls.Location = new System.Drawing.Point(16, 103);
            this.pnlPrimaryControls.Name = "pnlPrimaryControls";
            this.pnlPrimaryControls.Size = new System.Drawing.Size(730, 44);
            this.pnlPrimaryControls.TabIndex = 4;
            // 
            // btnClearSearchInfo
            // 
            this.btnClearSearchInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btnClearSearchInfo.FlatAppearance.BorderSize = 0;
            this.btnClearSearchInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearchInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearchInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClearSearchInfo.Location = new System.Drawing.Point(496, 1);
            this.btnClearSearchInfo.Name = "btnClearSearchInfo";
            this.btnClearSearchInfo.Size = new System.Drawing.Size(231, 38);
            this.btnClearSearchInfo.TabIndex = 2;
            this.btnClearSearchInfo.Text = "XÓA THÔNG TIN TÌM KIẾM";
            this.btnClearSearchInfo.UseVisualStyleBackColor = false;
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
            this.lblInfo1.Text = "Nhập mã hàng hay chọn loại hàng để tìm kiếm";
            this.lblInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo1.UseCompatibleTextRendering = true;
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
            this.tlpInput.Controls.Add(this.cbbProductType, 3, 0);
            this.tlpInput.Controls.Add(this.lblProductType, 2, 0);
            this.tlpInput.Controls.Add(this.txbProductID, 1, 0);
            this.tlpInput.Controls.Add(this.lblProductID, 0, 0);
            this.tlpInput.Location = new System.Drawing.Point(16, 62);
            this.tlpInput.Name = "tlpInput";
            this.tlpInput.RowCount = 1;
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpInput.Size = new System.Drawing.Size(732, 35);
            this.tlpInput.TabIndex = 6;
            // 
            // cbbProductType
            // 
            this.cbbProductType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbProductType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProductType.FormattingEnabled = true;
            this.cbbProductType.Location = new System.Drawing.Point(491, 3);
            this.cbbProductType.Name = "cbbProductType";
            this.cbbProductType.Size = new System.Drawing.Size(238, 28);
            this.cbbProductType.TabIndex = 12;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductType.Location = new System.Drawing.Point(341, 0);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(144, 35);
            this.lblProductType.TabIndex = 8;
            this.lblProductType.Text = "Loại Hàng:";
            this.lblProductType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbProductID
            // 
            this.txbProductID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductID.Location = new System.Drawing.Point(98, 3);
            this.txbProductID.Name = "txbProductID";
            this.txbProductID.Size = new System.Drawing.Size(237, 26);
            this.txbProductID.TabIndex = 7;
            this.txbProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductID.Location = new System.Drawing.Point(3, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(89, 35);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "Mã Hàng:";
            this.lblProductID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(16, 168);
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
            this.ClnProductType});
            this.dgwProduct.Location = new System.Drawing.Point(16, 190);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(730, 329);
            this.dgwProduct.TabIndex = 8;
            // 
            // ClnProductID
            // 
            this.ClnProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnProductID.HeaderText = "Mã";
            this.ClnProductID.Name = "ClnProductID";
            // 
            // ClnProductname
            // 
            this.ClnProductname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnProductname.HeaderText = "Tên Hàng";
            this.ClnProductname.Name = "ClnProductname";
            // 
            // ClnExpiryDate
            // 
            this.ClnExpiryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnExpiryDate.HeaderText = "Hạn Dùng";
            this.ClnExpiryDate.Name = "ClnExpiryDate";
            // 
            // ClnProductionCompany
            // 
            this.ClnProductionCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnProductionCompany.HeaderText = "Công Ty Sản Xuất";
            this.ClnProductionCompany.Name = "ClnProductionCompany";
            // 
            // ClnManufactureYear
            // 
            this.ClnManufactureYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnManufactureYear.HeaderText = "Năm Sản Xuất";
            this.ClnManufactureYear.Name = "ClnManufactureYear";
            // 
            // ClnProductType
            // 
            this.ClnProductType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnProductType.HeaderText = "Loại Hàng";
            this.ClnProductType.Name = "ClnProductType";
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
            this.Controls.Add(this.pnlPrimaryControls);
            this.Name = "FrmSearch";
            this.Text = "FrmSearch";
            this.pnlPrimaryControls.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.tlpInput.ResumeLayout(false);
            this.tlpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrimaryControls;
        private System.Windows.Forms.Button btnClearSearchInfo;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.TableLayoutPanel tlpInput;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txbProductID;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cbbProductType;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProductname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProductionCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnManufactureYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProductType;
    }
}