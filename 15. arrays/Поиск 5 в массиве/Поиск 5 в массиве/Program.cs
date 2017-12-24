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
            int[]Massif = { 98, 89, 462, 5, 0 };
            for (int n = 0; n < Massif.Length; n = n + 1)
            {
                if (Massif[n] == 5)
                {
                    Console.WriteLine(n);
                    break;
                }
            }
            Console.ReadLine();
        }

    }
}
