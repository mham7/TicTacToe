namespace TicTacToe.Entities
{
    public class Game
     {
        public char[,] Board {  get; set; }
         public int boardsize {  get; set; }
        public bool isGameActive { get; set; }
        public bool isDraw {  get; set; }


    }
}
