using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To TicTacToe Game ");
            Console.WriteLine("----------------------------");
            //Object of Board
            Board board = new Board();
            Board.UserSymbol();

        }
    }
}
