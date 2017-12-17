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
            int sum = 0;
            int[]massif = {12, 1, 97, 1, 1};
            for (int n = 0; n < massif.Length; n = n + 1)
            {
                sum = sum + massif[n];
            }
            Console.WriteLine("Сумма всех чисел - " + sum);
            Console.ReadLine();
        }
    }
}
