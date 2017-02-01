using System;

namespace _11.Adding_polynomials
{
	class Program
	{
		static int[] ReadArray()
		{
			string[] input = Console.ReadLine().Split(' ');
			int[] arr = new int[input.Length];
			for (int i = 0; i < input.Length; i++)
			{
				arr[i] = int.Parse(input[i]);
			}
			return arr;
		}

		static int[] Sum(int[] eq1,int[] eq2)
		{
			int[] meme = new int[eq1.Length];
			for (int i = 0; i < eq1.Length; i++)
			{
				meme[i] = eq1[i] + eq2[i];
			}
			return meme;
		}
		
		static void Main()
		{
			Console.ReadLine();
			int[] eq1 = ReadArray();
			int[] eq2 = ReadArray();
			Console.WriteLine(String.Join(" ",Sum(eq1,eq2)));
		}
	}
}
