using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PairSymbols
{
    namespace PairSymbols
    {
        class Program
        {
            static void Main(string[] args)
            {
                CheckPairs("namespace ConsoleApplication1 {class Program {static void Main(string[] args) {}", "{", "}");
                CheckPairs("graphics = e.Graphics;graphics.SmoothingMode = SmoothingMode.AntiAlias;graphics.Clear(Color.FromArgb(0x44444400));DrawCar(carX, 200);", "(", ")");
                Console.ReadLine();
            }
            static void CheckPairs(string text,string symbolsOpen, string symbolsClose)
            {
                int openSymbols = 0;
                int closeSymbols = 0;
                for (int x = 0; x < text.Length; x++)
                {
                    if (symbolsOpen == text[x].ToString())
                    {
                        openSymbols = openSymbols + 1;
                    }
                    if (symbolsClose == text[x].ToString())
                    {
                        closeSymbols = closeSymbols + 1;
                    }
                }

                if (closeSymbols == openSymbols)
                {
                    Console.WriteLine("Проблем нет");
                }
                else
                {
                    Console.WriteLine("Проблемы есть");
                }
            }

        }
    }
}