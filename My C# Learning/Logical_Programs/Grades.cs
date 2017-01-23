/* Question:                
Grading Program
Requires:
variables, data types, and numerical operators
basic input/output
logic (if statements, switch statements)

Write a program that allows the user to enter the grade scored in a programming class (0-100).
If the user scored a 100 then notify the user that they got a perfect score.

★ Modify the program so that if the user scored a 90-100 it informs the user that they scored an A

★★ Modify the program so that it will notify the user of their letter grade
0-59 F 60-69 D 70-79 C 80-89 B 90-100 A
*/
                

using System;
namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your marks:");
            byte marks;
            marks = Byte.Parse(Console.ReadLine());
            if (marks == 100)
            {
                Console.WriteLine("You got the perfect marks MATE! Good for you");
            }
            else if (marks >= 90 && marks < 100)
            {
                Console.WriteLine("You recieved A Grade");
            }
            else if (marks >= 80 && marks < 90)
            {
                Console.WriteLine("You recieved B Grade");
            }
            else if (marks >= 70 && marks < 80)
            {
                Console.WriteLine("You recieved C Grade");
            }
            else if (marks >= 60 && marks < 70)
            {
                Console.WriteLine("You recieved D Grade");
            }
            else if (marks >= 50 && marks < 60)
            {
                Console.WriteLine("You recieved E Grade");
            }
            else if(marks =< 50 && marks > 0)
            {
                Console.WriteLine(marks + " You failed Idiot!");
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
            Console.ReadLine();
        }
    }
}
