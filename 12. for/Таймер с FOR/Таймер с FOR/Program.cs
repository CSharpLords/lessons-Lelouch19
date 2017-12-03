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
            for (int Time = 0; Time <= 10; Time = Time + 1)
            {
                Console.WriteLine("Time - " + Time);
                Thread.Sleep(500);
            }
            Console.ReadLine();
        }
    }
}
