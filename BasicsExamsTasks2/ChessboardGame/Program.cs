using System;

namespace ChessboardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int whiteScore = 0;
            int blackScore = 0;
            for(int i =0;i< n * n; i++)
            {
                if(input.Length < n * n && i==input.Length)
                {
                    break;
                }
                char symbol = input[i];
                if ((symbol >= 'a' && symbol <= 'z') || (symbol >= 'A' && symbol <= 'Z') || (symbol >= '0' && symbol <= '9'))
                {
                    if (i % 2 == 0)
                    {
                        if (symbol >= 'A' && symbol <= 'Z')
                        {
                            whiteScore += symbol;
                        }
                        else
                        {
                            blackScore += symbol;
                        }
                    }
                    else

                    {
                        if (symbol >= 'A' && symbol <= 'Z')
                        {
                            blackScore += symbol;
                        }
                        else
                        {
                            whiteScore += symbol;
                        }
                        
                    }

                }
            }
            if(whiteScore == blackScore)
            {
                Console.WriteLine("Equal result: {0}",whiteScore);
            }
            else if(whiteScore > blackScore)
            {
                Console.WriteLine("The winner is: white team");
                Console.WriteLine(whiteScore-blackScore);
            }
            else
            {
                Console.WriteLine("The winner is: black team");
                Console.WriteLine(blackScore - whiteScore);

            }
        }
    }
}
