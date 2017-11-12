using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Random rand = new Random();
                int n = rand.Next(0, 100000);
                Console.WriteLine(n);
                Console.ReadLine();
            }
        }
    }
}