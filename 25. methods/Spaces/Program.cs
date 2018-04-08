using System;

namespace Spaces {
	class Program {
		static void Main(string[] args) 
        {
			Console.Write("Введите предложение: ");
			string sentence = Console.ReadLine();

		    int spacesAmount = CountSpaces(sentence);
			Console.Write("Предложение '" + sentence + "' содержит " + spacesAmount + " пробелов");
			Console.ReadLine();
		}

        static int CountSpaces(string sentence)
        {
            int spacesAmount = 0;
            for (int x = 0; x < sentence.Length; x ++ )
            {
                char space = ' ';
                if(sentence[x] == space)
                {
                    spacesAmount = spacesAmount + 1;
                }
            }
            return spacesAmount;
        }

	}
}
