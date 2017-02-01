using System;

namespace _02.Get_largest_number
{
	class Program
	{
		static int GetMax(int a, int b)
		{
			if (a > b) return a;
			else return b;
		}
		static void Main()
		{
			string[] input = Console.ReadLine().Split(' ');
			int num1 = int.Parse(input[0]);
			int num2 = int.Parse(input[1]);
			int num3 = int.Parse(input[2]);

			Console.WriteLine(GetMax(GetMax(num1,num2),num3));

		}
	}
}
