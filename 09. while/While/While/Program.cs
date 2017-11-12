using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int second = 0;
            while (true)
            {
                Console.WriteLine(second + 99999999999999);
                second = second + 1;

            }
        }
    }
}
