using System;

namespace _11.Binary_to_Decimal
{
	class Program
	{
		static void Main()
		{
			string binary = Console.ReadLine();
			double sum = 0;
			for(int i = binary.Length-1; i >= 0; i--)
			{
				if (binary[i] == '1')
				{
					sum += Math.Pow(2d,(binary.Length-1-i));
				}
			}
			Console.WriteLine(sum);
		}
	}
}
