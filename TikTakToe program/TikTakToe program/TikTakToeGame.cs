using System;
using System.Collections.Generic;
using System.Text;

namespace TikTakToe_program
{
    class TikTakToeGame
    {
       
      
        char userletter = ChooseUserLetter();
        private static char ChooseUserLetter()
        {
            Console.WriteLine("choose your Letter here");
            string userletter = Console.ReadLine();
            return char.ToUpper(userletter[0]);
        }
       

    }
}
