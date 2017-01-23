// Compare 2 lists and tell if any element from 1st list is not present in the 2nd list.

using System;
namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number: ");
            int num = Int32.Parse(Console.ReadLine());
            int[] numbers = new int[num];
            for(int i = 0; i<numbers.Length; i++)
            {
                Console.Write("Enter " + i + " element");
                numbers[i] = Int32.Parse(Console.ReadLine());
            }
            for(int a=0;a<numbers.Length;a++)
                for(int b =a+1;b<numbers.Length;b++)
                {
                    if(numbers[a]>numbers[b])
                    {
                        int temp = numbers[b];
                        numbers[b] = numbers[a];
                        numbers[a] = temp;
                    }
                }      
            Console.Write("Second greatest number is " + numbers[1]);
            Console.ReadLine();
        }
    }
}
