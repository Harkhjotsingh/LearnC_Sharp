// TIC-TAC_TOE game.  DISCLAIMER: This code has some bad coding pracices and is organised badly.

using System;
namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // assigning location values to the matrix tictactoe. 
            string[,] tictactoe = new string[,] { {"00","01","02" },{"10","11","12" },{"20","21","22"} };
            Console.WriteLine("Welcome to Tic-Tac-Toe game.This is your location reference");
            for (int i = 0; i < tictactoe.GetLength(0); i++)
            {
                for (int j = 0; j < tictactoe.GetLength(1); j++)
                { 
                    Console.Write(tictactoe[i, j] + " ");
                }
                Console.WriteLine();
            }
            // messages for users/players.
            Console.WriteLine("This is a two player game and I will ask both of you to enter row and column number,of the location where ");
            Console.WriteLine("you want to mark you move. Above is you reference matrix for row and cloumn position");
            confirm:
            Console.WriteLine("Press 1 to continue");
            int confirm = Int32.Parse(Console.ReadLine());
            if (confirm != 1)
                goto confirm;
            Console.WriteLine("Now,Lets begin the game.");
            for (int i = 0; i < tictactoe.GetLength(0); i++)
            { 
                for(int j=0; j<tictactoe.GetLength(1);j++)
                {
                    tictactoe[i, j] = "-";
                    Console.Write(tictactoe[i, j] + " ");
                }
                Console.WriteLine();
            }
            // taking location from players and assigning in the game.
            for (int i = 0;i<(tictactoe.GetLength(0)*tictactoe.GetLength(1));i++)
            {
                if (i % 2 == 0)   // Player one chance to make a move.
                {
                    rowagain:
                        Console.WriteLine("Player1:: Enter a row location where you want to enter a value");
                        uint row = UInt32.Parse(Console.ReadLine());
                        if (row < 0 || row > 3)
                    {
                        Console.WriteLine("Please enter a row value between 0 and 3");
                        goto rowagain;
                    }
                columnagain:
                        Console.WriteLine("Player1:: Now pick a cloumn location");
                        uint column = UInt32.Parse(Console.ReadLine());
                        if (column < 0 || column > 3)
                    {
                        Console.WriteLine("Please enter a row value between 0 and 3");
                        goto columnagain;
                    }
                    tictactoe[row,column]= "X";

                    for (int x = 0; x < tictactoe.GetLength(0); x++)
                    {
                        for (int y = 0; y < tictactoe.GetLength(1); y++)
                        { 
                            Console.Write(tictactoe[x,y] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                if (i % 2 != 0)   //Player 2 turn to make a move. 
                {
                rowagain:
                    Console.WriteLine("Player2:: Enter a row where you want to enter a value");
                    uint row = UInt32.Parse(Console.ReadLine());
                    if (row < 0 || row > 3)
                    {
                        Console.WriteLine("Please enter a column value between 0 and 3");
                        goto rowagain;
                    }
                columnagain:
                    Console.WriteLine("Player2:: Now pick a cloumn");
                    uint column = UInt32.Parse(Console.ReadLine());
                    if (column < 0 || column > 3)
                    {
                        Console.WriteLine("Please enter a column value between 0 and 3");
                        goto columnagain;
                    }
                    tictactoe[row, column] = "O";
                    for (int a = 0; a < tictactoe.GetLength(0); a++)
                    {
                        for (int b = 0; b < tictactoe.GetLength(1); b++)
                        {
                            Console.Write(tictactoe[a, b] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
