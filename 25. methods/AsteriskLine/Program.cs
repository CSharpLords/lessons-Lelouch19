using System;
namespace AsteriskLine 
{
	class Program 
    {
		static void Main(string[] args)
        {
			PrintAsterisks(5);
			Console.ReadLine();
		}
        static void PrintAsterisks(int zvezda)
        {
            string zvezdochka = "";
            for (int x = 0; x < zvezda; x++)
            {
                zvezdochka = zvezdochka + "*";
            }
            Console.WriteLine(zvezdochka);

        }
	}
}
