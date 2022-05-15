using System;
using System.Windows.Forms;


using ListProduct = Product_Manage_Tool_WF.Data.ListProduct;
using ListType = Product_Manage_Tool_WF.Data.ListType;

namespace Product_Manage_Tool_WF.IO
{
    public static class FormIO
    {
        public static bool IsAllInputBoxEmpty(TableLayoutPanel inputTableLayoutPanel)
        {
            foreach (var item in inputTableLayoutPanel.Controls)
            {
                if (item is TextBox)
                {
                    TextBox textBox = (TextBox)item;
                    if (textBox.Text != String.Empty)
                    {
                        return false;
                    }
                }

                if (item is MaskedTextBox)
                {
                    MaskedTextBox maskedTextBox = (MaskedTextBox)item;
                    if(maskedTextBox.Text != String.Empty)
                    {
                        return false;
                    }
                }
                
                if (item is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)item;
                    if (comboBox.Text != String.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsAnyInputBoxEmpty(TableLayoutPanel inputTableLayoutPanel)
        {
            foreach (var item in inputTableLayoutPanel.Controls)
            {
                if (item is TextBox)
                {
                    TextBox textBox = (TextBox)item;
                    if (textBox.Text == string.Empty)
                    {
                        return true;
                    }
                }

                if (item is MaskedTextBox)
                {
                    MaskedTextBox maskTextBox = (MaskedTextBox)item;
                    if(maskTextBox.Text == string.Empty)
                    {
                        return true;
                    }
                }

                if (item is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)item;
                    if(comboBox.Text == string.Empty)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static void EnableInputBoxes(TableLayoutPanel inputTableLayoutPanel)
        {
            foreach (Control control in inputTableLayoutPanel.Controls)
            {
                control.Enabled = true;
            }
        }
        public static void DisableInputBoxes(TableLayoutPanel inputTableLayoutPanel)
        {
            foreach (Control control in inputTableLayoutPanel.Controls)
            {
                if (control is Label)
                {
                    control.Enabled = true;
                }
                else
                {
                    control.Enabled = false;
                }
            }
        }

        public static void DisableTables(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is DataGridView)
                {
                    control.Enabled = false;
                }
            }
        }
        public static void EnableTables(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is DataGridView)
                {
                    control.Enabled = true;
                }
            }
        }
        public static void ClearInputBoxes(TableLayoutPanel inputTableLayoutPanel)
        {
            foreach (Control control in inputTableLayoutPanel.Controls)
            {
                if (control is Label)
                { }
                else
                {
                    control.Text = string.Empty;
                }
            }
        }
        public static void EnableControls(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                control.Enabled = true;
            }
        }

        public static void DisableControls(Panel panel)
        {
            foreach(Control control in panel.Controls)
            {
                control.Enabled = false;
            }
        }

        public static void UpdateProductListToTable(ListProduct productList, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < productList.CurrentLength; i++)
            {
                dataGridView.Rows.Add(
                    productList.List[i].ProductID,
                    productList.List[i].ProductName,
                    productList.List[i].ExpiryDate,
                    productList.List[i].ProductionCompany,
                    productList.List[i].ManufactureYear,
                    productList.List[i].ProductType.TypeID,
                    productList.List[i].ProductType.TypeName
                    ) ;
            }
        }

        public static void UpdateTypeListToTable(ListType typeList, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < typeList.CurrentLength; i++)
            {
                dataGridView.Rows.Add(
                    typeList.List[i].TypeID,
                    typeList.List[i].TypeName
                    );
            }
        }

        public static void UpdateFromTypeListToComboBox(ListType typeList, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            if(typeList.CurrentLength != 0)
            {
                for (int i = 0; i < typeList.CurrentLength; i++)
                {
                    comboBox.Items.Add(typeList.List[i].TypeName);
                }
            }
        }

    }
}
