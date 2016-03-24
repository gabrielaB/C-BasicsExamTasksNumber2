using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApplication11
{
    class SpyHard
    {
        static void Main(string[] args)
        {
            int numeralSystem = int.Parse(Console.ReadLine());

            string message = Console.ReadLine();
            message = message.ToUpper();
            int result = 0;
            for (int i = 0; i < message.Length; i++)
            {
                char currentChar = message[i];
                if (currentChar >= 'A' && currentChar <= 'Z')
                {
                    result += (currentChar - 'A' + 1);
                }
                else
                {
                    result += currentChar;
                }
            }
            StringBuilder numeralSystemConverter = new StringBuilder();

            while (result > 0)
            {
                numeralSystemConverter.Insert(0, result % numeralSystem);
                result /= result;
            }

            Console.WriteLine(numeralSystemConverter);


        }
    }
}
