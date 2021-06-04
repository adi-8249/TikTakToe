using System;

namespace TikTakToe_program
{
    class Program
    {
       public static void Main(string[] args)
        {
            char[] board = createBoard();
           
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
