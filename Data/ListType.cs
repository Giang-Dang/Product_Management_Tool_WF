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
        public void RemoveAt(int removePosition)
        {
            //when element's index reach Max index
            if (removePosition == Global.MAX_LIST_LENGTH - 1)
            {
                List[removePosition] = default(string);
                CurrentLength--;
            }
            //
            else
            {
                for (int i = removePosition; i < CurrentLength - 1; i++)
                {
                    if (i + 1 <= Global.MAX_LIST_LENGTH)
                    {
                        List[i] = List[i + 1];
                    }
                }
                List[CurrentLength - 1] = default(string);
                CurrentLength--;
            }
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
        public void Remove(string removeType)
        {
            int removePosition = IndexOf(removeType);

            if (removePosition != -1)
            {
                RemoveAt(removePosition);
            }
        }
        public void Edit(string oldType, string newType)
        {
            List[IndexOf(oldType)] = newType;
        }
        public void Clear()
        {
            List = new string[Global.MAX_LIST_LENGTH];
            CurrentLength = 0;
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
