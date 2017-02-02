using System;

namespace _06.Triangle_surface_by_two_sides_and_an_angle
{

	class Triangle
	{
		public double a = double.Parse(Console.ReadLine());
		public double b = double.Parse(Console.ReadLine());
		public double angle = double.Parse(Console.ReadLine());
		public double Area()
		{
			double angRad = angle * Math.PI / 180;
			double sinAngle = Math.Sin(angRad);
			checked
			{
				return a * b * sinAngle / 2;
			}
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
