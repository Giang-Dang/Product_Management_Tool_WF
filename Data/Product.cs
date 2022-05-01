using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Manage_Tool_WF.Data
{
    public struct Product
    {
        public string ProductID;
        public string ProductName;
        public string ExpiryDate;
        public string ProductionCompany;
        public string ProductType;
        public int ManufactureYear;

        public Product(string _productID, string _productName, string _expiryDate, string _productionCompany, int _manufactureYear, string _productType)
        {
            ProductID = _productID;
            ProductName = _productName;
            ExpiryDate = _expiryDate;
            ProductionCompany = _productionCompany;
            ProductType = _productType;
            ManufactureYear = _manufactureYear;
        }

        public static Product[] ShortenProductArray(Product[] array)
        {
            int newArrayLength = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(default(Product)))
                {
                    break;
                }
                else
                {
                    newArrayLength = i + 1;
                }
            }

            Product[] res = new Product[newArrayLength];
            for (int i = 0; i < newArrayLength; i++)
            {
                res[i] = array[i];
            }

            return res;
        }
    }
}
