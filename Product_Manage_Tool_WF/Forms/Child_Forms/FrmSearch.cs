using System;
using System.Windows.Forms;

using FormIO = Product_Manage_Tool_WF.IO.FormIO;
using ListProduct = Product_Manage_Tool_WF.Data.ListProduct;
using ListType = Product_Manage_Tool_WF.Data.ListType;
using Product = Product_Manage_Tool_WF.Data.Product;
using Global = Product_Manage_Tool_WF.Data.Global;

namespace Product_Manage_Tool_WF.Forms.Child_Forms
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }
        private void FrmSearch_Load(object sender, EventArgs e)
        {
            cbbProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            FormIO.UpdateFromTypeListToComboBox(Global.TypeList, cbbProductType);
        }

        private void btnClearSearchInfo_Click(object sender, EventArgs e)
        {
            FormIO.ClearInputBoxes(tlpInput);
            cbbProductType.SelectedIndex = -1;
            lblResult.Text = "KẾT QUẢ:";
        }

        private void cbbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormIO.UpdateProductListToTable(Global.ProductList.FindAllProductInType(cbbProductType.Text), dgwProduct);
        }


        private void cbbProductType_Click(object sender, EventArgs e)
        {
            txbProductID.Text = String.Empty;
            FormIO.UpdateFromTypeListToComboBox(Global.TypeList, cbbProductType);
        }
        private void cbbProductType_MouseClick(object sender, MouseEventArgs e)
        {
            FormIO.UpdateProductListToTable(Global.ProductList.FindAllProductInType(cbbProductType.Text), dgwProduct);
        }

        private void txbProductID_TextChanged(object sender, EventArgs e)
        {
            if (Global.ProductList.CurrentLength == 0)
            {
                lblResult.Text = "KẾT QUẢ: XIN NHẬP DỮ LIỆU VỀ SẢN PHẨM TRƯỚC KHI TÌM KIẾM!";
            }
            else
            {
                ListProduct searchList;

                if(cbbProductType.Text != String.Empty)
                {
                    searchList = Global.ProductList.FindAllProductInType(cbbProductType.Text);
                }
                else
                {
                    searchList = Global.ProductList;
                }

                ListProduct searchResult = searchList.FindProductsHaveID(txbProductID.Text);
                if (searchResult.CurrentLength == 0)
                {
                    lblResult.Text = "KẾT QUẢ: KHÔNG TÌM THẤY SẢN PHẨM!";
                    dgwProduct.Rows.Clear();
                }
                else
                {
                    lblResult.Text = "KẾT QUẢ:";
                    FormIO.UpdateProductListToTable(searchResult, dgwProduct);
                }
            }
        }
    }
}
