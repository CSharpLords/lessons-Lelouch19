using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static bool sword = false;
        static bool armor = false;
        static double health = 100;
        static double damage = 40;
        static double robberHealth = 100;
        static double robberDamage = 50;
        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {
            Console.WriteLine("Добро пожаловать в MiniQuest!");
            Console.WriteLine("Вы находитесь в локации : Зелёные поля.");
            Console.WriteLine("Варианты действий:");
            Console.WriteLine("1.Перейти в лес.");
            Console.WriteLine("2.Осмотреть поле.");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Forest();
            }
            if (a == 2)
            {
                Field();
            }
            Console.ReadLine();
        }
        static void Forest()
        {
            Console.WriteLine();
            Console.WriteLine("На вас со спины напали разбойники!");
            health = health - 30;
            Console.WriteLine("Ваше здоровье - " + (health - 30));
            Console.WriteLine("1.Отправиться на поле?");
            Console.WriteLine("2.Сражаемся!");
            Console.WriteLine();
            Thread.Sleep(500);
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Field();
            }
            else if (a == 2)
            {
                Fight();
            }
            Console.ReadLine();
        }
        static void Field()
        {
            Random rand = new Random();
            int subject = rand.Next(0, 2);
            if (sword == true && armor == true)
            {
                Console.WriteLine();
                Console.WriteLine("Вам выпали все предметы!Идите воевать!");
                Forest();
            }
            else if (sword == true)
            {
                subject = 1;
            }
            else if (armor == true)
            {
                subject = 0;
            }
            if (subject == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Поздравляю!Вам выпал меч!");
                sword = true;
                damage = damage + 30;
                Console.WriteLine("Варианты действий:");
                Console.WriteLine("1.Перейти в лес.");
                Console.WriteLine("2.Остаться на поле.");
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    Forest();
                }
                if (a == 2)
                {
                    Field();
                }
                Thread.Sleep(500);
            }
            else if (subject == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Поздравляю!Вам выпала броня!");
                health = health + 50;
                armor = true;
                Console.WriteLine("Варианты действий:");
                Console.WriteLine("1.Перейти в лес.");
                Console.WriteLine("2.Остаться на поле.");
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    Forest();
                }
                if (a == 2)
                {
                    Field();
                }
                Thread.Sleep(500);
            }
        }   
        static void Fight()
        {
            while (true)
            {
                robberDamage = GetReducedAttack(robberHealth, 100, 50);
                Console.WriteLine("Ваше здоровье - " + (health - robberDamage) + ".Здоровье разбойника - " + (robberHealth - damage) + ".");
                health = health - robberDamage;
                robberHealth = robberHealth - damage;
                if (health < 1 || robberHealth < 1)
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Варианты действий:");
                Console.WriteLine("1.Биться до конца.");
                Console.WriteLine("2.Как поляк,бежать на поле.");
                int a = int.Parse(Console.ReadLine());
                if (a == 2)
                {
                    Field();
                }
            }
            if (health <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Вы проиграли!");
            }
            if (robberHealth <= 0 && health >= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Вы выиграли!Поздравляю!");
            }
            if (robberHealth <= 0 && health <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Вы проиграли!Но забрали разбойника с собой!");
            }
            Console.ReadLine();
        }
        static double GetReducedAttack(double health, double maxHealth, double maxAttack)
        {
            double x = maxHealth / health;
            double attack = maxAttack / x;
            return attack;
        }
    }
}
