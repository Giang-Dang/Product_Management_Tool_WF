using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Manage_Tool_WF.Data
{
    public class Product
    {
        public string productID;
        public string productName;
        public string expiryDate;
        public string productCompany;
        public string productType;
        public int manufactureYear;

        public Product(string _productID, string _productName, string _expiryDate, string _productCompany, int _manufactureYear, string _productType)
        {
            productID = _productID;
            productName = _productName;
            expiryDate = _expiryDate;
            productCompany = _productCompany;
            productType = _productType;
            manufactureYear = _manufactureYear;
        }
    }
}
