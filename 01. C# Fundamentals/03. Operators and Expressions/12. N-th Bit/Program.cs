using System;

namespace _12.N_th_Bit
{
	class Program
	{
		static void Main()
		{
			long P = long.Parse(Console.ReadLine());
			int N = int.Parse(Console.ReadLine());

			Console.WriteLine((P & 1L << N) >> N);

		}
	}
}
