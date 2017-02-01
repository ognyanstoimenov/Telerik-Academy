namespace Defining_Classes___Part_2
{
	using System.Collections.Generic;
	public struct Point3D
	{
		private static readonly Point3D o = new Point3D(0, 0, 0);
		public Point3D(double x, double y, double z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		public double X { get; set; }
		public double Y { get; set; }
		public double Z { get; set; }
		public static Point3D O { get { return o; } }

		public override string ToString()
		{
			return string.Format($"({this.X}, {this.Y}, {this.Z})");
		}

	}
}
