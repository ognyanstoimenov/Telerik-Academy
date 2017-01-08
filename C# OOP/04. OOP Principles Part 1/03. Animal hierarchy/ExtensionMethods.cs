using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.Animal_hierarchy.Models;

namespace _03.Animal_hierarchy
{
	static class ExtensionMethods
	{
		public static double CalculateAverage(this IList<Animal> list)
		{
			return list.Average(x => x.Age);
		}
	}
}
