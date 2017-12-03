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
            Console.WriteLine("Введите слово.");
            string Word = Console.ReadLine().ToLower();


            for (int letter = 0; letter < Word.Length; letter = letter + 1)
            {
                if (Word[letter] == 'и')
                {
                    Console.WriteLine("В слове " + Word + " буква 'и' есть!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("В слове " + Word + " буква 'и' нет!");
            Console.ReadLine();
        }
    }
}
