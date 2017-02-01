using System;

namespace _01.Fill_the_matrix
{
	class Program
	{
		static void Main()
		{
			int N = int.Parse(Console.ReadLine());
			char symbol = (char)Console.Read();
			int[,] matrix = new int[N, N];
			int count = 1;

			switch (symbol)
			{
				case 'a':
					for (int i = 0; i < N; i++)
					{
						for (int j = 0; j < N; j++)
						{
							matrix[j, i] = count++;
						}
					}
					break;

				case 'b':
					for (int i = 0; i < N; i++)
					{
						for (int j = 0; j < N; j++)
						{
							if (i % 2 != 0)
							{
								int m = N - 1;
								matrix[m - j, i] = count++;
							}
							else
							{
								matrix[j, i] = count++;
							}
						}
					}
					break;

				case 'c':
					for (int i = N - 1; i >= 0; i--)
					{
						int p = i;
						for (int j = 0; p <= N - 1; j++)
						{
							matrix[p, j] = count++;
							p++;
						}
					}
					for (int j = 1; j <= N - 1; j++)
					{
						int p = j;
						for (int i = 0; p <= N - 1; i++)
						{
							matrix[i, p] = count++;
							p++;
						}
					}
					break;

				case 'd':
					{
						int lap = 0;
						while (count <= N * N)
						{
							for (int j = lap; j <= N - lap - 1; j++)
							{
								matrix[j, lap] = count++;
							}

							for (int i = lap + 1; i <= N - lap - 1; i++)
							{
								matrix[N - lap - 1, i] = count++;
							}

							for (int j = N - lap - 2; j >= lap; j--)
							{
								matrix[j, N - lap - 1] = count++;
							}

							for (int i = N - lap - 2; i >= lap + 1; i--)
							{
								matrix[lap, i] = count++;
							}
							lap++;
						}
					}
					break;
			}

			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < N; j++)
				{
					Console.Write(j == N - 1 ? "{0}" : "{0} ", matrix[i, j]);
				}
				Console.WriteLine();
			}

		}
	}
}
