using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class BinarySearch<T> where T : IComparable
    {
        private string[] str;
        private string word;
        
        public BinarySearch(string[]arr,string word)
        {
            this.str = arr;
            this.word = word;
            Array.Sort(this.str);
        }

        internal void Search(int startIndex, int endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (str[midIndex].Equals(word))
            {
                Console.WriteLine("{0} found", word);
            }
            else if (startIndex == endIndex)
            {
                Console.WriteLine("{0} not found", word);
            }
            else if (str[midIndex].CompareTo(word) > 0)
            {
                Search(0, midIndex);
            }
            else if (str[midIndex].CompareTo(word) < 0)
            {
                Search(midIndex, endIndex);
            }
            else
            {
                Console.WriteLine("Not Found"); 
            }
        }
    }
}
