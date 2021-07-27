using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace tic_tac_toe.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Model.Game game = new Model.Game();

        public string[] Board
        {
            get
            {
                return game.board;
            }
            set
            {
                game.board = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Board)));
            }
        }
        public bool[] ButtonsUse
        {
            get
            {
                return game.emptyField;
            }
            set
            {
                game.emptyField = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ButtonsUse)));
            }
        }

        public string NextMove
        {
            get
            {
                return game.nextPlayer;
            }
            set
            {
                game.nextPlayer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NextMove)));
            }
        }
        private ICommand newGame;
        public ICommand NewGame
        {
            get
            {
                return newGame ?? (newGame = new BaseClass.RelayCommand((p) =>
                {
                    Board = new string[9]{ "", "", "", "", "", "", "", "", ""};
                    NextMove = "X\nmove";
                    ButtonsUse = new bool[9] { true, true, true, true, true, true, true, true, true };
                    game.newGame();
                }, p => true));
            }
        }

        private ICommand buttonClick0, buttonClick1, buttonClick2, buttonClick3, buttonClick4, buttonClick5, buttonClick6, buttonClick7, buttonClick8;
        public ICommand ButtonClick0
        {
            get
            {
                return buttonClick0 ?? (buttonClick0 = new BaseClass.RelayCommand((p) =>
                {
                    game.buttonClick(0);
                    NextMove = game.nextPlayerString();
                    string[] temp = (string[])Board.Clone();
                    temp[0] = game.board[0];
                    Board = temp;
                    bool[] temp2 = (bool[])ButtonsUse.Clone();
                    temp2[0] = game.emptyField[0];
                    ButtonsUse = temp2;
                    if (game.checkGame())
                    {
                        ButtonsUse = new bool[9] { true, true, true, true, true, true, true, true, true };
                        Board = new string[9] { "", "", "", "", "", "", "", "", "" };
                        NextMove = "X\nmove";
                    }
                }, p => true));
            }
        }
        public ICommand ButtonClick1
        {
            get
            {
                return buttonClick1 ?? (buttonClick1 = new BaseClass.RelayCommand((p) =>
                {
                    game.buttonClick(1);
                    NextMove = game.nextPlayerString();
                    string[] temp = (string[])Board.Clone();
                    temp[1] = game.board[1];
                    Board = temp;
                    bool[] temp2 = (bool[])ButtonsUse.Clone();
                    temp2[1] = game.emptyField[1];
                    ButtonsUse = temp2;
                    if (game.checkGame())
                    {
                        ButtonsUse = new bool[9] { true, true, true, true, true, true, true, true, true };
                        Board = new string[9] { "", "", "", "", "", "", "", "", "" };
                        NextMove = "X\nmove";
                    }
                }, p => true));
            }
        }
        public ICommand ButtonClick2
        {
            get
            {
                return buttonClick2 ?? (buttonClick2 = new BaseClass.RelayCommand((p) =>
                {
                    game.buttonClick(2);
                    NextMove = game.nextPlayerString();
                    string[] temp = (string[])Board.Clone();
                    temp[2] = game.board[2];
                    Board = temp;
                    bool[] temp2 = (bool[])ButtonsUse.Clone();
                    temp2[2] = game.emptyField[2];
                    ButtonsUse = temp2;
                    if (game.checkGame())
                    {
                        ButtonsUse = new bool[9] { true, true, true, true, true, true, true, true, true };
                        Board = new string[9] { "", "", "", "", "", "", "", "", "" };
                        NextMove = "X\nmove";
                    }
                }, p => true));
            }
        }
        public ICommand ButtonClick3
        {
            get
            {
                return buttonClick3 ?? (buttonClick3 = new BaseClass.RelayCommand((p) =>
                {
                    game.buttonClick(3);
                    NextMove = game.nextPlayerString();
                    string[] temp = (string[])Board.Clone();
                    temp[3] = game.board[3];
                    Board = temp;
                    bool[] temp2 = (bool[])ButtonsUse.Clone();
                    temp2[3] = game.emptyField[3];
                    ButtonsUse = temp2;
                    if (game.checkGame())
                    {
                        ButtonsUse = new bool[9] { true, true, true, true, true, true, true, true, true };
                        Board = new string[9] { "", "", "", "", "", "", "", "", "" };
                        NextMove = "X\nmove";
                    }
                }, p => true));
            }
        }
        public ICommand ButtonClick4
        {
            get
            {
                return buttonClick4 ?? (buttonClick4 = new BaseClass.RelayCommand((p) =>
                {
                    game.buttonClick(4);
                    NextMove = game.nextPlayerString();
                    string[] temp = (string[])Board.Clone();
                    temp[4] = game.board[4];
                    Board = temp;
                    bool[] temp2 = (bool[])ButtonsUse.Clone();
                    temp2[4] = game.emptyField[4];
                    ButtonsUse = temp2;
                    if (game.checkGame())
                    {
                        ButtonsUse = new bool[9] { true, true, true, true, true, true, true, true, true };
                        Board = new string[9] { "", "", "", "", "", "", "", "", "" };
                        NextMove = "X\nmove";
                    }
                }, p => true));
            }
        }
        public ICommand ButtonClick5
        {
            get
            {
                return buttonClick5 ?? (buttonClick5 = new BaseClass.RelayCommand((p) =>
                {
                    game.buttonClick(5);
                    NextMove = game.nextPlayerString();
                    string[] temp = (string[])Board.Clone();
                    temp[5] = game.board[5];
                    Board = temp;
                    bool[] temp2 = (bool[])ButtonsUse.Clone();
                    temp2[5] = game.emptyField[5];
                    ButtonsUse = temp2;
                    if (game.checkGame())
                    {
                        ButtonsUse = new bool[9] { true, true, true, true, true, true, true, true, true };
                        Board = new string[9] { "", "", "", "", "", "", "", "", "" };
                        NextMove = "X\nmove";
                    }
                }, p => true));
            }
        }
        public ICommand ButtonClick6
        {
            get
            {
                return buttonClick6 ?? (buttonClick6 = new BaseClass.RelayCommand((p) =>
                {
                    game.buttonClick(6);
                    NextMove = game.nextPlayerString();
                    string[] temp = (string[])Board.Clone();
                    temp[6] = game.board[6];
                    Board = temp;
                    bool[] temp2 = (bool[])ButtonsUse.Clone();
                    temp2[6] = game.emptyField[6];
                    ButtonsUse = temp2;
                    if (game.checkGame())
                    {
                        ButtonsUse = new bool[9] { true, true, true, true, true, true, true, true, true };
                        Board = new string[9] { "", "", "", "", "", "", "", "", "" };
                        NextMove = "X\nmove";
                    }
                }, p => true));
            }
        }
        public ICommand ButtonClick7
        {
            get
            {
                return buttonClick7 ?? (buttonClick7 = new BaseClass.RelayCommand((p) =>
                {
                    game.buttonClick(7);
                    NextMove = game.nextPlayerString();
                    string[] temp = (string[])Board.Clone();
                    temp[7] = game.board[7];
                    Board = temp;
                    bool[] temp2 = (bool[])ButtonsUse.Clone();
                    temp2[7] = game.emptyField[7];
                    ButtonsUse = temp2;
                    if (game.checkGame())
                    {
                        ButtonsUse = new bool[9] { true, true, true, true, true, true, true, true, true };
                        Board = new string[9] { "", "", "", "", "", "", "", "", "" };
                        NextMove = "X\nmove";
                    }
                }, p => true));
            }
        }
        public ICommand ButtonClick8
        {
            get
            {
                return buttonClick8 ?? (buttonClick8 = new BaseClass.RelayCommand((p) =>
                {
                    game.buttonClick(8);
                    NextMove = game.nextPlayerString();
                    string[] temp = (string[])Board.Clone();
                    temp[8] = game.board[8];
                    Board = temp;
                    bool[] temp2 = (bool[])ButtonsUse.Clone();
                    temp2[8] = game.emptyField[8];
                    ButtonsUse = temp2;
                    if (game.checkGame())
                    {
                        ButtonsUse = new bool[9] { true, true, true, true, true, true, true, true, true };
                        Board = new string[9] { "", "", "", "", "", "", "", "", "" };
                        NextMove = "X\nmove";
                    }
                }, p => true));
            }
        }

    }
}
