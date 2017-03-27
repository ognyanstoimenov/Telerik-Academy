using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace examm
{
	class Program
	{

		static void PrintMatrix(int[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write("{0,00}",matrix[i,j]);
				}
				Console.WriteLine();
			}
		}

		//from any base to any other
		static string AtoB (string number, int fromBase,int toBase)
		{

			return DecimalToD(SToDecimal(number, fromBase), toBase);
		}

		static long SToDecimal(string baseSvalue, int baseS)
		{
			long num = 0;

			foreach (char Svalue in baseSvalue)
			{
				int value;
				if (char.IsDigit(Svalue))
					value = Svalue - '0';
				else
					value = Svalue - 'A' + 10;

				num = num * baseS + value;
			}

			return num;
		}

		static string DecimalToD(long num, int baseD)
		{
			string Dvalues = "0123456789ABCDEF";
			string Dresult = string.Empty;

			do
			{
				Dresult = Dvalues[(int)(num % baseD)] + Dresult;
				num /= baseD;
			} while (num > 0);

			return Dresult;
		}
		//

	}
}
