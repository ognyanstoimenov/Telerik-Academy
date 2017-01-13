namespace _01.Shapes.Models
{
	class Square : Shape
	{
		public Square(double side) : base(side,side)
		{
		}

		public override double CalculateSurface()
		{
			return base.height * base.width;
		}
	}
}
