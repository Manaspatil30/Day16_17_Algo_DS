using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class BubbleSort
    {
        internal void PrintArr(List<int> arr)
        {
            foreach(var i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }

        internal void Search(List<int> arr)
        {
            for(int i =0; i < arr.Count - 1; i++)
            {
                for (int j = 0; j < arr.Count - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("After sorting");
            PrintArr(arr);
        }
    }
}
