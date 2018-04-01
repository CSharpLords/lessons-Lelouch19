using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcPower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите степень: ");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine(n + "^" + e + "=" + Power(n, e));
            Console.ReadLine();
        }

        static int Power(int number, int exponent)
        {
            int c = 1;
            for (int x = 0; x < exponent; x++)
            {
               c = c * number;
                
            }
            return c;
        }
    }
}
