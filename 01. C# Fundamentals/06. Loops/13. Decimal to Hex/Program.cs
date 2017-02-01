using System;

namespace _13.Decimal_to_Hex
{
	class Program
	{
		static void Main()
		{
			long N = long.Parse(Console.ReadLine());
			string hex = string.Empty;
			while (N > 0)
			{
				long result = N % 16;
				if (result > 9) hex = (char)(result + 55)+hex;
				else hex = result.ToString() + hex;
				N /= 16;
			}
			Console.WriteLine(hex);


		}
	}
}
