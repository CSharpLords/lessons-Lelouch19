using System;

namespace UpgradedSpaces 
{
	class Program 
    {
		static void Main(string[] args) 
        {
			Console.Write("Введите предложение: ");
			string sentence = Console.ReadLine();

			int spacesAmount = CountSpaces(sentence);
			string spacesForm = GetSpacesForm(spacesAmount);
			Console.Write("Предложение '" + sentence + "' содержит " + spacesAmount + " " + spacesForm);
			Console.ReadLine();
		}
        static int CountSpaces(string sentence)
        {
            int spacesAmount = 0;
            for (int x = 0; x < sentence.Length; x++)
            {
                char space = ' ';
                if (sentence[x] == space)
                {
                    spacesAmount = spacesAmount + 1;
                }
            }
            return spacesAmount;
        }

        static string GetSpacesForm(int spaceAmount)
        {
            string spacesForm = "";
            if(spaceAmount == 1)
            {
                spacesForm = "пробел.";
            }
            else if(spaceAmount > 1 && spaceAmount < 5)
            {
                spacesForm = "пробела.";
            }
            else
            {
                spacesForm = "пробелов.";
            }
            return spacesForm;
        }

	}
}
