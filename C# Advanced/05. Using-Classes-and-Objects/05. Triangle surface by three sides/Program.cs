using System;

namespace _05.Triangle_surface_by_three_sides
{

	class Triangle
	{
		public double a = double.Parse(Console.ReadLine());
		public double b = double.Parse(Console.ReadLine());
		public double c = double.Parse(Console.ReadLine());
		public double Area()
		{
			double p = (a + b + c)/2;

			return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); 
		}

	}

	class Program
	{
		static void Main()
		{
			Triangle triang1 = new Triangle();
			Console.WriteLine("{0:F2}", triang1.Area());
		}
	}
}
