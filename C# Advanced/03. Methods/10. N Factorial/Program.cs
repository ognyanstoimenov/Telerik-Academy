using System;
using System.Numerics;

namespace _10.N_Factorial
{
	class Program
	{

		static int Multiply(int[] num, int multiplier)
		{
			int buffer = 0;
			string result = string.Empty;
			int currRes;
			for (int i = num.Length - 1; i >= 1; i--)
			{
				currRes = num[i] * multiplier + buffer;
				buffer = currRes / 10;
				result = (currRes % 10) + result;
			}
			currRes = num[0] * multiplier + buffer;
			result = currRes + result;
			return int.Parse(result);
		}
		static BigInteger result = 1;
		static void Main()
		{
			string inputNum = Console.ReadLine();

			int[] number = new int[inputNum.Length];

			for (int i = 0; i < inputNum.Length; i++)
			{
				number[i] = int.Parse(inputNum[i].ToString());
			}



			BigInteger result = 1;
			int fact = int.Parse(String.Join("", number));

			for (int i = 1; i < fact; i++)
			{
				result *= Multiply(number, i)/fact;
			}

			BigInteger final = (fact==0)? 1 : result * fact;
			Console.WriteLine(final);


		}
	}
}
