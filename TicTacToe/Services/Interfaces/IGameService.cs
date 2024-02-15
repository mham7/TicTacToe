namespace TicTacToe.Services.Interfaces
{
    public interface IGamService
    {
        Task setBoardsize(int size);
        void MakeMove(int row, int column);
        bool IsMoveValid(char move,int row, int column);

        char GetBoardValue(int row, int column);
        Task DetermineWinner();
        Task StartGame(int size);
        bool isDraw();
        bool isGameStarted();
        bool AreEquallHorizontally(int val);
        bool AreEquallVertically(int val);
        bool CheckDiagonally();


    }
}
