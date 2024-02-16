using TicTacToe.Entities;

namespace TicTacToe.Services.Interfaces
{
    public interface IGamService
    {
        Task setBoardsize(int size);
        char SetMove(int row, int column);
        bool IsMoveValid(char move,int row, int column);
        char GetBoardValue(int row, int column);
        int CheckForWinner();
        void StopGame();
        Task StartGame(int size);
        bool isDraw();
        bool isGameStarted();
        bool AreEquallHorizontally(int val);
        bool AreEquallVertically(int val);
        bool CheckDiagonally();
        void ResetGame();
        bool checkFilled(char[,] array);
       
    }


}
}
