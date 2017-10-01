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
            Console.WriteLine("Во сколько игр вы сыграли?");
            int games1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Во скольких играх ты выиграл?");
            int games2 = int.Parse(Console.ReadLine());
            double games = (double) games2 / games1;
            Console.WriteLine("Ваш винрейт = " + games);
            Console.ReadLine();
        }
    }
}
