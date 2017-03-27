using System;

namespace _4
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			string[] arr = new string[N];
			int sum = 0;
			string digit1;
			string digit2;
			for (int i = 0; i < N; i++)
			{
				arr[i] = Console.ReadLine();
			}
			for (int i = 0; i < N - 1; i++)
			{
				digit1 = arr[i][1].ToString();
				digit2 = arr[i + 1][0].ToString();
				Console.Write(digit1 + digit2 + " ");
			}
			Console.WriteLine();
			for (int i = 0; i < N - 1; i++)
			{
				Console.Write(Convert.ToInt32(arr[i]) + Convert.ToInt32(arr[i + 1]) + " ");
			}
		}
	}
}
