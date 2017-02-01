namespace Defining_Classes___Part_2
{
	using System;
	using System.IO;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public static class PathStorage
	{
		private const string pathOfFile = "..\\..\\path.txt";

		private static List<Point3D> ToAdd = new List<Point3D>();
		private static string[] LinesOfFile { get; set; }


		public static Path LoadPath()
		{
			LinesOfFile = File.ReadAllLines(pathOfFile);
			for (int i = 0; i < LinesOfFile.Length; i++)
			{
				string currentPoint = LinesOfFile[i].Substring(LinesOfFile[i].IndexOf('(') + 1, (LinesOfFile[i].IndexOf(')') - LinesOfFile[i].IndexOf('(') - 1));
				string[] pointsToAdd = currentPoint.Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries);
				ToAdd.Add(new Point3D(int.Parse(pointsToAdd[0]), int.Parse(pointsToAdd[1]), int.Parse(pointsToAdd[2])));
			}
			return new Path(ToAdd);
		}

		public static void SavePath(Path a)
		{
			StringBuilder result = new StringBuilder();
			foreach (var point in a.seqOfPoints)
			{
				result.Append("(");
				result.Append(point.X);
				result.Append(",");
				result.Append(point.Y);
				result.Append(",");
				result.Append(point.Z);
				result.Append(")");
				result.Append(Environment.NewLine);
			}
			File.WriteAllText(pathOfFile, result.ToString());
		}


	}
}
