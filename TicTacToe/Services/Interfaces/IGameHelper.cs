namespace TicTacToe.Services.Interfaces
{
    public interface IGameHelper
    {
        bool IsBoardFull(char[,] array);
        char[,] InitializeBoard(char[,] array,int size);
    }
}
