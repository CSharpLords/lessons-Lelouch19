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
            Console.WriteLine("В математике функция `sign(x)` (знак числа) определена так:");
            Console.WriteLine("Введите значение x");
            int x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine("sign(x) = " + 1);
            }
            else if (x < 0){
                Console.WriteLine("sign(x) = -1 ");
            }
            else if (x == 0){
                Console.WriteLine("sign(x) = " + 0);
            }
            Console.ReadLine();

        }
    }
}
