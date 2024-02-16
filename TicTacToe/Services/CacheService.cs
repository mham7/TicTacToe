using TicTacToe.Services.Interfaces;

namespace TicTacToe.Services
{
    public class CacheService: ICacheService
    {
        static Dictionary<string, int> RowsDictionary = new Dictionary<string, int>();
        static Dictionary<string, int> ColumnsDictionary = new Dictionary<string, int>();
         static Dictionary<string, char> ActionDictionary = new Dictionary<string, char>();
        private readonly IPlayerService _player;
        public CacheService(IPlayerService player)
        {
            _player = player;
        }

        public int GetRow(string id)
        {
            int column = RowsDictionary[id];
            return column;
        }

        public async Task AddMove(string id)
        {
            ActionDictionary[id] = _player.GetMove();           
        }
        public char GetMove(string id)
        {
            char move = ActionDictionary[id];
            return move;
        }
        public int GetColumn(string id)
        {
            int column = ColumnsDictionary[id];
            return column;
        }

        public async Task<string> UpdateSquare(int i, int j,string key)
        {
            int a = i;
            int b = j;
            RowsDictionary[key] = a;
            ColumnsDictionary[key] = b;
            return await Task.FromResult(key);
        }
    }
}
