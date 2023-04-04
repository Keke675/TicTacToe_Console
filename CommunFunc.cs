using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class CommunFunc
    {
        public bool isWin(string[][] board, bool isPlayer)
        {
            /*
             * Check if the game is finished (gives the winner)
             */
            string player = "X";
            for (int i = 0; i <= 1; i++)
            {
                // Check Lines and column
                for(int j = 0; j<=2; j++)
                {
                    // Lines
                    if (board[j][0] == player && board[j][1] == player && board[j][2] == player)
                    {
                        displayboard(board);
                        if (player == "X" && isPlayer) Console.WriteLine("Player 1 win !\n");
                        else if (player == "O" && isPlayer) Console.WriteLine("Player 2 win !\n");
                        return true;
                    }

                    //columns
                    if (board[0][j] == player && board[1][j] == player && board[2][j] == player)
                    {
                        displayboard(board);
                        if (player == "X" && isPlayer) Console.WriteLine("Player 1 win !\n");
                        else if (player == "O" && isPlayer) Console.WriteLine("Player 2 win !\n");
                        return true;
                    }

                    // Diagonal
                    if ((board[0][2] == player && board[1][1] == player && board[2][0] == player) || (board[0][0] == player && board[1][1] == player && board[2][2] == player))
                    {
                        displayboard(board);
                        if (player == "X" && isPlayer) Console.WriteLine("Player 1 win !\n");
                        else if (player == "O" && isPlayer) Console.WriteLine("Player 2 win !\n");
                        return true;
                    }
                }
                player = "O";

                if (isBoardFull(board))
                {
                    displayboard(board);
                    Console.WriteLine("     Nobody win the game :(  \n");
                    return true;
                }
            }


            return false;
        }

        public void displayboard(string[][] board)
        {
            /*
             * Display the board
             */
            Console.WriteLine($"\n {board[0][0]} | {board[0][1]} | {board[0][2]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {board[1][0]} | {board[1][1]} | {board[1][2]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {board[2][0]} | {board[2][1]} | {board[2][2]}\n");
        }

        public bool keyIsNumpadOrNumber(ConsoleKey keyPressed)
        {
            /*
             * Check if the keypressed is a number key or a numpad key
             */
            if (keyPressed == ConsoleKey.D1 || keyPressed == ConsoleKey.D2 || keyPressed == ConsoleKey.D3 || keyPressed == ConsoleKey.D4 || keyPressed == ConsoleKey.D5 || keyPressed == ConsoleKey.D6 || keyPressed == ConsoleKey.D7 || keyPressed == ConsoleKey.D8 || keyPressed == ConsoleKey.D9 || keyPressed == ConsoleKey.NumPad1 || keyPressed == ConsoleKey.NumPad2 || keyPressed == ConsoleKey.NumPad3 || keyPressed == ConsoleKey.NumPad4 || keyPressed == ConsoleKey.NumPad5 || keyPressed == ConsoleKey.NumPad6 || keyPressed == ConsoleKey.NumPad7 || keyPressed == ConsoleKey.NumPad8 || keyPressed == ConsoleKey.NumPad9 )
            {
                return true;
            }
            return false;
        }

        public string[][] placeInBoard(string[][] board, ConsoleKey keyPressed,string symbol)
        {
            /*
             * Place the right symbol in the board
             */
            if (keyPressed == ConsoleKey.D1 || keyPressed == ConsoleKey.NumPad1) board[2][0] = symbol;
            else if (keyPressed == ConsoleKey.D2 || keyPressed == ConsoleKey.NumPad2) board[2][1] = symbol;
            else if (keyPressed == ConsoleKey.D3 || keyPressed == ConsoleKey.NumPad3) board[2][2] = symbol;
            else if (keyPressed == ConsoleKey.D4 || keyPressed == ConsoleKey.NumPad4) board[1][0] = symbol;
            else if (keyPressed == ConsoleKey.D5 || keyPressed == ConsoleKey.NumPad5) board[1][1] = symbol;
            else if (keyPressed == ConsoleKey.D6 || keyPressed == ConsoleKey.NumPad6) board[1][2] = symbol;
            else if (keyPressed == ConsoleKey.D7 || keyPressed == ConsoleKey.NumPad7) board[0][0] = symbol;
            else if (keyPressed == ConsoleKey.D8 || keyPressed == ConsoleKey.NumPad8) board[0][1] = symbol;
            else if (keyPressed == ConsoleKey.D9 || keyPressed == ConsoleKey.NumPad9) board[0][2] = symbol;

            return board;
        }

        public bool isBoardFull(string[][] board)
        {
            /*
             * Check if the board is full
             */
            if (!(board[0][0] == " " || board[0][1] == " " || board[0][2] == " " || board[1][0] == " " || board[1][1] == " " || board[1][2] == " " || board[2][0] == " " || board[2][1] == " " || board[2][2] == " ")) return true;
            return false;
        }

        public bool isAlreadyPlaced(string[][] board, ConsoleKey keyPressed, bool isComputer)
        {
            /*
             * Give the board and the keypress and tell if the place is already taken or not
             */
            if (keyPressed == ConsoleKey.D1 || keyPressed == ConsoleKey.NumPad1)
            {
                if (board[2][0] == " ") return false;
            }
            else if (keyPressed == ConsoleKey.D2 || keyPressed == ConsoleKey.NumPad2)
            {
                if (board[2][1] == " ") return false;
            }
            else if (keyPressed == ConsoleKey.D3 || keyPressed == ConsoleKey.NumPad3)
            {
                if (board[2][2] == " ") return false;
            }
            else if (keyPressed == ConsoleKey.D4 || keyPressed == ConsoleKey.NumPad4)
            {
                if (board[1][0] == " ") return false;
            }
            else if (keyPressed == ConsoleKey.D5 || keyPressed == ConsoleKey.NumPad5)
            {
                if (board[1][1] == " ") return false;
            }
            else if (keyPressed == ConsoleKey.D6 || keyPressed == ConsoleKey.NumPad6)
            {
                if (board[1][2] == " ") return false;
            }
            else if (keyPressed == ConsoleKey.D7 || keyPressed == ConsoleKey.NumPad7)
            {
                if (board[0][0] == " ") return false;
            }
            else if (keyPressed == ConsoleKey.D8 || keyPressed == ConsoleKey.NumPad8)
            {
                if (board[0][1] == " ") return false;
            }
            else if (keyPressed == ConsoleKey.D9 || keyPressed == ConsoleKey.NumPad9)
            {
                if (board[0][2] == " ") return false;
            }
            if(!isComputer) Console.WriteLine($"The placement {keyPressed} is already used");
            return true;
        }

        public string[][] initBoard()
        {
            /*
             * Initiation of the board (creation)
             */
            string[][] board = new string[3][];
            board[0] = new string[3];
            board[1] = new string[3];
            board[2] = new string[3];

            Array.Fill(board[0], " ");
            Array.Fill(board[1], " ");
            Array.Fill(board[2], " ");

            Console.Clear();
            Console.WriteLine("To play, use the numerical number from 1-9");
            Console.WriteLine("-----------");
            Console.WriteLine(" 7 | 8 | 9 ");
            Console.WriteLine("-----------");
            Console.WriteLine(" 4 | 5 | 6 ");
            Console.WriteLine("-----------");
            Console.WriteLine(" 1 | 2 | 3 ");
            Console.WriteLine("-----------");

            Console.WriteLine("\n-----------------------\n");

            return board;
        }

        public ConsoleKey convertNumbertoKey(int keyPressed)
        {
            /*
             * Give the board and the keypress and tell if the place is already taken or not
             */
            if (keyPressed == 1) return ConsoleKey.D1;
            else if (keyPressed == 2) return ConsoleKey.D2;
            else if (keyPressed == 3) return ConsoleKey.D3;
            else if (keyPressed == 4) return ConsoleKey.D4;
            else if (keyPressed == 5) return ConsoleKey.D5;
            else if (keyPressed == 6) return ConsoleKey.D6;
            else if (keyPressed == 7) return ConsoleKey.D7;
            else if (keyPressed == 8) return ConsoleKey.D8;
            else if (keyPressed == 9) return ConsoleKey.D9;

            return ConsoleKey.D1;
        }
    }
}
