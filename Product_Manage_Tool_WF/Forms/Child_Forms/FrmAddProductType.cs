using System;
using System.Windows.Forms;

using FormIO = Product_Manage_Tool_WF.IO.FormIO;
using ListProduct = Product_Manage_Tool_WF.Data.ListProduct;
using ListType = Product_Manage_Tool_WF.Data.ListType;
using Product = Product_Manage_Tool_WF.Data.Product;
using Type = Product_Manage_Tool_WF.Data.Type;
using Global = Product_Manage_Tool_WF.Data.Global;

namespace Product_Manage_Tool_WF.Forms.Child_Forms
{
    public partial class FrmAddProductType : Form
    {
        private static int TypeTableNewRowIndex,
                           TypeTableCurrentRowIndex;
        private static Button PreviousButton;
        private static Type   SelectingType,
                                EditingType;
        private static ListType SelectingTypeList;

        public void UpdateFromTypeTableToInputBoxes(DataGridView dataGridView)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dataGridView.Rows[dataGridView.CurrentCell.RowIndex];
                if (!row.IsNewRow)
                {
                    txbProductTypeID.Text = row.Cells[0].Value.ToString();
                    txbProductTypeName.Text = row.Cells[1].Value.ToString();
                }
            }
        }
        public FrmAddProductType()
        {
            InitializeComponent();
        }

        private void FrmAddProductType_Load(object sender, EventArgs e)
        {
            FormIO.UpdateTypeListToTable(Global.TypeList, dgwType);
            FormIO.EnableControls(pnlPrimaryControls);
            FormIO.DisableControls(pnlSecondaryControls);
        }

        

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            PreviousButton = (Button)sender;

            FormIO.DisableControls(pnlPrimaryControls);
            FormIO.EnableControls(pnlSecondaryControls);

            FormIO.ClearInputBoxes(tlpInput);
            txbProductTypeID.Focus();

            FormIO.DisableTables(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PreviousButton = (Button)sender;           

            if (FormIO.IsAllInputBoxEmpty(tlpInput))
            {
                MessageBox.Show(this, "Bạn chưa chọn loại hàng. Xin chọn loại hàng trước khi thực hiện sửa.", "Chưa Chọn Loại Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Type selectingType = new Type(txbProductTypeID.Text, txbProductTypeName.Text);
            if (!Global.TypeList.IsContains(selectingType))
            {
                MessageBox.Show(this, "Loại hàng " + txbProductTypeName.Text + " (Mã: " + txbProductTypeID.Text +
                ") không có trong có trong danh sách các loại hàng. Xin chọn lại ở bảng.", "Loại Hàng Không Tồn Tại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditingType = selectingType;

            FormIO.DisableControls(pnlPrimaryControls);
            FormIO.EnableControls(pnlSecondaryControls);

            FormIO.DisableTables(this);

            dgwType.Rows[TypeTableCurrentRowIndex].Selected = true;

            txbProductTypeID.Text = EditingType.TypeID;
            txbProductTypeID.SelectAll();
            txbProductTypeID.Focus();

            txbProductTypeName.Text = EditingType.TypeName;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (FormIO.IsAnyInputBoxEmpty(tlpInput))
            {
                MessageBox.Show(this, "Bạn chưa chọn loại hàng để xóa. Xin chọn lại!", "Chưa chọn loại hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Type selectingType = new Type(txbProductTypeID.Text, txbProductTypeName.Text);
            if (!Global.TypeList.IsContains(selectingType))
            {
                MessageBox.Show(this, "Loại hàng " + txbProductTypeName.Text + " (Mã: " + txbProductTypeID.Text +
                ") không có trong có trong danh sách các loại hàng. Xin chọn lại ở bảng.", "Loại Hàng Không Tồn Tại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgwType.Rows[TypeTableCurrentRowIndex].Selected = true;

            DialogResult ConfirmRemovingType = MessageBox.Show(this, "Bạn có chắc chắn xóa loại hàng " + txbProductTypeName.Text + " (Mã: " + txbProductTypeID.Text + 
                ") và tất cả các lô hàng thuộc loại hàng này không?", "Xác Nhận Xóa Loại Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ConfirmRemovingType == DialogResult.Yes)
            {
                Global.ProductList.RemoveAllProductInType(selectingType);
                Global.TypeList.Remove(selectingType);
                FormIO.UpdateTypeListToTable(Global.TypeList, dgwType);
                dgwProduct.Rows.Clear();
            }


            PreviousButton = (Button)sender;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if (PreviousButton == btnAddNew)
            {
                if (Global.TypeList.IsContainsTypeID(txbProductTypeID.Text))
                {
                    MessageBox.Show(this, "Mã loại hàng này đã có trong danh sách. Xin nhập mã loại hàng khác!", "Mã Loại Hàng Đã Tồn Tại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Global.TypeList.IsContainsTypeName(txbProductTypeName.Text))
                {
                    MessageBox.Show(this, "Tên loại hàng này đã có trong danh sách. Xin nhập tên khác!", "Tên loại Hàng Đã Tồn Tại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Type addingType = new Type(txbProductTypeID.Text, txbProductTypeName.Text);

                Global.TypeList.Add(addingType);

                FormIO.DisableControls(pnlSecondaryControls);
                FormIO.EnableControls(pnlPrimaryControls);

                FormIO.EnableTables(this);
                FormIO.UpdateTypeListToTable(Global.TypeList, dgwType);
                UpdateFromTypeTableToInputBoxes(dgwType);

            }

            if (PreviousButton == btnEdit)
            {
                Type newType = new Type(txbProductTypeID.Text, txbProductTypeName.Text);

                if (Global.TypeList.IsContains(newType))
                {
                    DialogResult confirmAddingNewType = MessageBox.Show(this, "Bạn có chắc chắn muốn sửa loại hàng " + EditingType.TypeName + " (Mã: " + EditingType.TypeID +
                        ") thành loại hàng "  + newType.TypeName + " (Mã: " + newType.TypeID + ") không?", "Sửa Loại Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmAddingNewType == DialogResult.No)
                    {
                        return;
                    } 
                }
                else
                {
                    DialogResult confirmAddingNewType = MessageBox.Show(this, "Loại hàng " + newType.TypeName + " (Mã: " + newType.TypeID +
                        ") chưa có trong dữ liệu. Bạn có chắc chắn muốn thêm mới loại hàng " + newType.TypeName + " (Mã: " + newType.TypeID +
                        ") và thay thế toàn bộ lô hàng có loại hàng " + EditingType.TypeName + " (Mã: " + EditingType.TypeID + ") bằng loại hàng "
                        + newType.TypeName + " (Mã: " + newType.TypeID + ") không?", "Loại Hàng Được Sửa Thành Loại Hàng Chưa Có Trong Danh Sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmAddingNewType == DialogResult.Yes)
                    {
                        Global.TypeList.Add(newType);
                    }
                    else
                    {
                        return;
                    }
                }
                if (Global.ProductList.FindAllProductBelongThisType(EditingType).CurrentLength > 0) //if there is a product belongs to editing type
                {
                    Global.ProductList.EditTypeForAllProductsHaveType(EditingType, newType);
                }

                FormIO.DisableControls(pnlSecondaryControls);
                FormIO.EnableControls(pnlPrimaryControls);

                FormIO.EnableTables(this);
                FormIO.UpdateTypeListToTable(Global.TypeList, dgwType);
                FormIO.UpdateProductListToTable(Global.ProductList.FindAllProductBelongThisType(newType), dgwProduct);
                UpdateFromTypeTableToInputBoxes(dgwType);       
            }

            PreviousButton = (Button)sender;
        }

        private void dgwType_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TypeTableNewRowIndex = e.RowIndex + 1;
        }

        private void dgwType_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            TypeTableCurrentRowIndex = e.RowIndex;
            if (e.RowIndex != TypeTableNewRowIndex)
            {
                TypeTableCurrentRowIndex = e.RowIndex;
                UpdateFromTypeTableToInputBoxes((DataGridView)sender);
                Type selectingType = new Type(txbProductTypeID.Text, txbProductTypeName.Text);
                ListProduct productListHaveSelectingType = Global.ProductList.FindAllProductBelongThisType(selectingType);
                FormIO.UpdateProductListToTable(productListHaveSelectingType, dgwProduct);
            }
            else
            {
                FormIO.ClearInputBoxes(tlpInput);
                dgwProduct.Rows.Clear();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormIO.DisableControls(pnlSecondaryControls);
            FormIO.EnableControls(pnlPrimaryControls);

            FormIO.EnableTables(this);
            FormIO.UpdateTypeListToTable(Global.TypeList, dgwType);
            UpdateFromTypeTableToInputBoxes(dgwType);

            PreviousButton = (Button)sender;
        }

        private void txbProductTypeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgwType.Enabled == false)
            {
                return;
            }

            SelectingTypeList = Global.TypeList.FindAllProductHaveThisStringInTypeName(txbProductTypeName.Text);
            SelectingTypeList = SelectingTypeList.FindAllProductHaveThisStringInTypeID(txbProductTypeID.Text);

            FormIO.UpdateTypeListToTable(SelectingTypeList, dgwType);
        }

        private void txbProductTypeName_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgwType.Enabled == false)
            {
                return;
            }

            SelectingTypeList = Global.TypeList.FindAllProductHaveThisStringInTypeName(txbProductTypeName.Text);
            SelectingTypeList = SelectingTypeList.FindAllProductHaveThisStringInTypeID(txbProductTypeID.Text);

            FormIO.UpdateTypeListToTable(SelectingTypeList, dgwType);
        }

        private void btnRefreshTypeTable_Click(object sender, EventArgs e)
        {
            FormIO.ClearInputBoxes(tlpInput);
            FormIO.UpdateTypeListToTable(Global.TypeList, dgwType);
            FormIO.EnableControls(pnlPrimaryControls);
            FormIO.DisableControls(pnlSecondaryControls);
        }

        private void txbProductTypeID_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txbProductTypeName_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
