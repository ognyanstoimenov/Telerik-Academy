using System;

namespace _10.Odd_and_Even_Product
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			string[] numbersString = Console.ReadLine().Split(' ');
			long primeProduct = 1;
			long oddProduct = 1;

			for (int i = 1; i <= N; i++)
			{
				long num = long.Parse(numbersString[i - 1]);
				if (i % 2 == 0)
				{
					primeProduct *= num;
				}
				else oddProduct *= num;
			}

			if (primeProduct == oddProduct)
			{
				Console.WriteLine("yes {0}",primeProduct);
			}
			else Console.WriteLine("no {0} {1}", oddProduct,primeProduct);
		}
	}
}
