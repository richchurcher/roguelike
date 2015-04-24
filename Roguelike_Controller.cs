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
        public Board _MainBoard  { get; set; }
        public BoardView _view { get; set; }
        //public Player player { get; set; }

        public Roguelike_Controller()
        {
            _MainBoard = new Board();
            //player = new Player(0, 0);
            _view = new BoardView(_MainBoard.Get());
            
        }
        
        public void MoveCharacter()
        {
            ConsoleKeyInfo direction = _view.MoveInput();
            List<List<String>> updatedBoard = _MainBoard.DoSomethingWithMove(direction);
            _view.ClearBoard();
            _view.BoardView(updatedBoard);
            
        }

        public void Game()
        {
            while (!_MainBoard.Finished())
            {
                MoveCharacter();
            }
            Console.WriteLine("You won the game!");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

    }
}
