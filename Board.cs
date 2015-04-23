using System.Collections.Generic;

namespace Roguelike
{
    public class Board
    {
        private List<List<string>> _board;

        public Board()
        {
            InitBoard();
        }

        private void InitBoard()
        {
            _board = new List<List<string>>(9)
            {
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
                new List<string>(9) { " ", " ", " ", " ", " ", " ", " ", " ", " "},
            };
        }

        public List<List<string>> Get()
        {
            return _board;
        }


    }
}