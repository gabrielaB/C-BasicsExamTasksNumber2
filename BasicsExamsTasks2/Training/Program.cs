using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[input.Length];
            int currentElement;
            int nextElement;
            int temp = 0;

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);

            }
            for (int i = 0; i < numbers.Length; i++)
            {
                currentElement = i;
                nextElement = i + 1;
                temp = currentElement;
                currentElement = nextElement;
                nextElement = temp;

                foreach (int element in numbers)
                {
                    Console.WriteLine(element);
                }
            }


            //    public static void SwapPossition(int[] numbers, int currentNumber, int nextNumber)

            //{
            //    int temp = numbers[currentNumber];
            //    numbers[currentNumber] = numbers[nextNumber];
            //    numbers[nextNumber] = temp;
            //}

        }


    }
}
          
        

    


