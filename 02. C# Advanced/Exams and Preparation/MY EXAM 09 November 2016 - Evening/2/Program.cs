using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
	class Program
	{

		static string numToCard(int num)
		{
			string cards = "23456789TJQKA";
			StringBuilder result = new StringBuilder();
			char current = cards[num % 13];
			result.Append(current);
			char toAppend = new char();
			if (num <= 12) toAppend = 'c';
			if (num > 12 && num <= 25) toAppend = 'd';
			if (num > 25 && num <= 38) toAppend = 'h';
			if (num > 38 && num <= 51) toAppend = 's';
			result.Append(toAppend);
			return result.ToString();
		}

		static void Main()
		{
			int numberOfHands = int.Parse(Console.ReadLine());
			long allCards = long.MaxValue;
			int[] cardsFound = new int[52];
			for (int i = 0; i < numberOfHands; i++)
			{
				long currentHand = long.Parse(Console.ReadLine());
				int pos = 0;
				for (int j = 0; j < 64; j++)
				{
					if ((currentHand & 1) == 1)
					{
						cardsFound[pos] += 1;
					}
					currentHand = currentHand >> 1;
					pos++;
				}
			}
			//for (int i = 0; i < cardsFound.Length; i++)
			//{
			//	Console.WriteLine(i + " " + cardsFound[i]);
			//}
			bool fullDeck = true;
			for (int i = 0; i < cardsFound.Length; i++)
			{
				if (cardsFound[i] == 0) fullDeck = false;
			}

			Console.WriteLine(fullDeck == true ? "Full deck" : "Wa wa!");

			for (int i = 0; i < cardsFound.Length; i++)
			{
				if (cardsFound[i] % 2 == 1)
				{
					Console.Write(numToCard(i) + " ");
				}
			}
			Console.WriteLine();
		}
	}
}
