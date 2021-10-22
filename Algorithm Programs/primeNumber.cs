using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class primeNumber
    {
        public void getPrime()
        {
            int start = 0;
            int end = 1000;

            Console.WriteLine("Prime Numbers in range os 0 - 1000 are :");

            for(int num = start; num<=end; num++)
            {
                int ctr = 0;

                for(int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if(ctr==0 && num!=1)
                    Console.WriteLine("{0}",num);
            }
            Console.WriteLine("\n");
        }
            
    }
}
