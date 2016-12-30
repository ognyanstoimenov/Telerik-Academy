using System;

namespace _14.Hex_to_Decimal
{
	class Program
	{
		static void Main()
		{
			string N = Console.ReadLine();
			double sum = 0;
			int dec;
			for (int i = 0; i < N.Length; i++)
			{
				int currentPosition = N.Length - i - 1;
				if (int.TryParse((Convert.ToString(N[currentPosition])), out dec))
					sum += dec * Math.Pow(16, i);
				else
				{
					dec = N[currentPosition] - 55;
					sum += dec * Math.Pow(16, i);
				}
			}
			Console.WriteLine(sum);
		}
	}
}