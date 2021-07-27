using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace tic_tac_toe.Model
{
    class Game
    {
        public string[] board = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
        public bool[] emptyField = new bool[] { true, true, true, true, true, true, true, true, true };
        public bool isXNext = true;
        public bool isGameOver = false;

        public string nextPlayer = "X\nturn";
        public string nextPlayerString()
        {
            return isXNext ? "X\nTurn" : "O\nTurn";
        }
        public void newGame()
        {
            for (int i = 0; i < 9; i++)
            {
                emptyField[i] = true;
                board[i] = " ";
            }
            isXNext = true;
        }
        public void buttonClick(int button)
        {
            if (isXNext)
            {
                board[button] = "X";
            }
            else
            {
                board[button] = "O";
            }
            isXNext = !isXNext;
            emptyField[button] = false;
        }
        public bool checkGame()
        {
            nextPlayer = nextPlayerString();
            bool gameOver = true;
            bool xWon = false;
            bool yWon = false;
            if (board[0] == "X" && board[1] == "X" && board[2] == "X")
            {
                xWon = true;
                gameOver = true;
            }
            if (board[3] == "X" && board[4] == "X" && board[5] == "X")
            {
                xWon = true;
                gameOver = true;
            }
            if (board[6] == "X" && board[7] == "X" && board[8] == "X")
            {
                xWon = true;
                gameOver = true;
            }
            if (board[0] == "X" && board[3] == "X" && board[6] == "X")
            {
                xWon = true;
                gameOver = true;
            }
            if (board[1] == "X" && board[4] == "X" && board[7] == "X")
            {
                xWon = true;
                gameOver = true;
            }
            if (board[2] == "X" && board[5] == "X" && board[8] == "X")
            {
                xWon = true;
                gameOver = true;
            }
            if (board[0] == "X" && board[4] == "X" && board[8] == "X")
            {
                xWon = true;
                gameOver = true;
            }
            if (board[2] == "X" && board[4] == "X" && board[6] == "X")
            {
                xWon = true;
                gameOver = true;
            }
            if (board[0] == "O" && board[1] == "O" && board[2] == "O")
            {
                yWon = true;
                gameOver = true;
            }
            if (board[3] == "O" && board[4] == "O" && board[5] == "O")
            {
                yWon = true;
                gameOver = true;
            }
            if (board[6] == "O" && board[7] == "O" && board[8] == "O")
            {
                yWon = true;
                gameOver = true;
            }
            if (board[0] == "O" && board[3] == "O" && board[6] == "O")
            {
                yWon = true;
                gameOver = true;
            }
            if (board[1] == "O" && board[4] == "O" && board[7] == "O")
            {
                yWon = true;
                gameOver = true;
            }
            if (board[2] == "O" && board[5] == "O" && board[8] == "O")
            {
                yWon = true;
                gameOver = true;
            }
            if (board[0] == "O" && board[4] == "O" && board[8] == "O")
            {
                yWon = true;
                gameOver = true;
            }
            if (board[2] == "O" && board[4] == "O" && board[6] == "O")
            {
                yWon = true;
                gameOver = true;
            }
            if (!yWon && !xWon)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[i] == " " || board[i] == "")
                    {
                        gameOver = false;
                    }
                }
            }
            if (!gameOver)
            {
                return gameOver;
            }
            if (xWon)
            {
                MessageBox.Show("Player X won !", "Victory !");
                newGame();
                return gameOver;
            }
            if (yWon)
            {
                MessageBox.Show("Player O won !", "Victory !");
                newGame();
                return gameOver;
            }
            MessageBox.Show("It's a draw", "Game Over !");
            newGame();
            return gameOver;

        }

    }
}
