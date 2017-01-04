using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_2
{
	class Program
	{
		

		static void Main()
		{

			Path path = new Path(new Point3D(3, 2, 1), new Point3D(45, 2, 1));
			PathStorage.SavePath(path);
			Path path2 = PathStorage.LoadPath();

		}
	}
}
