using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Manage_Tool_WF.Data
{
    public struct ListType
    {
        public string[] List;
        public int CurrentLength;

        public ListType(string[] _list, int _currentLength)
        {
            List = _list;
            CurrentLength = _currentLength;
        }


        public void Add(string newType)
        {
            if (CurrentLength < Global.MAX_LIST_LENGTH)
            {
                List[CurrentLength] = newType;
                CurrentLength++;
            }

        }
        public void Clear()
        {
            List = new string[Global.MAX_LIST_LENGTH];
            CurrentLength = 0;
        }
        public int IndexOf(string type)
        {
            for (int i = 0; i < CurrentLength; i++)
            {
                if (List[i] == type)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool IsContain(string type)
        {
            if(IndexOf(type) == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void GetListTypeFrom(ListProduct productList)
        {
            Clear();
            int count = 0;
            for (int i = 0; i < productList.CurrentLength; i++)
            {
                if (IndexOf(productList.List[i].ProductType) != -1)
                {
                    List[count] = productList.List[i].ProductType;
                    count++;
                }
            }
        }

    }
}
