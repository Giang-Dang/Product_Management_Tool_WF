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
    public partial class FrmSearch : Form
    {
        private static ListProduct SearchResultProductList;
        public FrmSearch()
        {
            InitializeComponent();
        }
        private void FrmSearch_Load(object sender, EventArgs e)
        {
            cbbProductTypeName.DropDownStyle = ComboBoxStyle.DropDownList;
            FormIO.UpdateFromTypeListToComboBox(Global.TypeList, cbbProductTypeName);
        }

        private void btnClearSearchInfo_Click(object sender, EventArgs e)
        {
            FormIO.ClearInputBoxes(tlpInput);
            cbbProductTypeName.SelectedIndex = -1;
            lblResult.Text = "KẾT QUẢ:";
        }

        private void cbbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbProductTypeName.SelectedIndex == -1)
            {
                return;
            }

            int selectingTypeIndex = Global.TypeList.IndexOfTypeName(cbbProductTypeName.Text);
            Type selectingType = Global.TypeList.List[selectingTypeIndex];

            if (txbProductID.Text.Equals(String.Empty))
            {
                txbProductTypeID.Text = selectingType.TypeID;
            }
            txbProductID.Text = String.Empty;

            FormIO.UpdateProductListToTable(Global.ProductList.FindAllProductBelongThisType(selectingType), dgwProduct);
        }


        private void cbbProductType_Click(object sender, EventArgs e)
        {
            txbProductID.Text = String.Empty;
            FormIO.UpdateFromTypeListToComboBox(Global.TypeList, cbbProductTypeName);
        }
        private void cbbProductType_MouseClick(object sender, MouseEventArgs e)
        {
            cbbProductType_SelectedIndexChanged(sender, e);
        }


        private void txbProductTypeID_KeyUp(object sender, KeyEventArgs e)
        {
            //clear txbProductID to make the search algorithm easier
            txbProductID.Text = String.Empty;

            //Create searching Type List for updating cbbProductTypeName and using for generating product list
            ListType searchingTypeList;
            //clear cbbProductTypeName to make the search algorithm easier
            cbbProductTypeName.SelectedIndex = -1;
            if (txbProductTypeID.Text == String.Empty)
            {
                searchingTypeList = Global.TypeList;
            }
            else
            {
                searchingTypeList = Global.TypeList.FindAllProductHaveThisStringInTypeID(txbProductTypeID.Text);
            }
            FormIO.UpdateFromTypeListToComboBox(searchingTypeList, cbbProductTypeName);

            //Generate list of products that meet search result criteria
            SearchResultProductList.Clear();
            for(int i = 0; i < searchingTypeList.CurrentLength; i++)
            {
                Type workingType = searchingTypeList.List[i];
                ListProduct tempList = Global.ProductList.FindAllProductBelongThisType(workingType);
                for(int j = 0; j < tempList.CurrentLength; j++)
                {
                    SearchResultProductList.Add(tempList.List[j]);
                }
            }

            if(SearchResultProductList.CurrentLength == 0)
            {
                lblResult.Text = "KẾT QUẢ: KHÔNG TÌM THẤY LÔ HÀNG THỎA ĐIỀU KIỆN TÌM KIẾM";
            }
            FormIO.UpdateProductListToTable(SearchResultProductList, dgwProduct);
        }

        private void txbProductID_KeyUp(object sender, KeyEventArgs e)
        {
            ListProduct tempSearchList = SearchResultProductList.FindAllProductHaveThisStringInID(txbProductID.Text);
            if (tempSearchList.CurrentLength == 0)
            {
                lblResult.Text = "KẾT QUẢ: KHÔNG TÌM THẤY LÔ HÀNG THỎA ĐIỀU KIỆN TÌM KIẾM";
            }
            FormIO.UpdateProductListToTable(tempSearchList, dgwProduct);
        }
    }
}
