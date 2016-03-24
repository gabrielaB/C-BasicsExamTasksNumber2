using System;



namespace ConsoleApplication7
{
    class LettersSymbols
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            int lettersSum = 0;
            int numbersSum = 0;
            int symbolsSum = 0;

            for (int i = 0; i < numberOfStrings; i++)
            {
                string str = Console.ReadLine();
                str = str.ToUpper();
                str = Regex.Replace(str, "\\s+", "");

                for (int j = 0; j < str.Length; j++)
                {
                    char currentSymbol = str[j];
                    if (currentSymbol >= 'A' && currentSymbol <= 'Z')
                    {
                        lettersSum += (currentSymbol - 'A' + 1) * 10;
                    }
                    else if (currentSymbol >= '0' && currentSymbol <= '9')
                    {
                        numbersSum += (currentSymbol - '0') * 20;
                    }
                    else
                    {
                        symbolsSum += 200;

                    }
                }
            }


                    Console.WriteLine(lettersSum);
                    Console.WriteLine(numbersSum);
                    Console.WriteLine(symbolsSum);
                }

            }
        }

    

