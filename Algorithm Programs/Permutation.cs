using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Permutation
    {
        public static void permute(string str , int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for(int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
            
        }

        public static string swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
