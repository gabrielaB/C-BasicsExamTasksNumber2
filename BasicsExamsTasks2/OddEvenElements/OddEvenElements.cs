using System;


namespace ConsoleApplication1
{
    class OddEvenElements
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[input.Length];
            decimal oddSum = 0;
            decimal  evenSum = 0;
            decimal oddMax = decimal.MinValue;
            decimal evenMax = decimal.MinValue;
            decimal oddMin = decimal.MaxValue;
            decimal evenMin = decimal.MaxValue;
            bool odd = true;
            for (int i = 0; i < input.Length; i++)
            {
                decimal currentNumber = numbers[i];
                if (odd)
                {
                    oddSum +=Math.Abs(currentNumber);
                    oddMin = Math.Min(oddMin, currentNumber);
                    oddMax = Math.Max(oddMax, currentNumber);
                }
                else
                {
                    evenSum += Math.Abs(currentNumber);
                    evenMin = Math.Min(evenMin, currentNumber);
                    evenMax = Math.Max(evenMax, currentNumber);

                }

            }

        }
    }
}
