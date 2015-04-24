using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike
{
    public class BoardView
    {
        public BoardView(List<List<string>> board )
        {

            for (int i = 0; i < board.Count; i++)
            {
                for (int j = 0; j < board[i].Count; j++)
                {
                    Console.Write(board[i][j]);
                }
                Console.Write("\n");
            }               
        }

        public void ClearBoard()
        {
           Console.Clear();
        }
    }
}
