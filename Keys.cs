using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike
{
    public class Keys
    {
        public ConsoleKey ReadingKeys()
        {
            var key = Console.ReadKey().Key;
            bool keepReading = true;

            while (keepReading)
            {
                if (key == ConsoleKey.RightArrow)
                {
                    // Tell the controller to do something;
                }
                if (key == ConsoleKey.LeftArrow)
                {
                    // Tell the controller to do something else
                }
                if (key == ConsoleKey.UpArrow)
                {
                    // tell controller to do something
                }
                if (key == ConsoleKey.DownArrow)
                {
                    // tell controller to do something 
                }
                if (key == ConsoleKey.Q)
                {
                    keepReading = false;
                }
                else
                {
                    Console.WriteLine("Please use the arrow keys");
                }
            }
            return key;
        }
    }
}
