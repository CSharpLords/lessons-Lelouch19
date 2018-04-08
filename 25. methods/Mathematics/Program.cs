using System;

namespace Mathematics {
	class Program {
		static void Main(string[] args) 
        {
			Console.WriteLine(Sum(3, Multiply(7, 9)));
			Console.ReadLine();
		}

        static int Multiply(int number1, int number2)
        {
            int number = number1 * number2;
            return number;
        }
        static int Sum(int number1,int number2)
        {
            int number = number1 + number2;
            return number;
        }
	}
}
