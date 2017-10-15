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
            Console.WriteLine("Ты у входа в пещеру, которую охраняет огр. У тебя есть варианты действий:");
            Console.WriteLine("1. Вступить в бой.");
            Console.WriteLine("2. Ты отступаешь.");
            Console.WriteLine("3. Подкупаешь огра.");
            Console.WriteLine("4. Ищешь обходной путь.");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("Ты погибаешь, так как огр сильнее.");
            }
            else if (answer == 2)
            {
                Console.WriteLine("Переносишься в соседнюю локацию.");
            }
            else if (answer == 3)
            {
                Console.WriteLine("Он пропускает тебя внутрь.");
            }
            else if (answer == 4)
            {
                Console.WriteLine("По пути тебя грабят бандиты.");
            }
            Console.ReadLine();
        }

    }
}
