// Compare 2 lists and tell if any element from 1st list is not present in the 2nd list.

using System;
namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Console.Write("Enter array size: ");
            byte size = Byte.Parse(Console.ReadLine());
            int[] list1 = new int[size];
            int[] list2 = new int[size];
            Console.WriteLine("Enter elements for list1");                       // get list1 elements
            for (int i = 0; i < list1.Length; i++)
            {
                Console.Write("Enter element number " +(i+1)+": ");
                list1[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter elements for list2");                      // get list1 elements
            for (int i = 0; i < list2.Length; i++)
            {
                Console.Write("Enter element number " +(i + 1)+ " ");
                list2[i] = Int32.Parse(Console.ReadLine());
            }
            // Compare both lists. 
            for (int i = 0; i < list1.Length; i++)
            {
                for (int j = 0; j < list2.Length; j++)
                {
                    if (list1[i] == list2[j])
                        flag = 1;
                }
                if (flag == 0)
                    Console.WriteLine(list1[i] + " is not present in List 2");
                else
                { 
                    flag = 0;
                }
            }
            Console.ReadLine();
        }
    }
}
