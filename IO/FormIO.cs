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
        public static void EnableInputBox(TableLayoutPanel inputTableLayoutPanel)
        {
            foreach (Control control in inputTableLayoutPanel.Controls)
            {
                control.Enabled = true;
            }
        }
        public static void DisableInputBox(TableLayoutPanel inputTableLayoutPanel)
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

        }
    }
}
