using System;
using System.Text.RegularExpressions;





     public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int lettersSum = 0;
            int symbolsSum = 0;
            int numbersSum = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                input = input.ToUpper();
            input = Regex.Replace(input, "\\s+", "");

            for (int j = 0; j < input.Length; j++)
                {
                    char symbol = input[j];

                    if (symbol >= 'A' && symbol <= 'Z')
                    {
                        lettersSum += (symbol - 'A' + 1) * 10;
                    }
                    else if (symbol >= '0' && symbol <= '9')
                    {
                        numbersSum += (symbol - '0') * 20;
                    }
                    else
                    {
                        symbolsSum += 200;
                    }
                }
                Console.WriteLine(lettersSum);
                Console.WriteLine(numbersSum);
                Console.WriteLine(symbolsSum);

            }


        }
    }




    




