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
            Floor itazh = new Floor();
            for (int i = 0; i < itazh.Length; i++)
            {
                itazh[i].Move();
            }
            Console.ReadLine();
        }
    }
}
