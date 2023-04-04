using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Menu
    {
        public string ShowMenu()
        {
            Console.WriteLine("Welcome to Tic Tac Toe ! ");
            Console.WriteLine("----------------");
            Console.WriteLine("'Enter' to play against a friend     'Space' to play against the computer    'Esc' to exit");

            var pressedKey = ConsoleKey.Escape;
            pressedKey = Console.ReadKey(true).Key;

            while (pressedKey != ConsoleKey.Escape && pressedKey != ConsoleKey.Spacebar && pressedKey != ConsoleKey.Enter)
            {
                pressedKey = Console.ReadKey(true).Key;
            }

            if(pressedKey == ConsoleKey.Escape)
            {
                Environment.Exit(0);
                return "null";
            }
            else if (pressedKey == ConsoleKey.Spacebar)
            {
                return "Computer";
            }
            else if (pressedKey == ConsoleKey.Enter)
            {
                return "Friend";
            }

            return "null";
        }

        public string difficultyComputer()
        {
            Console.WriteLine("\n Choose the difficulty : \n 'E' to play against an easy computer     'H' to play against an hard computer   'Esc' to go back to menu");

            var pressedKey = ConsoleKey.Escape;
            pressedKey = Console.ReadKey(true).Key;

            while (pressedKey != ConsoleKey.E && pressedKey != ConsoleKey.H && pressedKey != ConsoleKey.Escape)
            {
                pressedKey = Console.ReadKey(true).Key;
            }

            if (pressedKey == ConsoleKey.Escape)
            {
                return "Escape";
            }
            else if (pressedKey == ConsoleKey.E)
            {
                return "Easy";
            }
            else if (pressedKey == ConsoleKey.H)
            {
                return "Hard";
            }

            return "null";
        }
    }

}
