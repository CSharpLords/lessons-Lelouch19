using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPassword 
{
	class Program {
		static void Main(string[] args) 
        {
			string password = "Супер пароль!";
            int trying = 0;
            while (trying < 5) 
            {
                Console.WriteLine("Чтобы пользоваться моей программой, введи пароль!");
                string answer = Console.ReadLine();

                if (answer == password) 
                {
                    Console.WriteLine("Ок, правильно. Жми Enter, чтобы пройти!");
                    Console.ReadLine();
                    Console.Clear();

                    StartProgram();
                }
                else 
                {
                    Console.WriteLine("Неправильно! Хаха, ты не пройдешь!");
                    Console.ReadLine();
                    trying = trying + 1;
                }
            }
		}

		static void StartProgram() 
        {
			Quest quest = new Quest();
		}
	}
}
