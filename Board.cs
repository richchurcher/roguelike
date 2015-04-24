using System;
using System.Collections.Generic;

namespace Roguelike
{
    public class Board
    {
        private List<List<string>> _board;
        private Player _player;
        private List<Trap> _traps; 

        public Board()
        {
            _player = new Player(0,0);
            CreateTraps();
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

        private void CreateTraps()
        {
            _traps = new List<Trap>
            {
                new Trap(5,5),
                new Trap(4,7),
                new Trap(2,3),
                new Trap(6,2),
                new Trap(1,7),
            };
        }

        public bool CheckForTrap()
        {
            return _board[_player.Row][_player.Col] != " ";
        }

        private void Refresh()
        {
            Wipe();
            _board[_player.Row][_player.Col] = _player.ToString();
            foreach (Trap t in _traps)
            {
                _board[t.Row][t.Col] = t.ToString();
            }
        }

        public List<List<string>> Get()
        {
            return _board;
        }

        public override string ToString()
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