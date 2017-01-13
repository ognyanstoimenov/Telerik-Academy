namespace _01.Shapes
{
	using System;
	using Models;

	class Program
	{
		static void Main()
		{
			Shape[] Shapes = new Shape[]
			{
				new Square(5),
				new Rectangle(4.2,4.7),
				new Triangle(3.4,6.7)
			};

			foreach (var shape in Shapes)
			{
				Console.WriteLine($"The {shape.GetType().Name}'s surface is {shape.CalculateSurface()}");
			}
		}
	}
}

