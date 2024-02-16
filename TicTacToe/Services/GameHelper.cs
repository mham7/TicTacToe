using TicTacToe.Services.Interfaces;

namespace TicTacToe.Services
{
    public class GameHelper : IGameHelper
    {

        public GameHelper()
        {
          
        }

        public bool IsBoardFull(char[,] array)
        {
            foreach(char c in array)
            {
                if (c ==null || c == '.')
                {
                    return false;
                }
            }
            return true;
        }
        public char[,] InitializeBoard(char[,] array,int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = '.';
                }
            }
            return array;
        }
        
        
    }
}
