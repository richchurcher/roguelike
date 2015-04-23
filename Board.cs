using System.Collections.Generic;

namespace Roguelike
{
    public class Board
    {
        private List<List<string>> _board;

        public List<List<string>> Get()
        {
            return _board;
        }
    }
}