using TicTacToe.Entities;

namespace TicTacToe.Services.Interfaces
{
    public interface IPlayerService
    {
        Player GetCurrentPlayer();
        Player GetWaitingPlayer();
        int GetPlayerId();
        Task SwitchPlayer();
        char GetMove();
    }
}
