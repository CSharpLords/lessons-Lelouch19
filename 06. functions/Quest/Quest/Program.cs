using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quest {
    class Program
    {
        static void Main(string[] args)
        {
            YouSuperhero();
        }
        static void ShowInvalid()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Введен невалидный вариант! Конец игры");
            Console.ReadLine();
            NewGame();
            Environment.Exit(0);
        }
        static void ShowOptions(string Options)
        {
            Thread.Sleep(500);
            Console.WriteLine(Options);
        }
        static void YouSuperhero()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(500);
            Console.WriteLine("Ты - супергерой. Твоя задача - вызволить принцессу из плена Всемирной Сети, куда она попала, по неосторожности ткнув в рекламный баннер. Выбери действие:");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            ShowOptions("1. Поиграть в Доту");
            ShowOptions("2. Узнать на каком сайте она застряла");
            int answer1 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (answer1 == 1)
            {
                Console.WriteLine("Конец игры! Ты просидел в Доте до утра, и принцессу спас другой хакер");
                Console.ReadLine();
                NewGame();
                Environment.Exit(0);
            }
            else if (answer1 == 2)
            {
                Site();
            }
            else
            {
                ShowInvalid();
            }

        }
        static void Site()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Оказывается, принцессе пришло письмо с рекламой суперстойкой помады, и там был баннер со ссылкой на сайт dontclickme.noob.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            ShowOptions("1. Послушаться совета в адресе сайта и поиграть в Доту");
            ShowOptions("2. Перейти на сайт");
            ShowOptions("3. Обновить антивирус, а потом перейти на сайт");
            int answer2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer2 == 1)
            {
                Console.WriteLine("Конец игры! Проигрыш - другой хакер спас принцессу");
                Console.ReadLine();
                NewGame();
                Environment.Exit(0);
            }
            else if (answer2 == 2)
            {
                Console.WriteLine("Конец игры! Проигрыш - игрок заразился тем же вирусом, что и принцесса, застрял на том же сайте со сломанным компьютером");
                Console.ReadLine();
                NewGame();
                Environment.Exit(0);
            }
            else if (answer2 == 3)
            {
                HelloKapchaMonster();
            }
            else
            {
                ShowInvalid();
            }
            
           
        }
        static void HelloKapchaMonster()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Игрок встречает противника - Капча-Монстра, который не дает обновить антивирус. Чтобы его победить, нужно решить задачку: сколько будет 2 + 2 * 2?");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            ShowOptions("1. А, ну ее, математика для нубов! Пойду в Доту поиграю!");
            ShowOptions("2. Проверить исходный код Капча-Монстра");
            ShowOptions("3. Ответить монстру: 6");
            ShowOptions("4. Да кто такой этот Капча-Монстр?!Попытаюсь хакнуть его.");
            int answer3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer3 == 1)
            {
                Console.WriteLine("Конец игры! Проигрыш - другой хакер спас принцессу");
                Console.ReadLine();
                NewGame();
                Environment.Exit(0);
            }
            else if (answer3 == 2)
            {
                SecretCode();
            }
            else if (answer3 == 3)
            {
                Console.WriteLine("Конец игры! Проигрыш - было бы слишком легко выиграть! На самом деле там невидимые скобки - это и есть супер-способность Капча-Монстра! Задание выглядит как (2 + 2) * 2");
                Console.ReadLine();
                NewGame();
                Environment.Exit(0);
            }
            else if(answer3 == 4)
            {
               AboutKapchaMonster();
            }
            else
            {
                ShowInvalid();
            }
           
        }
        static void AboutKapchaMonster()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вам удалось взломать Капча-Монстра,но как вы поступите теперь?");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            ShowOptions("1. Буду использовать его в своих целях!");
            ShowOptions("2. Уничтожу его,чтобы другие принцесы не попадались на эту ловушку!");
            int answer7 = int.Parse(Console.ReadLine());
            if (answer7 == 1)
            {
                YourKapchaMoster();
            }
            else if(answer7 == 2)
            {
                DestroyKapchaMonster();
            }
            else
            {
                ShowInvalid();
            }
        }
        static void YourKapchaMoster()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы взломали множество компьютер с помощью Капча-Монстра.Но вскоре вас заметил другой хакер и взломал монстра!Всё что остаётся,это исправиться и принести лекарство принцессе.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Thread.Sleep(1500);
            Victory();
        }
        static void DestroyKapchaMonster()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Поздравляю,вы уничтожили монстра и спасли многих юзеров интернета!Теперь отнесите лекарство принцессе!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Thread.Sleep(1500);
            Victory();
        }
        static void SecretCode()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Игрок вскрывает код Капча-Монстра и видит, что тот печатает черным цветом некоторые символы. Ух ты! Их не видно на черном фоне!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            ShowOptions("1. Круто, пойду попробую так в своей программе!");
            ShowOptions("2. Ответить монстру: 6");
            ShowOptions("3. Заменить цвет всех черных символов на белый и перезагрузить Капчу-Монстра");
            int answer4 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer4 == 1)
            {
                Console.WriteLine("Конец игры! Проигрыш - принцесса заблудилась во Всемирной Сети, пока герой ковырялся не там, где надо");
                Console.ReadLine();
                NewGame();
                Environment.Exit(0);
            }
            else if (answer4 == 2)
            {
                Console.WriteLine("Конец игры! Проигрыш - зря, что ли, подвох находил??");
                Console.ReadLine();
                NewGame();
                Environment.Exit(0);
            }
            else if (answer4 == 3)
            {
                ReallyExample();
            }
            else
            {
                ShowInvalid();
            }
            
        }
        static void ReallyExample()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Капча-Монстра хрипит консольными командами, догружается, наконец, до конца и выдает: сколько будет (2 + 2) * 2?");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            ShowOptions("1. Ответить монстру: 8");
            ShowOptions("2. Герою лень считать, и он идет в Доту");
            int answer5 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer5 == 1)
            {
                GoodbyeKapchaMonster();
            }
            else if (answer5 == 2)
            {
                Console.WriteLine("Конец игры! Проигрыш - другой хакер спас принцессу");
                Console.ReadLine();
                NewGame();
                Environment.Exit(0);
            }
            else
            {
                ShowInvalid();
            }
            
        }
        static void GoodbyeKapchaMonster()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Капча-Монстр обиженно сопит \"Как ты догадался? Я же спрятал скобки!\", отступает и позволяет обновить антивирус. Теперь герой защищен, и может перейти на сайт! Едва он делает это, как получает сообщение антивируса: Замечена и заблокирована вредоносная программа: WinLock 1.0. Файл-лекарство можно найти здесь: C:Antiviruscure.exe.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            ShowOptions("1.Отправить лекарство принцессе по почте и пойти в Доту");
            ShowOptions("2.Записать лекарство на флешку и пойти к принцессе домой");
            ShowOptions("3 Перекинуть лекарство на внешний жёсткий диск о отправиться к принцессе");
            int answer6 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer6 == 1)
            {
                Console.WriteLine("Конец игры! Проигрыш - у нее сломался компьютер, она не может получить твой файл! Принцессу спасает другой хакер");
                Console.ReadLine();
                NewGame();
                Environment.Exit(0);
            }
            else if (answer6 == 2)
            {
                Victory();
            }
            else if (answer6 == 3)
            {
                Victory();
            }
            else
            {
                ShowInvalid();
            }
          

        }
        static void Victory()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ура!!! Победа! Ты успешно справился со всеми испытаниями и спас принцессу!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadLine();
            NewGame();
        }
        static void NewGame()
        {
            Console.WriteLine("Хотите начать заново?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "да")
            {
                Console.Clear();
                YouSuperhero();
            }
            if (answer == "нет")
            {
                Console.WriteLine();
                Console.WriteLine("Зря,очень зря");
                Console.ReadLine();
            }
        }
    }
}
