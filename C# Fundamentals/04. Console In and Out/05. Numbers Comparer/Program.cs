using System;

namespace _05.Numbers_Comparer
{
	class Program
	{
		static void Main()
		{
			double A = double.Parse(Console.ReadLine());
			double B = double.Parse(Console.ReadLine());

			Console.WriteLine(A > B ? A : B);
		}
	}
}
