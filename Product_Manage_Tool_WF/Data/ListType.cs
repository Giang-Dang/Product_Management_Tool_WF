

namespace Product_Manage_Tool_WF.Data
{
    public struct ListType
    {
        public Type[] List;
        public int CurrentLength;

        public ListType(Type[] _list, int _currentLength)
        {
            List = _list;
            CurrentLength = _currentLength;
        }


        public void Add(Type newType)
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
                List[removePosition] = default(Type);
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
                List[CurrentLength - 1] = default(Type);
                CurrentLength--;
            }
        }
        public int IndexOf(Type type)
        {
            for (int i = 0; i < CurrentLength; i++)
            {
                if (List[i].Equals(type))
                {
                    return i;
                }
            }
            return -1;
        }

        public int IndexOfTypeName(string thisTypeName)
        {
            for (int i = 0; i < CurrentLength; i++)
            {
                if (List[i].TypeName.Equals(thisTypeName))
                {
                    return i;
                }
            }
            return -1;
        }
        public int IndexOfTypeID(string thisTypeID)
        {
            for (int i = 0; i < CurrentLength; i++)
            {
                if (List[i].TypeName.Equals(thisTypeID))
                {
                    return i;
                }
            }
            return -1;
        }
        public bool IsContainsTypeID(string typeID)
        {
            for (int i = 0; i < CurrentLength; i++)
            {
                if (List[i].TypeID == typeID)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsContainsTypeName(string typeName)
        {
            for (int i = 0; i < CurrentLength; i++)
            {
                if (List[i].TypeName == typeName)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsContains(Type type)
        {
            for (int i = 0; i < CurrentLength; i++)
            {
                if (List[i].Equals(type))
                {
                    return true;
                }
            }
            return false;
        }

        public void Remove(Type removeType)
        {
            int removePosition = IndexOf(removeType);

            if (removePosition != -1)
            {
                RemoveAt(removePosition);
            }
        }
        public void Edit(Type oldType, Type newType)
        {
            if (IsContains(oldType))
            {
                List[IndexOf(oldType)] = newType;
            }
        }
        public void Clear()
        {
            List = new Type[Global.MAX_LIST_LENGTH];
            CurrentLength = 0;
        }
        public ListType FindAllProductHaveThisStringInTypeID(string thisString)
        {
            Type[] tempResultList = new Type[Global.MAX_LIST_LENGTH];
            int count = 0;
            for (int i = 0; i < CurrentLength; i++)
            {
                if (List[i].TypeID.Contains(thisString))
                {
                    tempResultList[count] = List[i];
                    count++;
                }
            }
            return new ListType(tempResultList, count);
        }
        public ListType FindAllProductHaveThisStringInTypeName(string thisString)
        {
            Type[] tempResultList = new Type[Global.MAX_LIST_LENGTH];
            int count = 0;
            for (int i = 0; i < CurrentLength; i++)
            {
                if (List[i].TypeName.Contains(thisString))
                {
                    tempResultList[count] = List[i];
                    count++;
                }
            }
            return new ListType(tempResultList, count);
        }

    }
}
