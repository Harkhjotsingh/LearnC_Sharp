// This is pyramid Program
using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            byte rows = byte.Parse(Console.ReadLine());
            int space = (rows-1);
            for (int i = 1; i <= rows; i++)
            {
                for (int k = space; k >= 0; k--)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j < (i)*2; j++)
                {
                    Console.Write("*"+" " );
                }
                space = space-1;
                Console.WriteLine();
            }
            Console.ReadLine();              
        }
    }
}
