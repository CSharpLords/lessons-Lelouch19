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
            int number = 0;
            Random rand = new Random();
            string[] nouns = {"Артемий", "Ашотик", "Владимир", "Олег"};
            string[] adverbs = {"быстро", "медленно", "так себе", "стандартно"};
            string[] verbs = {"торгует", "пляшет", "убегает", "работает"};

            while (number <= 5)
            {
                int n = rand.Next(0, 2);
                int a = rand.Next(0, 2);
                int x = rand.Next(0, 2);
                Console.WriteLine(nouns[n] + " " + adverbs[a] + " " + verbs[x]);
                number = number + 1;

            }
            Console.ReadLine();
        }
    }
}
