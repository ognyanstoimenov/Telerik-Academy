using System;

namespace _15.GCD
{
	class Program
	{
		static void Main()
		{
			string[] AandB = Console.ReadLine().Split(' ');
			int A = int.Parse(AandB[0]);
			int B = int.Parse(AandB[1]);
			int swap;
			while (A != B)
			{
				if (B > A)
				{
					swap = A;
					A = B;
					B = swap;
				}
				A = A - B;
			}
			Console.WriteLine(A);

		}

	}
}
