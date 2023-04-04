using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class FriendPlay
    {

        public void PlayAgainstFriend()
        {
            int round = 0;

            CommunFunc communFunc = new CommunFunc();

            string[][] board = communFunc.initBoard();

            while (!communFunc.isWin(board, true))
            {
                communFunc.displayboard(board);

                board = playerTurn(board, communFunc, round);

                round++;
            }
        }

        private string[][] playerTurn(string[][] board, CommunFunc communFunc, int round)
        {
            string symbol = "null";
            if (round % 2 == 0) { Console.WriteLine("Player 1 turn, you are the 'X'"); symbol = "X"; }
            else if (round % 2 == 1) { Console.WriteLine("Player 2 turn, you are the 'O'"); symbol = "O"; }

            ConsoleKey keyPressed = ConsoleKey.A;
            while (!communFunc.keyIsNumpadOrNumber(keyPressed))
            {
                keyPressed = Console.ReadKey(true).Key;
                while (communFunc.isAlreadyPlaced(board, keyPressed, false))
                {
                    keyPressed = Console.ReadKey(true).Key;
                }
                
            }

            board = communFunc.placeInBoard(board, keyPressed, symbol);

            return board;
        }
    }
}
