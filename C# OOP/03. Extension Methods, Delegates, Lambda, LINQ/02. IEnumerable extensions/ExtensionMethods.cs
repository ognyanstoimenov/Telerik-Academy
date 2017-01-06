

namespace _02.IEnumerable_extensions
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public static class ExtensionMethods
	{

		public static T Sum<T>(this IEnumerable<T> enumerable)
		{
			dynamic sum = default(T);

			foreach (var item in enumerable)
			{
				sum += item;
			}
			return sum;
		}

		public static T Product<T>(this IEnumerable<T> enumerable)
		{
			dynamic product = 1;

			foreach (var item in enumerable)
			{
				product *= item;
			}
			return product;
		}

		public static T Min<T>(this IEnumerable<T> enumerable)
		{
			dynamic min = enumerable.ElementAt(0);

			foreach (var item in enumerable)
			{
				if (item <= min) min = item;
			}
			return min;
		}

		public static T Max<T>(this IEnumerable<T> enumerable)
		{
			dynamic max = enumerable.ElementAt(0);

			foreach (var item in enumerable)
			{
				if (item >= max) max = item;
			}
			return max;
		}

		public static T Avarage<T>(this IEnumerable<T> enumerable)
		{
			dynamic sum = Sum<T>(enumerable);

			return sum / enumerable.Count();
		}

	}
}
