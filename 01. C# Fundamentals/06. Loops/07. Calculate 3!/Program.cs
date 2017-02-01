using System;
using System.Numerics;
namespace Combinatorics
{
	class Program
	{
		 static BigInteger comb (int N, int K)
		{
			BigInteger factN = 1;
			BigInteger factK = 1;
			BigInteger factNminusK = 1;


			for (int i = 1; i <= N || i <= K; i++)
			{
				if (i <= N)
					factN *= i;
				if (i <= K)
					factK *= i;
			}

			for (int i = 1; i <= N - K; i++)
			{
				factNminusK *= i;
			}


			return factN / (factK * factNminusK);

		}

		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			int K = int.Parse(Console.ReadLine());
			Console.WriteLine(comb(N,K));
		}
	}
}

