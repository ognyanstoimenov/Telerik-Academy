namespace _01.Shapes.Models
{
	class Triangle : Shape
	{
		public Triangle(double height, double width) : base(height, width)
		{
		}

		public override double CalculateSurface()
		{
			return base.width * base.height / 2;
		}
	}
}
