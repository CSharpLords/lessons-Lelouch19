using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = rand.Next(0, 100000);
            Console.WriteLine(n);
            while (true)
            {
                int number = rand.Next(0, 50);
                Console.WriteLine("ЧИСЛО - " + number);
                Thread.Sleep(2000);
                Console.Clear();

                Console.WriteLine("Введите число которое запомнили");
                int guess = int.Parse(Console.ReadLine());

                if (number == guess)
                {
                    Console.WriteLine("Вы вели число верно");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Число не то");
                    Console.ReadLine();
                    Console.Clear();
                }


            }
        }
    }
}