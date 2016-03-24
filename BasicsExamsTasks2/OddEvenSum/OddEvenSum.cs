using System;


namespace ConsoleApplication5
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            int diff = 0;
            for (int i = 0; i < 2 * n; i++)
            {
                int number = int.Parse(Console.ReadLine());


                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }
            diff = Math.Abs(evenSum - oddSum);
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes, sum={0}",evenSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}",diff);
            }
          
        }
    }
}
