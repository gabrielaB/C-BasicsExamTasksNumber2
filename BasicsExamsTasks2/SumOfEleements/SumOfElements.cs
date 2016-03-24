using System;


namespace ConsoleApplication4
{
    class SumOfElements
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int sum = 0;
            int biggestNumber = Int32.MinValue;
            int diff = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int number = int.Parse(input[i]);
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                
                }
                sum += number;
              
           }
            sum = (sum - biggestNumber);
            if ( biggestNumber==sum)
            {
                Console.WriteLine("Yes, sum={0}",Math.Abs(sum));
            }
            else
            {
                diff = biggestNumber - sum;
                Console.WriteLine("No, diff={0}",Math.Abs(diff));
            }
            

           
            
                
               
            }
        }
    }

