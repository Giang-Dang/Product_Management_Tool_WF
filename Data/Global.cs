

namespace Product_Manage_Tool_WF.Data
{
    public static class Global
    {
        public const int MAX_LIST_LENGTH = 1000;
        public static ListProduct ProductList = new ListProduct(new Product[Global.MAX_LIST_LENGTH], 0);
        public static ListType TypeList = new ListType(new string[Global.MAX_LIST_LENGTH], 0);
    }
}
