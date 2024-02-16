namespace TicTacToe.Services.Interfaces
{
    public interface ICacheService
    {
        Task<string> UpdateSquare(int i, int j,string key);
        Task AddMove(string id);
        int GetRow(string id);
        char GetMove(string id);
        int GetColumn(string id);
    }
}
