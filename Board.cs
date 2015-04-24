using System;
using System.Collections.Generic;

namespace Roguelike
{
    public class Board
    {
        private List<List<string>> _board;
        private Player _player;

        public Board()
        {
            _player = new Player(0,0);
            Refresh();
        }

        private void Wipe()
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

        private void Refresh()
        {
            Wipe();
            _board[_player.Row][_player.Col] = _player.ToString();
        }

        public List<List<string>> Get()
        {
            return _board;
        }

        public string ToString()
        {
            string s = "";
            foreach (List<string> row in _board)
            {
                foreach (string square in row)
                {
                    s += square;
                }
                s += "\n";
            }
            return s;
        }

    }
}