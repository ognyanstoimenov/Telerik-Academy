using System;

namespace _03.Play_Card
{
	class Program
	{
		static void Main()
		{
			string card = Console.ReadLine();
			int number;
			if (int.TryParse(card, out number))
			{
				if (number >= 2 && number <= 10)
				{
					Console.WriteLine("yes " + number);
				}
				else Console.WriteLine("no " + number);
			}
			else
			{
				if (card == "K" || card == "Q" || card == "J" || card == "A")
					Console.WriteLine("yes " + card);
				else Console.WriteLine("no " + card);
			}
		}
	}
}
