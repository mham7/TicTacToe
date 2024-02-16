using System.Drawing;
using TicTacToe.Components.Shared;
using TicTacToe.Entities;
using TicTacToe.Entities.Enums;
using TicTacToe.Services.Interfaces;

namespace TicTacToe.Services
{
    public class GameService:IGamService
    {
        private readonly IPlayerService _player;
       

        public static Game game = new Game
        {
            isGameActive = false,
            isDraw = false,
            boardsize = 0,
         };
           
        public GameService(IPlayerService player)
        {
           
            _player = player;
           
        }
       
        public char SetMove(int row,int column)
        {
            char move = _player.GetMove();
            if (IsMoveValid(move, row, column))
            {
                game.Board[row, column] = move;
                return move;
            }
            else
            {
                return '.';
            }
        }

        public void IntializeBoard(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    game.Board[i, j] = '.';
                }
            }
                 }
        public void setBoardsize(int size)
        {
            game.boardsize = size;
            game.Board = new char[size, size];
            IntializeBoard(size);


        }
        public void StartGame(int size)
        {
            game.isGameActive = true;
             setBoardsize(size);
            
        }

     
        public void StopGame()
        {
            game.isGameActive = false;
            
           
        }
      

        public bool IsMoveValid(char move,int row, int column)
        {
            if (row < 0 || row >= game.boardsize || column < 0 || column >= game.boardsize)
            {
                return false; 
            }

            if (game.Board[row, column] != '.')
            {
                return false; 
            }

            return true;
        }

        
        public int CheckForWinner()
        {
            Player a = _player.GetCurrentPlayer();
          
            if (CheckDiagonally())
            {
                return a.playerId;
            }
            for (int val = 0; val < game.boardsize; val++)
            {
                if (AreEquallHorizontally(val))
                {
                    return a.playerId;
                }
                if (AreEquallVertically(val))
                {
                    return a.playerId;
                }

              }
            if (isDraw())
            {
                return 3;
            }
            _player.SwitchPlayer();
            return 0;
        }

        public bool AreEquallHorizontally(int val)
        {
            int count = 0;
            char value = game.Board[val, 0];
            if (value != '.')
            {
                for (int col = 0; col < game.boardsize; col++)
                {
                    if (value == game.Board[val, col])
                    {
                        count++;
                    }
                }
                if (count == game.boardsize)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AreEquallVertically(int val)
        {
            int count = 0;
            char value = game.Board[0, val];
            if (value != '.')
            {
                for (int row = 0; row < game.boardsize; row++)
                {
                    if (value == game.Board[row, val])
                    {
                        count++;
                    }
                }
                if (count == game.boardsize)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckDiagonally()
        {
            int firstcount = 0;
            int secondcount = 0;
            char firstvalue = game.Board[0, 0];
            char secondvalue= game.Board[0, game.boardsize - 1];
            if (firstvalue != '.')
            {
                for (int index = 0; index < game.boardsize; index++)
                {
                    if (firstvalue == game.Board[index, index])
                    {
                        firstcount++;
                    }
                }
                if (firstcount == game.boardsize)
                {
                    return true;
                }
            }

            if (secondvalue != '.') { 
                for (int i = 0; i < game.boardsize; i++)
                {
                    if (game.Board[i, game.boardsize - 1 - i] == secondvalue)
                    {
                        secondcount++;
                    }
                }
                if (secondcount == game.boardsize)
                {
                    return true;
                }
            }


            return false;
        }

        public bool isDraw()
        {
            if (checkFilled(game.Board)){
                StopGame();
                return true;
            }
            else return false;
        }

        public bool isGameStarted()
        {
            return game.isGameActive;
          
        }

        public void ResetGame()
        {
            game.Board = null;
            game.boardsize = 0;
        }
        public char GetBoardValue(int row, int column)
        {
            return game.Board[row, column]; 
        }
        public bool checkFilled(char[,] array)
        {
            foreach (char c in array)
            {
                if (c == null || c == '.')
                {
                    return false;
                }
            }
            return true;
        }
    }
}

