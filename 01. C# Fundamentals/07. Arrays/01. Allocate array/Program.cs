using System;

namespace _01.Allocate_array
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			int[] arr = new int[N];
			for (int i = 0; i < N; i++)
			{
				Console.WriteLine(i*5);
			}
		}
	}
}
