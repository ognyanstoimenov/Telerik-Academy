using System;

namespace _12.Decimal_to_Binary
{
	class Program
	{
		static void Main()
		{
			long N = long.Parse(Console.ReadLine());
			string binary = string.Empty;
			while (N > 0)
			{
				binary = (N % 2).ToString() + binary;
				N /= 2;
			}
			Console.WriteLine(binary);
			
		}
	}
}
