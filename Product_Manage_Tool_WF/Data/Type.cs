using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Manage_Tool_WF.Data
{
    public struct Type
    {
        public string TypeID;
        public string TypeName;

        public Type(string _typeID, string _typeName)
        {
            TypeID = _typeID;
            TypeName = _typeName;
        }
    }
}
