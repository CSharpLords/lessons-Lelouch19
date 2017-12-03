using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int Dollar = 0; Dollar <= 20; Dollar = Dollar + 1)
            {
                int ChangeRate = 58;
                Console.WriteLine(Dollar + " $ = " + ChangeRate * Dollar);
            }
            Console.ReadLine();
        }
    }
}
