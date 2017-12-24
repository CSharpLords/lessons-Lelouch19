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
            int[] Victories = { 1, 0, 78, 5, 29, 6, 5, 38, 7, 9, 1, 12, 13, 14, 2, 7, 3, 18, 4, 0 };
            for (int n = 0; n < Victories.Length; n = n + 1)
            {
                if (Victories[n] < 3)
                {
                    Console.WriteLine(n);
                }
            }
            Console.ReadLine();
        }
    }
}
