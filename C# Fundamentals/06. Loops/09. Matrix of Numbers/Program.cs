using System;

namespace _09.Matrix_of_Numbers
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			for (int j = 1; j <= N; j++)
			{
				for (int i = 1,z=j; i <= N; i++,z++)
				{
					Console.Write("{0} ", z);
				}
				Console.WriteLine();
			}
		}
	}
}
