using System;

namespace AsteriskBox {
	class Program {
		static void Main(string[] args) 
        {
			PrintAsteriskBox(30, 30);
			Console.ReadLine();
		}
         static void PrintAsterisks(int dlina)
        {
            string zvezdochka = "";
            for (int x = 0; x < dlina; x++)
            {
                zvezdochka = zvezdochka + "*";
            }
            Console.WriteLine(zvezdochka);

        }

         static void PrintAsteriskBox(int x , int y)
         {
             for(int c = 0;c < x;c ++)
             {
                 PrintAsterisks(y);

             }
         }
	}
}
