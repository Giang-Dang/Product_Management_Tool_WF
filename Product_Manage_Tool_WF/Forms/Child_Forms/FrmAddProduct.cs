using System;
using System.Globalization;
using System.Windows.Forms;

using FormIO = Product_Manage_Tool_WF.IO.FormIO;
using ListProduct = Product_Manage_Tool_WF.Data.ListProduct;
using ListType = Product_Manage_Tool_WF.Data.ListType;
using Product = Product_Manage_Tool_WF.Data.Product;
using Global = Product_Manage_Tool_WF.Data.Global;

namespace Product_Manage_Tool_WF.Forms.Child_Forms
{
    public partial class FrmAddProduct : Form
    {
        private static int TableNewRowIndex,
                            TableCurrentRowIndex;
        private static Button PreviousButton;
        private bool IsAllTextBoxValidInput()
        {
            DateTime ExpiryDate;
            int ProductionYear;

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
                return false;
            }

            if (!Int32.TryParse(mtbManufactureYear.Text, out ProductionYear))
            {
                MessageBox.Show(this, "Dữ liệu Năm Sản Xuất nhập sai kiểu dữ liệu. Xin nhập lại!", "Lỗi Nhập Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if ((int)ExpiryDate.Year < ProductionYear)
            {
                MessageBox.Show(this, "Năm của hạn dùng sản phẩm phải lớn hơn năm sản xuất. Xin nhập lại!", "Lỗi Nhập Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void UpdateFromTableToInputBoxes(DataGridView dataGridView)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dataGridView.Rows[dataGridView.CurrentCell.RowIndex];
                if (!row.IsNewRow)
                {
                    txbProductID.Text = row.Cells[0].Value.ToString();
                    txbProductName.Text = row.Cells[1].Value.ToString();
                    mtbExpiryDate.Text = row.Cells[2].Value.ToString();
                    txbProductionCompany.Text = row.Cells[3].Value.ToString();
                    mtbManufactureYear.Text = row.Cells[4].Value.ToString();
                    cbbProductType.Text = row.Cells[5].Value.ToString();
                }
            }
        }
        private void AddNew(Product product)
        {
            if (Global.TypeList.IsContain(cbbProductType.Text))
            {
                Global.ProductList.Add(product);
                if (!Global.TypeList.IsContain(product.ProductType))
                {
                    Global.TypeList.Add(product.ProductType);
                }
                FormIO.UpdateProductListToTable(Global.ProductList, dgwProduct);
                //set recently added row to selecting row
                dgwProduct.Rows[TableNewRowIndex - 1].Selected = true;
                dgwProduct.CurrentCell = dgwProduct.Rows[TableNewRowIndex - 1].Cells[0];
            }
            else
            {
                DialogResult ConfirmAddProductionType = MessageBox.Show(this, "Loại hàng " + cbbProductType.Text + " chưa có trong dữ liệu. Bạn có muốn thêm loại hàng này không?", "Loại Hàng Mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ConfirmAddProductionType == DialogResult.Yes)
                {
                    Global.ProductList.Add(product);
                    if (!Global.TypeList.IsContain(product.ProductType))
                    {
                        Global.TypeList.Add(product.ProductType);
                    }
                    FormIO.UpdateProductListToTable(Global.ProductList, dgwProduct);
                    //set recently added row to selecting row
                    dgwProduct.Rows[TableNewRowIndex - 1].Selected = true;
                    dgwProduct.CurrentCell = dgwProduct.Rows[TableNewRowIndex - 1].Cells[0];

                }
                else
                {
                    MessageBox.Show(this, "Xin chọn lại loại hàng có trong danh sách", "Chọn Loại Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void Edit(Product product)
        {
            string oldType = Global.ProductList.List[TableCurrentRowIndex].ProductType;
            string newType = product.ProductType;
            if (newType != oldType)
            {
                ListProduct ListProductsBelongEdittingType = Global.ProductList.FindProductsHaveID(oldType);
                if (ListProductsBelongEdittingType.CurrentLength == 1)
                {
                    Global.TypeList.Edit(oldType, newType);
                }
                else
                {
                    if (!Global.TypeList.IsContain(newType))
                    {
                        Global.TypeList.Add(newType);
                    }
                }
            }

            Global.ProductList.EditAt(TableCurrentRowIndex, product);
            FormIO.UpdateProductListToTable(Global.ProductList, dgwProduct);
            //set recently edited row to selecting row
            dgwProduct.Rows[TableCurrentRowIndex].Selected = true;
            dgwProduct.CurrentCell = dgwProduct.Rows[TableCurrentRowIndex].Cells[0];
        }

        public FrmAddProduct()
        {
            InitializeComponent();
        }



        private void FrmAddProduct_Load(object sender, EventArgs e)
        {

            FormIO.DisableInputBoxes(tlpInput);

            FormIO.EnableControls(pnlPrimaryControls);
            FormIO.DisableControls(pnlSecondaryControls);

            //If ProductList has element, update this list to dgwProduct
            if(Global.ProductList.CurrentLength > 0)
            {
                FormIO.UpdateProductListToTable(Global.ProductList, dgwProduct);
            }

            
            if(dgwProduct != null)
            {
                UpdateFromTableToInputBoxes(dgwProduct);
            }
        }

        private void txbProductID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbProductName.Focus();
            }
        }

        private void txbProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mtbExpiryDate.Focus();
            }
        }

        private void mtbExpiryDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbProductionCompany.Focus();
            }
        }

        private void txbProductionCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mtbManufactureYear.Focus();
            }
        }

        private void mtbManufactureYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbbProductType.Focus();
            }
        }

        private void cbbProductType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirm.Focus();
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            PreviousButton = (Button)sender;
            FormIO.EnableInputBoxes(tlpInput);
            FormIO.ClearInputBoxes(tlpInput);
            txbProductID.Focus();

            FormIO.DisableControls(pnlPrimaryControls);
            FormIO.EnableControls(pnlSecondaryControls);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            PreviousButton = (Button)sender;
            if (FormIO.IsAllInputBoxEmpty(tlpInput))
            {
                MessageBox.Show(this, "Bạn chưa chọn dữ liệu từ bảng hoặc bạn đã chọn dữ liệu trống. Xin chọn lại!", "Lỗi Dữ Liệu Trống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormIO.EnableInputBoxes(tlpInput);
                FormIO.DisableControls(pnlPrimaryControls);
                FormIO.EnableControls(pnlSecondaryControls);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            PreviousButton = (Button)sender;
            if (FormIO.IsAllInputBoxEmpty(tlpInput)) //if no fields are selected
            {
                MessageBox.Show(this, "Bạn chưa chọn dữ liệu từ bảng hoặc bạn đã chọn dữ liệu trống. Xin chọn lại!", "Lỗi Dữ Liệu Trống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Global.ProductList.CurrentLength == 0)
            {
                MessageBox.Show(this, "Không có dữ liệu để xóa. Xin nhập dữ liệu!", "Lỗi Không Có Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            DialogResult confirmDeletingRow =
                MessageBox.Show(this, "Bạn có chắc chắn muốn xóa dữ liệu sau:" +
                "\nMã Hàng : " + dgwProduct.Rows[TableCurrentRowIndex].Cells[0].Value.ToString() +
                "\nTên Hàng: " + dgwProduct.Rows[TableCurrentRowIndex].Cells[1].Value.ToString() +
                "\nHạn Dùng: " + dgwProduct.Rows[TableCurrentRowIndex].Cells[2].Value.ToString() +
                "\nCông Ty Sản Xuất: " + dgwProduct.Rows[TableCurrentRowIndex].Cells[3].Value.ToString() +
                "\nNăm Sản Xuất: " + dgwProduct.Rows[TableCurrentRowIndex].Cells[4].Value.ToString() +
                "\nLoại Hàng: " + dgwProduct.Rows[TableCurrentRowIndex].Cells[5].Value.ToString()
                , "Xác nhận xóa lô hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmDeletingRow == DialogResult.Yes)
            {
                //remove element
                Global.ProductList.RemoveAt(TableCurrentRowIndex);
                //update table
                FormIO.UpdateProductListToTable(Global.ProductList, dgwProduct);
            }
            
        }

        
        private void btnConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirm_Click(this, new EventArgs());
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(IsAllTextBoxValidInput())
            {
                Product workingProduct = new Product(
                    txbProductID.Text,
                    txbProductName.Text,
                    mtbExpiryDate.Text,
                    txbProductionCompany.Text,
                    Int32.Parse(mtbManufactureYear.Text),
                    cbbProductType.Text
                    );

                if (Global.ProductList.IsContain(workingProduct))
                {
                    MessageBox.Show(this, "Lô hàng này đã tồn tại", "Lô hàng đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (PreviousButton == btnAddNew)
                    {
                        AddNew(workingProduct);
                    }
                    else if (PreviousButton == btnEdit)
                    {
                        Edit(workingProduct);
                    }
                    //set state for controls & input boxes
                    FormIO.DisableInputBoxes(tlpInput);
                    FormIO.EnableControls(pnlPrimaryControls);
                    FormIO.DisableControls(pnlSecondaryControls);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormIO.UpdateProductListToTable(Global.ProductList, dgwProduct);

            //set state for controls & input boxes
            FormIO.DisableInputBoxes(tlpInput);
            FormIO.EnableControls(pnlPrimaryControls);
            FormIO.DisableControls(pnlSecondaryControls);
        }

        private void cbbProductType_Click(object sender, EventArgs e)
        {
            FormIO.UpdateFromTypeListToComboBox(Global.TypeList, cbbProductType);
        }

        private void dgwProduct_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TableNewRowIndex = e.RowIndex + 1;
        }

        private void lblProductID_Click(object sender, EventArgs e)
        {
            Product product1 = new Product("1A", "dkfie", "20/07/2022", "HPG", 2020, "1");
            Product product2 = new Product("2A", "ghj", "20/12/2022", "DWG", 2019, "2");
            Product product3 = new Product("1B", "dfe", "12/07/2022", "TWM", 2020, "1");
            Product product4 = new Product("2B", "u6eg", "01/03/2024", "QPN", 2022, "2");
            Product product5 = new Product("1C", "ggr", "20/07/2022", "EMN", 2020, "1");
            Product product6 = new Product("3A", "dkfie", "25/07/2026", "TKN", 2024, "3");
            AddNew(product1);
            AddNew(product2);
            AddNew(product3);
            AddNew(product4);
            AddNew(product5);
            AddNew(product6);
        }

        private void dgwProduct_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex != TableNewRowIndex)
            {
                TableCurrentRowIndex = e.RowIndex;
                UpdateFromTableToInputBoxes((DataGridView)sender);
            }
            else
            {
                FormIO.ClearInputBoxes(tlpInput);
            }
        }
    }
}
