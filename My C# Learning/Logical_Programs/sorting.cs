using System;
namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // SORTING of elements in an array.
            int j = 0;
            int i = 0;
            int a =0;
            Console.WriteLine("Enter length of array:");
            byte arrayLen = Byte.Parse(Console.ReadLine());
            int[] data = new int[arrayLen];

            for (i= 0;i<arrayLen-1;i++)                                       // get array elements
            {
                Console.WriteLine("Enter " + (i+1) + " number of the array");
                data[i] = Int32.Parse(Console.ReadLine());  
            }
            for(a=0;a<arrayLen;a++)                                           // Logic for sorting
                for(j = a+1;j<arrayLen;j++)
                    if(data[a]>data[j])                                      // Flip the comparision operator from ">" to "<" for sorting in decending order.   
                    {
                        int temp = data[j];
                        data[j] = data[a];
                        data[a] = temp;
                    }
            for(int x =0; x<arrayLen;x++)                                     // Print Sorted Array.
            Console.Write(" "+data[x]);
            Console.ReadLine();
        }
    }
}
