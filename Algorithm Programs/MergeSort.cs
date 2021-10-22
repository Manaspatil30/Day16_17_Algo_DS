using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class MergeSort<T> where T:IComparable
    {
        internal void Merge(T[] arr,int startIndex, int middle, int endIndex)
        {
            int n1 = middle - startIndex + 1;
            int n2 = endIndex - middle;

            T[] leftArray = new T[n1];
            T[] rightArray = new T[n2];

            for(int l = 0; l<n1; l++)
            {
                leftArray[l] = arr[startIndex + l];
            }

            for(int m = 0; m < n2; m++)
            {
                rightArray[m] = arr[middle + 1 + m];
            }

            int i = 0;
            int j = 0;
            int k = startIndex;
            while (i < n1 && j < n2)
            {
                if (leftArray[i].CompareTo(rightArray[j]) < 0 || leftArray[i].Equals(rightArray[j]))
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }
        }

        internal void Sort(T[] arr, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                int middleIndex = startIndex + (endIndex - startIndex) / 2;
                Sort(arr, startIndex, middleIndex);
                Sort(arr, middleIndex + 1, endIndex);
                Merge(arr, startIndex, middleIndex, endIndex);
            }
        }

        internal void DisplayArry(T[] arr)
        {
            foreach (var temp in arr)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
