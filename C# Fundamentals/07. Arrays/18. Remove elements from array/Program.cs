using System;

namespace _18.Remove_elements_from_array
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			int[] arr = new int[N];
			int[] T = new int[N];
			for (int i = 0; i < N; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
				T[i] = 1;
			}


			for (int i = 1; i < N; i++)
			{
				for (int j = 0; j < i; j++)
				{
					if (arr[j] <= arr[i])
					{
						T[i] = Math.Max(T[i], T[j] + 1);
					}
				}
			}

			int maxsequence = T[0];

			for (int i = 1; i < N; i++)
			{
				if (T[i] > maxsequence)
				{
					maxsequence = T[i];
				}
			}
			Console.WriteLine(N-maxsequence);



		}
	}
}
