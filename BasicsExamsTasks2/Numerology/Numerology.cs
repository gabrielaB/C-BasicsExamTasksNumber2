using System;


namespace ConsoleApplication10
{
    class Numerology
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split('.', ' ');
            int day =int.Parse(input[0]);
            int month = int.Parse(input[1]);
            int year = int.Parse(input[2]);
            string name = input[3];
            long result = day * month * year;
            if (month % 2 == 1)
            {
                result*= result;
            }
            for(int i =0;i< name.Length; i++)
            {
                char currentchar = name[i];
                if (currentchar >= '0' && currentchar <= '9')
                {
                    result += currentchar - '0';
                }
                else  if(currentchar >= 'a' && currentchar<= 'z')
                {
                    result += (currentchar - 'a' + 1);
                }
                else if( currentchar >= 'A' && currentchar <= 'Z')
                {
                    result += 2 * (currentchar - 'A' + 1);
                   
                }

            }
        }
    }
}
