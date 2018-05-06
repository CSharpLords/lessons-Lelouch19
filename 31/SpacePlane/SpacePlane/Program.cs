using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rend = new Random();
            SpacePlane[] spacePlanes = new SpacePlane[10];

            for (int i = 0; i < spacePlanes.Length; i++)
            {
                spacePlanes[i] = new SpacePlane(rend.Next(1, 5));
            }

            while (true)
            {
                for (int i = 0; i < spacePlanes.Length; i++)
                {
                    spacePlanes[i].Fly();
                    if(spacePlanes[i].dist.Length == 12)
                    {
                        Console.WriteLine("Финиш!!!");
                        break;
                    }
                }
                Thread.Sleep(1000);
                Console.Clear();
            }

            Console.ReadLine();
        }

    }
}
