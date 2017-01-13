namespace _01.Shapes.Models
{ 
	class Rectangle : Shape
	{
		public Rectangle(double height, double width) : base(height, width)
		{
		}

		public override double CalculateSurface()
		{
			return base.height * base.width;
		}
	}
}
