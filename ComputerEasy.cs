using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class ComputerEasy
    {
        public void playAgainstEasyComputer()
        {
            int round = 0;

            CommunFunc communFunc = new CommunFunc();

            string[][] board = communFunc.initBoard();

            while (!communFunc.isWin(board, true))
            {
                communFunc.displayboard(board);

                board = playerOnlyTurn(board, communFunc, round);

                round++;
            }
        }

        private string[][] playerOnlyTurn(string[][] board, CommunFunc communFunc, int round)
        {
            ConsoleKey keyP = ConsoleKey.A;
            string symbol = "null";
            if (round % 2 == 0) 
            { 
                Console.WriteLine("Player turn, you are the 'X'"); 
                symbol = "X";

                ConsoleKey keyPressed = ConsoleKey.A;
                while (!communFunc.keyIsNumpadOrNumber(keyPressed))
                {
                    keyPressed = Console.ReadKey(true).Key;
                    while (communFunc.isAlreadyPlaced(board, keyPressed, false))
                    {
                        keyPressed = Console.ReadKey(true).Key;
                    }

                }
                keyP = keyPressed;
            }
            else if (round % 2 == 1)
            { 
                Console.WriteLine("Computer turn, you are the 'O'"); 
                symbol = "O";

                ConsoleKey keyPressed = ConsoleKey.A;
                Random rand = new Random();
                int randomNumber = rand.Next(1, 9);
                keyPressed = ConsoleKey.D + randomNumber;
                while (communFunc.isAlreadyPlaced(board, keyPressed, true))
                {
                    randomNumber = rand.Next(1, 9);
                    keyPressed = communFunc.convertNumbertoKey(randomNumber);
                }

                keyP = keyPressed;
            }
            board = communFunc.placeInBoard(board, keyP, symbol);

            return board;
        }

    }
}
