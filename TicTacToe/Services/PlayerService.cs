using TicTacToe.Entities;
using TicTacToe.Entities.Enums;
using TicTacToe.Services.Interfaces;

namespace TicTacToe.Services
{
    public class PlayerService:IPlayerService
    {
        public static List<Player> players = new List<Player>
            {  new Player
            {
                playerId = 1,
                Playerturn=true,
                Move=PlayerAction.X,
               
            },
             new Player
            {
                playerId = 2,
                Playerturn=false,
                Move=PlayerAction.O,
            }
            };
        public PlayerService() { }

        

        public Player GetCurrentPlayer()
        {
           Player activeplayer=players.FirstOrDefault(p => p.Playerturn);
            return activeplayer;
        }
        public int GetPlayerId()
        {
            Player a = GetCurrentPlayer();
            return a.playerId;
        }
        public char GetMove()
        {
            Player player = GetCurrentPlayer();
            if(player.Move== PlayerAction.X)
            {
                return 'X';
            }
            else
            {
                return 'O';
            }
        }
        public Player GetWaitingPlayer()
        {
            Player activeplayer = players.FirstOrDefault(p => p.Playerturn == false);
            return activeplayer;
        }
        public async Task SwitchPlayer()
        {
            Player activeplayer=  GetCurrentPlayer();
            Player waitingplayer= GetWaitingPlayer();
            waitingplayer.Playerturn = true;
            activeplayer.Playerturn= false;
        }
    
    }
}
