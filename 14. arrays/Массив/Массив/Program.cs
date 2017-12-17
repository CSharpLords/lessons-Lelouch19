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
            int[] Numbers = {5, 7, 98, - 7, 100};
            Numbers[2] = 34;
            for (int n = 0; n < Numbers.Length; n = n + 1)
            {
                Numbers[n] = Numbers[n] * 2;
                Console.WriteLine(Numbers[n]);
            }
            Console.ReadLine();
        }
    }
}
