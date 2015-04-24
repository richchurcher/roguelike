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
                    return key;
                }
                if (key == ConsoleKey.LeftArrow)
                {
                    return key;
                }
                if (key == ConsoleKey.UpArrow)
                {
                    return key;
                }
                if (key == ConsoleKey.DownArrow)
                {
                    return key;
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
