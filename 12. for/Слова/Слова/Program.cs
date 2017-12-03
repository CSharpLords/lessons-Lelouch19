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
            Console.WriteLine("ВВЕДИТЕ СЛОВО!СРОЧНО!");
            string Word = Console.ReadLine().ToLower();
            int End = Word.Length - 1;

            if (Word[0] == Word[End])
            {
                Console.WriteLine("Слово идеально!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Не о чём слово...");
                Console.ReadLine();
            }
        }
    }
}
