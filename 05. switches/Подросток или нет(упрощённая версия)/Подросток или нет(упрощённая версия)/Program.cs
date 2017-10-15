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
            Console.WriteLine("Напишите свой возраст");
            int age = int.Parse(Console.ReadLine());
            if (age >= 10 && age < 20)
            {
                Console.WriteLine("Вы подросток!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Вы не подросток");
                Console.ReadLine();
            }
        }
    }
}
