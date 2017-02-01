using System;
using System.Numerics;

namespace _06.Calculate_Again
{
	class Program
	{
		static void Main()
		{

			int N = int.Parse(Console.ReadLine());
			int K = int.Parse(Console.ReadLine());
			BigInteger factN = 1;
			BigInteger factK = 1;

			for (int i = 1; i <= N || i <= K; i++)
			{
				if (i <= N)
					factN *= i;
				if (i <= K)
					factK *= i;
			}
			Console.WriteLine(factN/factK);
		}
	}
}
