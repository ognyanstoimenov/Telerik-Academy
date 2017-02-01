namespace _01.Shapes.Models
{
	public abstract class Shape
	{
		public Shape(double height, double width)
		{
			this.height = height;
			this.width = width;
		}
		public abstract double CalculateSurface();
		public double width;
		public double height;
	}
}
