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
            double[] Numbers = { 5, 7, 98, -7, 100 };

            for (int n = 0; n < Numbers.Length; n = n + 1)
            {
                double N = Numbers[n] / Numbers[0];
                Console.WriteLine(N);
            }
            Console.ReadLine();
        }
    }
}
