using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class InsertionSort<T>
    {
        public bool Insort(string val, string temp)
        {
            bool result = true;
            int valLength = val.Length;
            int tempLength = val.Length;
            if(valLength == tempLength)
            {
                var charValArr = val.ToCharArray();
                var charTempArr = temp.ToCharArray();
                if (charValArr[0].CompareTo(charTempArr[0]) < 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else if( valLength > tempLength)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }

        internal void sortingArray(T[] arr)
        {
            T[] tempArr = arr;
            int length = arr.Length;
            int flag = 0;
            T val;
            for(int i =0; i<length; i++)
            {
                Console.WriteLine(tempArr[i]);
            }
            Console.WriteLine();
            for (int i = 1; i < length; i++)
            {
                val = tempArr[i];
                flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (Insort(val.ToString(), tempArr[j].ToString()))
                    {
                        tempArr[j + 1] = tempArr[j];
                        j--;
                        tempArr[j + 1] = val;
                    }
                    else
                        flag = 1;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                Console.Write(tempArr[i]);
            }
            Console.WriteLine();
        }
    }
}
