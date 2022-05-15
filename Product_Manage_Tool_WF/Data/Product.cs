

namespace Product_Manage_Tool_WF.Data
{
    public struct Product
    {
        public string ProductID;
        public string ProductName;
        public string ExpiryDate;
        public string ProductionCompany;
        public Type ProductType;
        public int ManufactureYear;

        public Product(string _productID, string _productName, string _expiryDate, string _productionCompany, int _manufactureYear, Type _productType)
        {
            ProductID = _productID;
            ProductName = _productName;
            ExpiryDate = _expiryDate;
            ProductionCompany = _productionCompany;
            ProductType = _productType;
            ManufactureYear = _manufactureYear;
        }
    }
}
