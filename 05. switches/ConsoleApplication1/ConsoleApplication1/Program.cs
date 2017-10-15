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
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c = int.Parse(Console.ReadLine());
            if (a >= b && a >= c)
            {
                Console.WriteLine("Наибольшее число " + a);
            }
            else
            {
                if (b >= c && b >= a)
                {
                    Console.WriteLine("Наибольшее число " + b);
                }
                else
                {

                    if (c >= b && c >= a)
                    {
                        Console.WriteLine("Наибольшее число " + c);
                    }
                }
            }
            Console.ReadLine();
            


        }
    }
}
