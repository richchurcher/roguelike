using System.Collections.Generic;

namespace Roguelike
{
    public class Board
    {
        private List<List<string>> _board;
        private Player _player;

        public Board()
        {
            InitBoard();
            _player = new Player(0,0);
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

        public void Update()
        {
            _board[_player.Row][_player.Col] = _player.ToString();
        }

        public List<List<string>> Get()
        {
            return _board;
        }


    }
}