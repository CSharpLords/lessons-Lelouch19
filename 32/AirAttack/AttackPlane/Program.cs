using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AirAttack
{
    class Program
    {
        //https://www.omfgdogs.com/#
        //https://github.com/CSharpWizards/lessons_w-pchuck77/tree/master/13.%20classes
        static void Main(string[] args)
        {
            int end = Console.WindowWidth;
            while (true)
            {
                Update();
                Thread.Sleep(100);
                Console.Clear();
            }
        }
        static void Update()
        {
            Bomber plane = new Bomber();
            plane.Draw();
        }
    }
}
