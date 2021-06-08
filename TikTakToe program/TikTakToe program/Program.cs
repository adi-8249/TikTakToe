using System;

namespace TikTakToe_program
{
    class Program
    {
        public enum Player { USER, COMPUTER };
        public const int Head = 0;
        public const int Tail = 0;
        private static object userLetter;
        public static void Main(string[] args)
        {
            char[] board = createBoard();
            showBoard(board);
            int userMove = getUserMove(board);
            Player player = getWhoStartsFirst();
            char userLetter = ChooseUserLetter();
            Console.WriteLine("Check if won" + IsWinner(board,userLetter));
        }
        private static int getUserMove(char[] board)
        {

            int[] validCells = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            while (true)
            {
                Console.WriteLine("go for the next move : from 1-9");
                int index = Convert.ToInt32(Console.ReadLine());
                if (Array.Find<int>(validCells, element => element == index) != 0 && isSpaceFree(board, index)) ;
                return index;
            }
        }
        private static bool isSpaceFree(char[] board, int index)
        {
            return board[index] == ' ';
        }

        private static void showBoard(char[] board)
        {
            Console.WriteLine("\n" + board[1] + " |" + board[2] + " |" + board[3]);
            Console.WriteLine("-----------");
            Console.WriteLine("\n" + board[4] + " |" + board[5] + " |" + board[6]);
            Console.WriteLine("-----------");
            Console.WriteLine("\n" + board[7] + " |" + board[8] + " |" + board[9]);
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
        private static void makeMove(char[] board, int index, char letter)
        {
           bool spaceFree = isSpaceFree(board, index);
            if (spaceFree) board[index] = letter;
          
        }
        private static Player getWhoStartsFirst()
        {
            int toss = getOneFromRandomChoices(2);
            return (toss == Head) ? Player.USER : Player.COMPUTER;
        }
        private static int getOneFromRandomChoices(int choices)
        {
            Random random = new Random();
            return (int)(random.Next() * 10) % choices;
        }
        private static char ChooseUserLetter()
        {
            Console.WriteLine("choose your Letter here");
            string userletter = Console.ReadLine();
            return char.ToUpper(userletter[0]);
        }
        private static bool IsWinner(char[] b, char ch)
        {
            return ((b[1] == ch && b[2] == ch && b[3] == ch) ||
                    (b[4] == ch && b[5] == ch && b[6] == ch) ||
                    (b[7] == ch && b[8] == ch && b[9] == ch) ||
                    (b[1] == ch && b[4] == ch && b[7] == ch) ||
                    (b[2] == ch && b[5] == ch && b[8] == ch) ||
                    (b[3] == ch && b[6] == ch && b[9] == ch) ||
                    (b[1] == ch && b[5] == ch && b[9] == ch) ||
                    (b[7] == ch && b[5] == ch && b[3] == ch));
        }




    }
}
