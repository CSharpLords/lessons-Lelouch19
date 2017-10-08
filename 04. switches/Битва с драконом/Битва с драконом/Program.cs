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
            Console.WriteLine("Введите возраст дракона");
            int age = int.Parse(Console.ReadLine());
            if (age < 150)
            {
                Console.WriteLine("Введите количество хп.Не больше 100");
                int hp = int.Parse(Console.ReadLine());
                if (hp < 50)
                {
                    Console.WriteLine("Вы можете убить этого злобного дракона!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("У дракона слишком много хп.Бегите!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Вы не можете победить этого зловещего дракона!");
                Console.ReadLine();
            }
 

        }
    }
}
