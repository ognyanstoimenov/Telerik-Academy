using System;

namespace _14.Integer_calculations
{
	class Program
	{
		static decimal[] ReadArray()
		{
			string[] input = Console.ReadLine().Split(' ');
			decimal[] arr = new decimal[input.Length];
			for (int i = 0; i < input.Length; i++)
			{
				arr[i] = decimal.Parse(input[i]);
			}
			return arr;
		}

		static decimal Minimum(decimal[] arr)
		{
			decimal min = arr[0];
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] < min) min = arr[i];
			}
			return min;
		}

		static decimal Maximum(decimal[] arr)
		{
			decimal max = arr[0];
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] > max) max = arr[i];
			}
			return max;
		}

		static decimal Sum(decimal[] arr)
		{
			decimal sum = 0;
			for(int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
			}
			return sum;
		}

		static decimal Product(decimal[] arr)
		{
			decimal prod = 1;
			for (int i = 0; i < arr.Length; i++)
			{
				prod *= arr[i];
			}
			return prod;
		}

		static decimal Average(decimal[] arr)
		{
			return Sum(arr) / arr.Length;
		}


		static void Main()
		{
			decimal[] nums = ReadArray();
			Console.WriteLine("{0}\n{1}\n{2:F2}\n{3}\n{4}",Minimum(nums),Maximum(nums),Average(nums),Sum(nums),Product(nums));
		}
	}
}
