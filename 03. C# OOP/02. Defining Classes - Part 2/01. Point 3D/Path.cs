namespace Defining_Classes___Part_2
{
	using System;
	using System.Collections.Generic;
	public class Path
	{
		public int Count { get { return seqOfPoints.Count; } }

		public Path(params Point3D[] points)
		{
			for (int i = 0; i < points.Length; i++)
			{
				seqOfPoints.Add(points[i]);
			}
		}

		public Path(List<Point3D> points)
		{
			foreach (var point in points)
			{
				seqOfPoints.Add(point);
			}
		}

		public List<Point3D> seqOfPoints = new List<Point3D>();

		public void Add(Point3D point)
		{
			seqOfPoints.Add(point);
		}
	}
}
