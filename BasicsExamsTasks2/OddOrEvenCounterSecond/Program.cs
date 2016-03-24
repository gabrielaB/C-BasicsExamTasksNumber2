using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenCounterSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfSets = int.Parse(Console.ReadLine());
            int numbersPerSet = int.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine();
            int maxCount = 0;
            int maxSetNumber = -1;


            for (int set = 1; set <= countOfSets; set++)
            {
                int counter = 0;
                for (int j = 0; j < numbersPerSet; j++)
                {
                    int currentNum = int.Parse(Console.ReadLine());
                    if (oddOrEven == "odd")
                    {
                        if (currentNum%2 == 1)
                        {
                            counter++;
                            if (counter > maxCount)
                            {
                                maxCount = counter;
                                maxSetNumber = set;
                            }
                        }
                    }
                    else
                    {
                        if (currentNum % 2 == 0)
                        {
                            counter++;
                            if (counter > maxCount)
                            {
                                maxCount = counter;
                                maxSetNumber = set;
                            }
                        }
                    }

                }
            }

            if (maxSetNumber == -1)
            {
                Console.WriteLine("No");
            }
            else
            {
                switch (maxSetNumber)
                {
                    case 1:
                        Console.WriteLine("First set has the most {0} numbers: {1}", oddOrEven, maxCount);
                        break;
                    case 2:
                        Console.WriteLine("Second set has the most {0} numbers: {1}", oddOrEven, maxCount);
                        break;
                    case 3:
                        Console.WriteLine("Third set has the most {0} numbers: {1}", oddOrEven, maxCount);
                        break;
                    case 4:
                        Console.WriteLine("Fourth set has the most {0} numbers: {1}", oddOrEven, maxCount);
                        break;
                    case 5:
                        Console.WriteLine("Fifth set has the most {0} numbers: {1}", oddOrEven, maxCount);
                        break;
                    case 6:
                        Console.WriteLine("Sixth set has the most {0} numbers: {1}", oddOrEven, maxCount);
                        break;
                    case 7:
                        Console.WriteLine("Seventh set has the most {0} numbers: {1}", oddOrEven, maxCount);
                        break;
                    case 8:
                        Console.WriteLine("Eighth set has the most {0} numbers: {1}", oddOrEven, maxCount);
                        break;
                    case 9:
                        Console.WriteLine("Ninth set has the most {0} numbers: {1}", oddOrEven, maxCount);
                        break;
                    case 10:
                        Console.WriteLine("Tenth set has the most {0} numbers: {1}", oddOrEven, maxCount);
                        break;
                }

            }

        }
    }
}
