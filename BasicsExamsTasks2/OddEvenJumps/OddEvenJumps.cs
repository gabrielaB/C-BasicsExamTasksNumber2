using System;
using System.Collections.Generic;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToLower().Replace(" ", "");
            int oddJumps = int.Parse(Console.ReadLine());
            int evenJumps = int.Parse(Console.ReadLine());

            int oddCounter = 0;
            ulong oddResult = 0;
            for (int i = 0; i <input.Length; i++)
            {

                if (i % 2 == 0)
                {
                    oddCounter++;
                    if (oddCounter % oddJumps == 0)
                    {
                        oddResult *= input[i];
                    }

                    else
                    {
                        oddResult += input[i];

                    }
                }
            }
            string oddSum = oddResult.ToString("X");
            Console.WriteLine("Odd: " + oddSum);

            int evenCounter = 0;
            ulong evenResult = 0;
            for(int i =0; i< input.Length; i++)
            {
                if( i % 2 !=0)
                {
                    evenCounter++;
                    if(evenCounter % evenJumps == 0)
                    {
                        evenResult *= input[i];
                    }
                    else
                    {
                        evenResult += input[i];
                    }

                }
            }
            string evenSum = evenResult.ToString("X");
            Console.WriteLine("Even: " + evenSum);

        }
    }
}

