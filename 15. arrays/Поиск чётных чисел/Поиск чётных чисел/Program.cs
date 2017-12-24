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
            int[] Massif = { 1, 78, 89, -156, 2};
            for (int n = 0; n < Massif.Length; n = n + 1)
            {
                int Rest = Massif[n] % 2;
                if (Rest == 0)
                {
                    Console.WriteLine(Massif[n]);
                }
            }
            Console.ReadLine();
        }
    }
}
