using System;

namespace _04.Print_a_Deck
{
	class Program
	{
		static void Main()
		{
			string[] card = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
			string input = Console.ReadLine();
			for (int i = 0; i < card.Length; i++)
			{
				Console.Write(card[i] + " of spades, ");
				Console.Write(card[i] + " of clubs, ");
				Console.Write(card[i] + " of hearts, ");
				Console.Write(card[i] + " of diamonds");
				Console.WriteLine();
				if (card[i] == input) break;
			}
		}
	}
}
