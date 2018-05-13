using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirAttack
{
    class Bomber
    {
        static int x = 0;
        public string plane = "-->";
        public int speed = 100;
        public void Draw()
        {

                int end = Console.WindowWidth;
                x = x + 3;
                if (end - 1 < x)
                {
                    x = 0;
                }
                Console.SetCursorPosition(x, 0);
                Console.WriteLine(plane);
        }
    }
}
