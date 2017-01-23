/*Enter age from the user and Display status messages accoringly. 
for example. Person with age >= 60, has a senior citizen status.
             Person with age between 18-25 is college student */
using System;
namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age:");
            byte age = Byte.Parse(Console.ReadLine());
            switch (age >= 60)
            {
                case true:
                    Console.WriteLine("you are senior citizen");
                    break;
                case false:
                    switch (age < 60 && age >= 25)
                    {
                        case true:
                            Console.WriteLine("You are working class citizen");
                            break;
                        case false:
                            switch (age < 25 && age >= 18)
                            {
                                case true:
                                    Console.WriteLine("You're a college student");
                                    break;
                                case false:
                                    switch (age < 18 && age >= 5)
                                    {
                                        case true:
                                            Console.WriteLine("You're in school");
                                            break;
                                        case false:
                                            switch (age < 5)
                                            {
                                                case true:
                                                    Console.WriteLine("You're a todler");
                                                    break;
                                                case false:
                                                    Console.WriteLine("Dude your age connot be 0 or -ve");
                                                    break;
                                            }
                                            break;

                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
