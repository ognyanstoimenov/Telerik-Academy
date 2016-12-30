using System;
using System.Numerics;

namespace _03.Maslan
{
	class Program
	{
		static void Main()
		{
			BigInteger num = BigInteger.Parse(Console.ReadLine());
			byte transformCount = 0;
			BigInteger sum = 0;
			BigInteger product = 1;
			while (num / 10 > 0 && transformCount!=10)
			{
				while (num > 0)
				{
					num = num / 10;
					for (BigInteger i = (num.ToString().Length % 2 == 0) ? num : num / 10; i > 0; i /= 100)
					{
						sum += i % 10;
					}
					product *= (sum == 0) ? 1 : sum;
					sum = 0;
				}
				num = product;
				transformCount++;
				product = 1;
				sum = 0;
			}	
			if (transformCount != 10)
			{
				Console.WriteLine(transformCount);
			}
			Console.WriteLine(num);
		}
	}
}
