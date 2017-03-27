using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _1
{
	class Program
	{

		static long decrypt(string num)
		{
			StringBuilder result = new StringBuilder();
			string[] system = { "hristo", "tosho", "pesho", "hristofor", "vlad", "haralampi", "zoro", "vladimir" };
			for (int j = system.Length - 1; j >= 0; j--)
			{
				int indexofword = num.IndexOf(system[j]);
				if (indexofword != -1)
				{
					num = num.Replace(system[j], j.ToString());
				}
			}
			return SToDecimal(num, 8);
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



		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string[] words = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
			BigInteger result = 1;
			foreach (var num in words)
			{
				result *= decrypt(num);
			}
			Console.WriteLine(result);
		}
	}
}
