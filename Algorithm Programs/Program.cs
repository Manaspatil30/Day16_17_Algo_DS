using System;
using System.Collections.Generic;

namespace Algorithm_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number");
            Console.WriteLine("\n2 - Binary Search\n3 - Insertion Sort\n4 - Bubble Sort\n5 - Merge Sort\n6 - Anagram" +
                "\n7 - PrimeNum 0 -1000\n8 - Prime Palindrome");
            int command = int.Parse(Console.ReadLine());
            switch (command)
            {
                
                case 2:
                    string line = "Welcome to Binary Search";
                    var arr = line.Split(" ");
                    Console.WriteLine("Enter word to search");
                    string word = Console.ReadLine();
                    BinarySearch<string> bs = new BinarySearch<string>(arr, word);
                    bs.Search(0, arr.Length - 1);
                    break;

                case 3:
                    string test = "Welcome to insertion sort";
                    var testArr = test.Split(" ");
                    InsertionSort<string> insertionSort = new InsertionSort<string>();
                    insertionSort.sortingArray(testArr);
                    break;

                case 4:
                    List<int> intArr = new List<int> { 51, 75, 98, 44, 21, 36 };
                    BubbleSort bubbleSort = new BubbleSort();
                    Console.WriteLine("Before sorting");
                    bubbleSort.PrintArr(intArr);
                    bubbleSort.Search(intArr);
                    break;

                case 5:
                    MergeSort<string> mergeSort = new MergeSort<string>();
                    string test1 = "Welcome to Merge Sort";
                    var testArr1 = test1.Split(" ");
                    mergeSort.Sort(testArr1, 0, testArr1.Length - 1);
                    mergeSort.DisplayArry(testArr1);
                    break;

                case 6:
                    Anagram ana = new Anagram();
                    ana.GetAnagram();
                    break;
                    

                case 7:
                    primeNumber prime = new primeNumber();
                    prime.getPrime();
                    break;

                case 8:
                    Palindrome palin = new Palindrome();
                    palin.getPalindrome();
                    break;
            }

            

        }
    }
}
