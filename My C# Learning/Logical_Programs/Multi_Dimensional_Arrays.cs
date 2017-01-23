// Creating, printing a 2D array(matrix). Also finding the maximum and minimum number among all the elements. 
// Lastly finding the product of all the elements. 

using System;
namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2D arrays.
            Console.WriteLine("Enter numbre of rows in the matrix:");
            int row = Int32.Parse(Console.ReadLine());                         // Get rows
            Console.WriteLine("Enter numbre of columns in the matrix:");
            int column = Int32.Parse(Console.ReadLine());                      // Get Columns   
            int[,] matrix = new int[row, column];                              // Declaring 2D array.
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)                                      // Get values for elements in matrix. 
                {
                    Console.Write("Enter position " + i + j + " value: ");
                    short value = short.Parse(Console.ReadLine());
                    matrix[i, j] = value;
                }
            Console.WriteLine("The Matrix is:");
            for (int i = 0; i < row; i++)                                      // Print the matrix. 
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine("");                                         // This line takes the matrix to next row once a row is completely printed.      
            }
            int largest = matrix[0, 0];                                        // largest number declaration.
            int smallest = matrix[0, 0];                                       // Smallest number declaration.     
            int multiplication = 1;                                            // Multiplication declaration, to find the product of all elements.      
            for (int i = 0; i < row; i++)                                            // Logic for finding largest and smallest numbers in the matrix.                 
                for (int j = 0; j < column; j++)
                {
                    if (largest < matrix[i, j])                                // if current largest number < current element. largest number = current element
                        largest = matrix[i, j];                                // if current smallest number < current element. smallest number = current element
                    if (smallest > matrix[i, j])
                        smallest = matrix[i, j];
                    multiplication = multiplication * matrix[i, j];
                }
            Console.WriteLine("The largest number in the above matrix is: " + largest);
            Console.WriteLine("The smallest number in the above matrix is: " + smallest);
            Console.WriteLine("Multiplication of all the elements of the matrix is: " + multiplication);
            Console.ReadLine();
        }
    }
}
