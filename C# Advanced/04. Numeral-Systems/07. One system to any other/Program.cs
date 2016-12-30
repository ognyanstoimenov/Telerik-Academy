using System;

namespace _07.One_system_to_any_other
{
	class Program
	{

		static long ConvertToDec(string n, int Base)
		{
			long result = 0;
			foreach (char num in n)
			{
				int digitValue;
				if (char.IsDigit(num))
				{
					digitValue = num - '0';
				}
				else digitValue = num - 'A' + 10;
				result = result * Base + digitValue;


			}
			return result;
		}

		static string DecToOther(long n,int Base)
		{
			string result = "";
			string nums = "0123456789ABCDEF"; 
			do
			{
				int digitValue = (int)(n % Base);
				char digit = nums[digitValue];
				result = digit + result;
				n /= Base;
			}
			while (n > 0);

			return result;
		}

		static void Main(string[] args)
		{
			int baseNumber = int.Parse(Console.ReadLine());
			string number = Console.ReadLine();

			int baseResult = int.Parse(Console.ReadLine());
			string result = DecToOther(ConvertToDec(number, baseNumber),baseResult);
			Console.WriteLine(result);
		}
	}
}
