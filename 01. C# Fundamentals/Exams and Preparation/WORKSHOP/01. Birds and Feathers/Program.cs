using System;

namespace _01.Birds_and_Feathers
{
	class Program
	{
		static void Main()
		{
			long B = long.Parse(Console.ReadLine());
			long F = long.Parse(Console.ReadLine());
			double average = (double)F / B;
			Console.WriteLine("{0:F4}",B%2==0? average*123123123123 : average/317);
		}
	}
}
