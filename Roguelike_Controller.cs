using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike
{
    class Roguelike_Controller
    {
        public Board _board  { get; set; }
        //public Player player { get; set; }
        public DummyView _view { get; set; }

        public Roguelike_Controller()
        {
            _board = new Board();
            //player = new Player(0, 0);
            _view = new DummyView();
            
        }

        public void MoveCharacter()
        {
            ConsoleKeyInfo direction = _view.MoveInput();
            List<List<String>> updatedBoard = _board.DoSomethingWithMove(direction);
            _view.ClearBoard();
            _view.BoardView(updatedBoard);
            
        }
        
    }
}
