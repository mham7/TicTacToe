using TicTacToe.Entities;

namespace TicTacToe.Services.Interfaces
{
    public interface IPlayerService
    {
        Player GetCurrentPlayer();
        Player GetWaitingPlayer();
        Task SwitchPlayer();
        char GetMove();
    }
}
