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
            while (sum < 4)
            {
                Console.WriteLine("Введите число.");
                int n = int.Parse(Console.ReadLine());
                sum = sum + 1;
            }
            Console.WriteLine("Сумма чисел - " + sum);  
            Console.ReadLine();
        }
    }
}
