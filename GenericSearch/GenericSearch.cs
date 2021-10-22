using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSearch
{
    class GenericSearch<T> where T : IComparable
    {
        public T[] value;
        public T searchedKey;
        public GenericSearch(T[] value, T searchedKey)
        {
            this.value = value;
            this.searchedKey = searchedKey;
        }

        public bool search(T[] values, T key)
        {
            for (int i = 0; i < values.Length; i++)
            {


                if (values[i].Equals(key))
                {
                    return true;
                }

            }
            return false;
        }

        public void PrintSearchValue()
        {
            if (search(value, searchedKey))
            {
                Console.WriteLine("Found value : " + searchedKey);
            }
            else
            {
                Console.WriteLine(" Not Found " + searchedKey);

            }

        }
    }
}
