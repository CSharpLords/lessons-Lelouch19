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
            double[] numbers = {0.4, 12, 78, 87.2, 44.4};
            for (int n = 0; n < numbers.Length; n = n + 1)
            {
                if (numbers[n] > 10)
                {
                    numbers[n] = Math.Sqrt(numbers[n]);
                    Console.WriteLine(numbers[n]);

                }
                else
                {
                    Console.WriteLine(numbers[n]);
                }
            }
            Console.ReadLine();
        }
    }
}