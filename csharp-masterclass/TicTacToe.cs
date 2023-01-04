
using System;

namespace cSharpMasterclass
{

    internal class TicTacToe { 
        public static void Play()
        {
            ////////////////// tic tac toe challenge //////////////////

            string[,] board = new string[3, 3]
            {
                { " ", " ", " "},
                { " ", " ", " "},
                { " ", " ", " "},
            };

            static void WriteBoard(string[,] Board)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($" {Board[i, 0]} | {Board[i, 1]} | {Board[i, 2]} ");
                    if (i < 2)
                    {
                        Console.WriteLine("-----------");
                    }
                }
            }

            static bool CheckIfComplete(string[,] Board)
            {
                // left to right diag
                if (Board[0, 0] == Board[1, 1] && Board[0, 0] == Board[2, 2] && Board[0, 0] != " ")
                {
                    return true;
                }
                // right to left diag
                if (Board[0, 2] == Board[1, 1] && Board[0, 2] == Board[2, 0] && Board[0, 2] != " ")
                {
                    return true;
                }

                for (int i = 0; i < 3; i++)
                {
                    // check cols
                    if (Board[0, i] == Board[1, i] && Board[0, i] == Board[2, i] && Board[0, i] != " ")
                    {
                        return true;
                    }
                    // check rows
                    if (Board[i, 0] == Board[i, 1] && Board[i, 0] == Board[i, 2] && Board[i, 0] != " ")
                    {
                        return true;
                    }

                }

                return false;
            }

            // show empty board
            WriteBoard(board);

            bool player1Currently = true;

            // play game
            while (CheckIfComplete(board) == false)
            {
                int player = player1Currently ? 1 : 2;

                Console.WriteLine($"Player {player}: Enter Row 1, 2, or 3");
                char input1 = Console.ReadLine()[0];

                Console.WriteLine($"Player {player}: Enter Column 1, 2, or 3");
                char input2 = Console.ReadLine()[0];

                int row = -1;
                int col = -1;

                // error handling
                switch (input1)
                {
                    case '1':
                        row = 0;
                        break;
                    case '2':
                        row = 1;
                        break;
                    case '3':
                        row = 2;
                        break;
                    default:
                        break;
                }

                switch (input2)
                {
                    case '1':
                        col = 0;
                        break;
                    case '2':
                        col = 1;
                        break;
                    case '3':
                        col = 2;
                        break;
                    default:
                        break;
                }

                if (row > -1 && col > -1)
                {
                    if (board[row, col] == " ")
                    {
                        board[row, col] = player1Currently ? "X" : "O";

                        // switch players
                        player1Currently = !player1Currently;

                        // write board to console
                        WriteBoard(board);
                    }
                    else
                    {
                        Console.WriteLine("Error! There is already a mark here!");
                    }
                }
                else
                {
                    Console.WriteLine("Error! Must input 1, 2, or 3");
                }
            }

            Console.WriteLine("Game complete!");
        }
    }
    
    
    }

    


