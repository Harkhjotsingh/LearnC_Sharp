using System;
namespace NumbersToLetters
{
    class NumsToLetrs
    {
        int num;
        internal NumsToLetrs(int number)
        {
            this.num = number;
        }

        internal int Reverse()
        {
            int reverseNum = 0;
            Console.Write(num+": ");
            while (num > 0)
            {
                int temp = num % 10;
                num = (num - temp) / 10;
                reverseNum = (reverseNum * 10) + temp;
            }
            return reverseNum;
        }

        internal void PrintLetters()
        {
            int reverseNumber = Reverse();
             while (reverseNumber > 0)
            {
                int temp1 = reverseNumber % 10;
                reverseNumber = (reverseNumber - temp1) / 10;
                switch (temp1)
                {
                    case 0:
                        Console.Write("Zero" + " ");
                        break;
                    case 1:
                        Console.Write("One" + " ");
                        break;
                    case 2:
                        Console.Write("Two" + " ");
                        break;
                    case 3:
                        Console.Write("Three" + " ");
                        break;
                    case 4:
                        Console.Write("Four" + " ");
                        break;
                    case 5:
                        Console.Write("Five" + " ");
                        break;
                    case 6:
                        Console.Write("Six" + " ");
                        break;
                    case 7:
                        Console.Write("Seven" + " ");
                        break;
                    case 8:
                        Console.Write("Eight" + " ");
                        break;
                    case 9:
                        Console.Write("Nine" + " ");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int interger = 0;

            NumsToLetrs num1 = new NumsToLetrs(interger = int.Parse(Console.ReadLine()));
            num1.PrintLetters();

            NumsToLetrs num2 = new NumsToLetrs(interger = int.Parse(Console.ReadLine()));
            num2.PrintLetters();

            NumsToLetrs num3 = new NumsToLetrs(interger = int.Parse(Console.ReadLine()));
            num3.PrintLetters();

            Console.ReadLine();
        }
    }
}