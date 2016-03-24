using System;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int sum = 0;
            for (int i=startNumber;i< endNumber; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                }
                else
                    
                {

                    sum += i % 5;
                }
                
            }

        }
    }
}
