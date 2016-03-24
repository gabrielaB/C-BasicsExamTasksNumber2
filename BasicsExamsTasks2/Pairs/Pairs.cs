using System;


namespace ConsoleApplication2
{
    class Pairs
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split();
            int[] numbers = new int[inputNumbers.Length];
            int sum = int.MinValue;
            bool check = true;
            int previousSum = int.MinValue;
            int maxDiff = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(inputNumbers[i]);
            }

            for( int i = 0;i < numbers.Length; i+=2)
            {
                int firstNumbers = numbers[i];
                int secondNumber = numbers[i + 1];
                int currentSum = firstNumbers + secondNumber;
                if (i == 0)
                {
                    sum = currentSum;
                }
                else
            
                {
                    previousSum = numbers[i - 1] + numbers[i - 2];

                    int currentDiff = Math.Abs(currentSum - previousSum);
                   
                    {
                        maxDiff = currentDiff;
                    }
                        
                   if ( sum != currentSum)
                    {
                        check = false;

                    }
                }

            }
            if (check == true)
            {
                Console.WriteLine("Yes, value={0}", sum);
                    
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}",maxDiff);
            }
                
        }
    }
}
