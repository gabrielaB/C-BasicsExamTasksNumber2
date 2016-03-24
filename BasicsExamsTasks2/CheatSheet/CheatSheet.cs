using System;
using System.Collections.Generic;


namespace CheatSheet
{
    class CheatSheet
    {
        static void Main(string[] args)
        {
            long rows = long.Parse(Console.ReadLine());
           long  columns= long.Parse(Console.ReadLine());
            long vertical= long.Parse(Console.ReadLine());
            long horizontal= long.Parse(Console.ReadLine());
            long horizontalInit = horizontal;
            for( long row=0;row < rows; row++)
            {
                for(long col = 0; col < columns; col++)
                {
                    Console.Write(horizontal*vertical + " ");
                    horizontal++;
                }
                Console.WriteLine();
                vertical++;
                horizontal = horizontalInit;


            }
        }
    }
}
