using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike
{
    public class BoardView
    {
        public void CreateBoard(List<List<string>> board)
        {
            Console.WriteLine("@@@@@@@@@@@");
            for (int i = 0; i < board.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("@");
                }
                for (int j = 0; j < board[i].Count; j++)
                {
                    Console.Write(board[i][j]);
                }
                if (i == 8)
                {
                    Console.Write(" \n");
                }
                else
                {
                    Console.Write("@\n");
                }
            }
            Console.WriteLine("@@@@@@@@@@@");
        }

        public void ClearBoard()
        {
            Console.Clear();
        }
    }
}
