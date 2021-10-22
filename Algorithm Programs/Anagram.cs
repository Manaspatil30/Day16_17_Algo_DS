using System;

namespace Algorithm_Programs
{
    class Anagram
    {
        public void GetAnagram()
        {
            Console.WriteLine("Anagram Detection \n");

            Console.WriteLine("Enter first string:");
            string first = Console.ReadLine();
            char[] s1 = first.ToLower().ToCharArray();
            Console.WriteLine("Enter second string:");
            string second = Console.ReadLine();
            char[] s2 = second.ToLower().ToCharArray();



            Array.Sort(s1);
            Array.Sort(s2);
            string sort1 = new string(s1);
            string sort2 = new string(s2);

            if (sort1 == sort2)
            {
                Console.WriteLine(first + " and " + second + "  are Anagrams");
            }
            else
            {
                Console.WriteLine(first + " and " + second + "  are not Anagrams");

            }
        }

    }
}
