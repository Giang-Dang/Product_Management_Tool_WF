using System;
using System.Globalization;
using System.Windows.Forms;

using FormIO = Product_Manage_Tool_WF.IO.FormIO;
using ListProduct = Product_Manage_Tool_WF.Data.ListProduct;
using ListType = Product_Manage_Tool_WF.Data.ListType;
using Product = Product_Manage_Tool_WF.Data.Product;

namespace Product_Manage_Tool_WF.Forms.Child_Forms
{
    public partial class FrmAddProduct : Form
    {
        private bool isAllTextBoxValidInput()
        {
            DateTime ExpiryDate;
            int ProductionYear;
            bool res = true;

            if (FormIO.IsAnyInputBoxEmpty(tlpInput))
            {
                MessageBox.Show(this, "Có trường dữ liệu trống. Xin nhập lại!", "Lỗi Nhập Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                ExpiryDate = DateTime.ParseExact(mtbExpiryDate.Text, "dd/M/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Dữ liệu Hạn Dùng nhập sai kiểu dữ liệu. Xin nhập lại! (dd/MM/yyyy)", "Lỗi Nhập Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
                return res;
            }

            if (!Int32.TryParse(mtbManufactureYear.Text, out ProductionYear))
            {
                MessageBox.Show(this, "Dữ liệu Năm Sản Xuất nhập sai kiểu dữ liệu. Xin nhập lại!", "Lỗi Nhập Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }

            if ((int)ExpiryDate.Year < ProductionYear)
            {
                MessageBox.Show(this, "Năm của hạn dùng sản phẩm phải lớn hơn năm sản xuất. Xin nhập lại!", "Lỗi Nhập Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            return res;
        }

        public FrmAddProduct()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            FormIO.DisableInputBox(tlpInput);

            FormIO.EnableControls(pnlPrimaryControls);
            FormIO.DisableControls(pnlSecondaryControls);
        }
    }
}
