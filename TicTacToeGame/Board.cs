using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class Board
    {
        public Board()
        {
            char[] board = InitializeBoard();
        }

        //Intializing Board with Empty Value
        public char[] InitializeBoard()
        {
            //Char Array of 10 elements
            char[] board = new char[10];

            //Assigning Space:-Index 1 to 9
            for (int index = 1; index < board.Length; index++)
            {
                board[index] = ' ';
            }
            return board;
        }
        //Input taking from user X or O
        public static char[] UserSymbol()
        {
            char[] userSymbol = new char[2];

           
            while (true)
            {
                Console.WriteLine("Choose a Letter X or O : ");

                char userInput = Convert.ToChar(Console.ReadLine());
                if (userInput == 'X')
                {
                    userSymbol[0] = 'X';
                    userSymbol[1] = 'O';
                    return userSymbol;
                }
                else if (userInput == 'O')
                {
                    userSymbol[0] = 'O';
                    userSymbol[1] = 'X';
                    return userSymbol;
                }
                else Console.WriteLine("Invalid Input");
            }
        }
        // Displaying Board
        public void DisplayBoard()
        {
            char[] board = InitializeBoard();

            Console.WriteLine("-----------");
            Console.WriteLine(board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("-----------");
            Console.WriteLine(board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("-----------");
            Console.WriteLine(board[7] + " | " + board[8] + " | " + board[9]);
            Console.WriteLine("-----------");
        }
    }
}
