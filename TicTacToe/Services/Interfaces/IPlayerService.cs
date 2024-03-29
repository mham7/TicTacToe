﻿using TicTacToe.Entities;

namespace TicTacToe.Services.Interfaces
{
    public interface IPlayerService
    {
        Player GetCurrentPlayer();
        Player GetWaitingPlayer();
        int GetPlayerId();
        void SwitchPlayer();
        char GetMove();
    }
}
