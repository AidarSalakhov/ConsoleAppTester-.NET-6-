using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTester__.NET_
{
    internal class MessageColor
    {
        public static void SetColor(string color, bool on)
        {
            if (color == "Green" & on)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if(color == "Green" & !on)
            {
                Console.ResetColor();
            }

            if (color == "Red" & on)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == "Red" & !on)
            {
                Console.ResetColor();
            }
        }
    }
}
