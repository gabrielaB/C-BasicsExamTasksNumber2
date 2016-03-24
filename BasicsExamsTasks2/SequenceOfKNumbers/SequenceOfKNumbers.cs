using System;


namespace ConsoleApplication6
{
    class SequenceOfKNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            bool[] numbers = new bool[input.Length];
            bool foundNumbers = false;
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = true;
            }

            int k = int.Parse(Console.ReadLine());
            int equalCount = 1;
            int prev = int.Parse(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (foundNumbers)
                {
                    foundNumbers = false;
                    continue;
                }
                int number = int.Parse(input[i]);

                if (number == prev)
                {
                    equalCount++;
                }
                else
                {
                    equalCount = 1;
                    prev = int.Parse(input[i]);
                }
                if (equalCount == k)
                {
                    foundNumbers = true;

                    prev = int.Parse(input[i]);
                    for (int j =i;j > i - k; j--)
                    {
                        numbers[j] = false;

                    }
                    i += k - 2;
                }

            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i])
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}
