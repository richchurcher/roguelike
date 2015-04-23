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
        public DummyModel Model  { get; set; }
        public DummyView View { get; set; }

        public Roguelike_Controller()
        {
            Model = new DummyModel();
            View = new DummyView();
        }

        public void MoveCharacter()
        {
            ConsoleKeyInfo direction = View.MoveInput();
            List<List<String>> updatedBoard = DummyModel.DoSomethingWithMove(direction);
            View.UpdateBoard(updatedBoard);
        }






    }
}
