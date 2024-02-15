using TicTacToe.Entities;

namespace TicTacToe.Services.Interfaces
{
    public interface IPlayerService
    {
        Player GetCurrentPlayer();
        Player GetWaitingPlayer();
        void SwitchPlayer();
        char GetMove();
    }
}
