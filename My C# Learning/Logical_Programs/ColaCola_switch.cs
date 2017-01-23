/* Question:                
Requires:
variables, data types, and numerical operators
basic input/output
logic (if statements, switch statements)

Write a program that presents the user w/ a choice of your 5 favorite beverages (Coke, Water, Sprite, ... , Whatever).
Then allow the user to choose a beverage by entering a number 1-5.
Output which beverage they chose.

★ If you program uses if statements instead of a switch statement, modify it to use a switch statement.
If instead your program uses a switch statement, modify it to use if/else-if statements.

★★ Modify the program so that if the user enters a choice other than 1-5 then it will output "Error. choice was not valid, here is your money back."
*/


using System;
namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a drink by entering a number from 1 to 5");
            byte choice = Byte.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("You choose CocaCola");
                    break;
                case 2:
                    Console.WriteLine("You choose Pepsi");
                    break;
                case 3:
                    Console.WriteLine("You choose Limca");
                    break;
                case 4:
                    Console.WriteLine("You choose Water");
                    break;
                case 5:
                    Console.WriteLine("You choose Beer. Seriouly dude,even here!");
                    break;
                default:
                    Console.WriteLine("Error. choice was invalid, here is your money back.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
