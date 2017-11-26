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
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine()); // a - 1-ое число
            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine()); // b - 2-ое число
            Console.WriteLine("Введите третье число");
            int c = int.Parse(Console.ReadLine()); // c - 3-ее число
            Console.WriteLine("Введите четвёртое число");
            int d = int.Parse(Console.ReadLine()); // d - 4-ое число
            int sum = a + b + c + d;
            Console.WriteLine("Сумма равна - " + sum);
            Console.ReadLine();
        }
         
    }
}
