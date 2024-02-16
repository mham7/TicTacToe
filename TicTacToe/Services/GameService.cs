using TicTacToe.Components.Shared;
using TicTacToe.Entities;
using TicTacToe.Entities.Enums;
using TicTacToe.Services.Interfaces;

namespace TicTacToe.Services
{
    public class GameService:IGamService
    {
        private readonly IPlayerService _player;
        private readonly ICacheService _cache;

        public static Game game = new Game
        {
            isGameActive = false,
            isDraw = false,
            boardsize = 0,
         };
           
        public GameService(IPlayerService player,ICacheService cache)
        {
            //game = new Game()
            //{
            //    isGameActive = false,
            //    isDraw = false,
            //};
            _player = player;
            _cache = cache;
        }
        public char GetMove(string id)
        {
            int row= _cache.GetRow(id);
            int column = _cache.GetColumn(id);
            return game.Board[row, column];
        }
        public async Task SetMove(int row,int column)
        {
            char move = _player.GetMove();
            if (IsMoveValid(move, row, column))
            {
                game.Board[row, column] = move;
            }

        }
        public async Task setBoardsize(int size)
        {
            game.boardsize = size;
            game.Board = new char[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    game.Board[i, j] = ' '; 
                }
            }
        }
        public async Task StartGame(int size)
        {
            game.isGameActive = true;
            await setBoardsize(size);
            
        }


        public void StopGame()
        {
            game.isGameActive = true;
            game.boardsize = 0;
        }
        public async Task MakeMove(string id)
        {
            //await _cache.UpdateSquare(i,j,id);
            int row = _cache.GetRow(id);
            int column = _cache.GetColumn(id);
            await SetMove(row, column);
             //await _cache.AddMove(id);
        }

        public bool IsMoveValid(char move,int row, int column)
        {
            if (row < 0 || row >= game.boardsize || column < 0 || column >= game.boardsize)
            {
                return false; 
            }

            if (game.Board[row, column] != '\0')
            {
                return false; 
            }

            return true;
        }

        
        public async Task DetermineWinner()
        {

            if (CheckDiagonally())
            {

            }
            for (int val = 0; val < game.boardsize; val++)
            {
                if (AreEquallHorizontally(val))
                {
                   
                }
                if (AreEquallVertically(val))
                {

                }

              }
        }

        public bool AreEquallHorizontally(int val)
        {
            int count = 0;
            char value = game.Board[val,0];
            for(int col=0; col < game.boardsize; col++)
            {  if(value == game.Board[val, col])
                {
                count++;
                }
            }
            if (count == game.boardsize)
            {
                return true;
            }
            return false;
        }

        public bool AreEquallVertically(int val)
        {
            int count = 0;
            char value = game.Board[0, val];
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
            return false;
        }

        public bool CheckDiagonally()
        {
            int count = 0;
            char value = game.Board[0, 0];
            for (int index = 0; index < game.boardsize; index++)
            {
                if (value == game.Board[index, index])
                {
                    count++;
                }
            }
            if (count == game.boardsize)
            {
                return true;
            }
            return false;
        }

        public bool isDraw()
        {
            return false;
        }

        public bool isGameStarted()
        {
            return game.isGameActive;
          
        }

        public char GetBoardValue(int row, int column)
        {
            return game.Board[row, column]; 
        }
    }
}
