using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Конвертер_расстояния
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расстояние в см");
            string name = Console.ReadLine();
            int digit1 = 100;
            //Расстояние в метрах
            int digit2 = 10;
            //Расстояние в дециметрах
            double sum1 = (double)int.Parse(name) / 100;
            Console.WriteLine("Расстояние в метрах " + sum1);
            Console.ReadLine();
            double sum2 = (double)int.Parse(name) / 10;
            Console.WriteLine("Расстояние в дециметрах " + sum2);
            Console.ReadLine();
        }
    }
}