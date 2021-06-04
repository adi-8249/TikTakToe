using System;

namespace TikTakToe_program
{
    class Program
    {
       public static void Main(string[] args)
        {
            char[] board = createBoard();
            showBoard(board);
        }

        private static void showBoard(char[] board)
        {
            Console.WriteLine("\n" + board[1] + "|" + board[2] + "|" + board[3]);
            Console.WriteLine("-----------");
            Console.WriteLine("\n" + board[4] + "|" + board[5] + "|" + board[6]);
            Console.WriteLine("-----------");
            Console.WriteLine("\n" + board[7] + "|" + board[8] + "|" + board[9]);
        }

        private static char[] createBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                board[1] = ' ';
            }
            return board;
        }


    }
}
