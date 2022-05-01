using System;
using System.Windows.Forms;

using FormIO = Product_Manage_Tool_WF.IO.FormIO;
using ListProduct = Product_Manage_Tool_WF.Data.ListProduct;
using ListType = Product_Manage_Tool_WF.Data.ListType;
using Product = Product_Manage_Tool_WF.Data.Product;
using Global = Product_Manage_Tool_WF.Data.Global;

namespace Product_Manage_Tool_WF.Forms.Child_Forms
{
    public partial class FrmAddProductType : Form
    {
        private static Button PreviousButton;
        private static string   SelectingType,
                                EditingType;
        public FrmAddProductType()
        {
            InitializeComponent();
        }

        private void FrmAddProductType_Load(object sender, EventArgs e)
        {
            FormIO.UpdateFromTypeListToComboBox(Global.TypeList, cbbProductType);
            FormIO.EnableControls(pnlPrimaryControls);
            FormIO.DisableControls(pnlSecondaryControls);
        }

        

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            PreviousButton = (Button)sender;

            FormIO.DisableControls(pnlPrimaryControls);
            FormIO.EnableControls(pnlSecondaryControls);

            cbbProductType.DropDownStyle = ComboBoxStyle.DropDown;
            cbbProductType.Text = String.Empty;
            cbbProductType.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cbbProductType.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Bạn chưa chọn loại hàng. Xin chọn loại hàng trước khi thực hiện sửa.", "Chưa chọn loại hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                EditingType = cbbProductType.Text;
                PreviousButton = (Button)sender;

                FormIO.DisableControls(pnlPrimaryControls);
                FormIO.EnableControls(pnlSecondaryControls);

                cbbProductType.DropDownStyle = ComboBoxStyle.DropDown;
                cbbProductType.Text = SelectingType;
                cbbProductType.SelectAll();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult ConfirmRemovingType = MessageBox.Show(this, "Bạn có chắc chắn xóa loại hàng này và tất cả các lô hàng thuộc loại hàng này không?", "Xác nhận xóa loại hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(ConfirmRemovingType == DialogResult.Yes)
            {
                string selectingType = cbbProductType.Text;
                Global.ProductList.RemoveAllProductInType(selectingType);
                Global.TypeList.Remove(selectingType);
                FormIO.UpdateFromTypeListToComboBox(Global.TypeList, cbbProductType);
                dgwProduct.Rows.Clear();
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Global.TypeList.IsContain(cbbProductType.Text))
            {
                MessageBox.Show(this, "Loại hàng này đã có trong danh sách. Xin nhập loại hàng khác!", "Loại hàng đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (PreviousButton == btnAddNew)
                {
                    Global.TypeList.Add(cbbProductType.Text);

                    FormIO.DisableControls(pnlSecondaryControls);
                    FormIO.EnableControls(pnlPrimaryControls);

                    cbbProductType.DropDownStyle = ComboBoxStyle.DropDownList;
                }

                if (PreviousButton == btnEdit)
                {
                    string newType = cbbProductType.Text;
                    Global.TypeList.Edit(EditingType, newType);
                    Global.ProductList.EditTypeForAllProductsHaveType(EditingType,newType);

                    FormIO.DisableControls(pnlSecondaryControls);
                    FormIO.EnableControls(pnlPrimaryControls);
                    FormIO.UpdateProductListToTable(Global.ProductList.FindAllProductInType(newType), dgwProduct);

                    cbbProductType.DropDownStyle = ComboBoxStyle.DropDownList;
                    FormIO.UpdateFromTypeListToComboBox(Global.TypeList, cbbProductType);
                    cbbProductType.SelectedIndex = cbbProductType.FindStringExact(newType);


                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbbProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            FormIO.DisableControls(pnlSecondaryControls);
            FormIO.EnableControls(pnlPrimaryControls);
        }

        

        private void cbbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectingType = cbbProductType.SelectedItem.ToString();
            ListProduct ListProductsBelongSelectingType = Global.ProductList.FindAllProductInType(SelectingType);
            FormIO.UpdateProductListToTable(ListProductsBelongSelectingType, dgwProduct);
        }
        private void cbbProductType_Click(object sender, EventArgs e)
        {
            FormIO.UpdateFromTypeListToComboBox(Global.TypeList, cbbProductType);
            if (cbbProductType.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                cbbProductType.SelectedIndex = cbbProductType.FindStringExact(SelectingType);
            }
            if (cbbProductType.DropDownStyle == ComboBoxStyle.DropDown)
            {
                cbbProductType.SelectAll();
            }
        }
    }
}
