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
            for (int Shaitanka = 10; Shaitanka <= 25; Shaitanka = Shaitanka + 1)        //Shaitanka - это число
            {
                Console.WriteLine(Shaitanka + " " + Shaitanka + "." + 4);
            }
            Console.ReadLine();
        }
    }
}
