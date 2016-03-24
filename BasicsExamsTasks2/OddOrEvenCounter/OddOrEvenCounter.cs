using System;


namespace ConsoleApplication9
{
    class OddOrEvenCounter
    {
        static void Main(string[] args)
        {
            int countOfSets = int.Parse(Console.ReadLine());
            int numbersPerSet = int.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine();
            int setNumber = 1;
            int counter = 0;
            int maxCount = 0;
            int maxSetNumber = -1;
            for (int i = 0; i < countOfSets * numbersPerSet; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i  % numbersPerSet == 0 && i != 0)
                {
                    setNumber++;
                    counter = 0;
                }
                if (oddOrEven == "even")
                {
                    if (num%2 == 0)
                    {
                        counter++;
                        if (counter > maxCount)
                        {
                            maxCount = counter;
                            maxSetNumber = setNumber;
                        }
                    }
                }
                else
                {
                    if (num % 2 == 1)
                    {
                        counter++;
                        if (counter > maxCount)
                        {
                            maxCount = counter;
                            maxSetNumber = setNumber;
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
                        Console.WriteLine("First set has the most {0} numbers: {1}",oddOrEven,maxCount);
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
