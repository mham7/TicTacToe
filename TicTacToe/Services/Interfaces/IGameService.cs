using TicTacToe.Entities;

namespace TicTacToe.Services.Interfaces
{
    public interface IGamService
    {
        void setBoardsize(int size);
        char SetMove(int row, int column);
        bool IsMoveValid(char move,int row, int column);
        char GetBoardValue(int row, int column);
        int CheckForWinner();
        void StopGame();
        void StartGame(int size);
        bool isDraw();
        bool isGameStarted();
        bool AreEquallHorizontally(int val);
        bool AreEquallVertically(int val);
        bool CheckDiagonally();
        void ResetGame();
        bool checkFilled(char[,] array);
       
    }


}

