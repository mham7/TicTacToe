using TicTacToe.Entities.Enums;

namespace TicTacToe.Entities
{
    public class Player
    {
        public int playerId {  get; set; }
        public  bool Playerturn { get; set; }
        public PlayerAction Move { get; set; }

    }
}
