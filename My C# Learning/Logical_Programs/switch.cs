
//NESTED SWITCH

using System;
namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for i: ");
            byte i = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter value for j: ");
            byte j = Convert.ToByte(Console.ReadLine());
            switch(i>j)
            {
                case true:
                    Console.WriteLine("i is greater than j");
                    break;
                case false:
                    switch(i<j)
                    {
                        case true:
                            Console.WriteLine("j is greater than i");
                            break;
                        case false:
                            Console.WriteLine("i and j are equal");
                            break;
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}





//if-else inside Switch



using System;
namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for i: ");
            byte i = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter value for j: ");
            byte j = Convert.ToByte(Console.ReadLine());
            switch(i>j)
            {
                case true:
                    Console.WriteLine("i is greater than j");
                    break;
                case false:
                    if (j>i)
                    {
                        Console.WriteLine("j is greater than i");    
                    }
                    else
                    {
                        Console.WriteLine("i and j are equal");
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}



// Switch inside if-else



using System;
namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for i: ");
            byte i = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter value for j: ");
            byte j = Convert.ToByte(Console.ReadLine());
            if(i>j)
            {
                Console.WriteLine("i is greater than j");
            }
            else
            {
                switch(j>i)
                {
                    case true:
                        Console.WriteLine("j is greater than i");
                        break;
                    case false:
                        Console.WriteLine("i and j are equal");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
