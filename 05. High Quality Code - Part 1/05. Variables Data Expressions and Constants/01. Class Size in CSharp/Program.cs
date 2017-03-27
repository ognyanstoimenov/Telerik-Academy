namespace ClassSizeInCSharp
{
	using System;

	public class Size
	{
		public Size(double width, double height)
		{
			this.Height = width;
			this.Height = height;
		}

		public double Width { get; private set; }

		public double Height { get; private set; }

		public static Size GetRotatedSize(Size originalSize, double angle)
		{
			double cos = Math.Abs(Math.Cos(angle));
			double sin = Math.Abs(Math.Sin(angle));

			double newWidth = (cos * originalSize.Width) + (sin * originalSize.Height);
			double newHeight = (sin * originalSize.Width) + (cos * originalSize.Height);

			return new Size(newWidth, newHeight);
		}
	}
}