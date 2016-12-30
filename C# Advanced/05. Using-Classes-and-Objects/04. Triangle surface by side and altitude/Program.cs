using System;

namespace _04.Triangle_surface_by_side_and_altitude
{

	class Triangle
	{
		public double side;
		public double height;
		public double Area()
		{
			return side * height / 2;
		}
	}
	class Program
	{
		static void Main()
		{
			Triangle A = new Triangle();
			A.side = double.Parse(Console.ReadLine());
			A.height = double.Parse(Console.ReadLine());
			Console.WriteLine("{0:F2}", A.Area());
		}
	}
}
