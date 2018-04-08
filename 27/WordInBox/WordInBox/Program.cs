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
            Console.WriteLine("Введите слово:");
            string text = Console.ReadLine();
            WriteUnder(text);

            Console.ReadLine();
        }
        static void WriteUnder(string text)
        {
            string symbols = "";
            for (int x = 0; x < text.Length; x ++)
            {
                symbols = symbols + "-";
            }
            Console.WriteLine("-" + symbols + "-");
            Console.WriteLine("-" + text + "-");
            Console.WriteLine("-" + symbols + "-");
        }
    }
}
