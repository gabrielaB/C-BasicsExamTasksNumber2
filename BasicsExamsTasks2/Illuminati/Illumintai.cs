using System;


namespace ConsoleApplication3
{
    class Illumintai
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            input = input.ToUpper();


            int numberOfVowels = 0;
            int numberOfLetters = 0;
            foreach(char letter in input)

                if (  letter == 'A'
                    ||  letter == 'O'
                    ||  letter == 'E'
                    ||  letter=='I' 
                    ||  letter=='U')
                { 
                    numberOfVowels++;
                    numberOfLetters += letter;
                }
                Console.WriteLine(numberOfVowels);
            Console.WriteLine(numberOfLetters);
                
            
            }
        }
    }

