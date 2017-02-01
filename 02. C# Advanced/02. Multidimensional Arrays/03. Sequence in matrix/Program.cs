using System;

namespace _03.Sequence_in_matrix
{
	class Program
	{
		static void Main()
		{
			string[] input = Console.ReadLine().Split(' ');
			int N = int.Parse(input[0]);
			int M = int.Parse(input[1]);
			string[,] arr = new string[N, M];
			for (int i = 0; i < N; i++)
			{
				string[] line = Console.ReadLine().Split(' ');
				for (int j = 0; j < M; j++)
				{
					arr[i, j] = line[j];
				}
			}

			//Horizontal
			int jSeq = 1;
			int currentJMax = 1;
			int jMax = 1;

			for (int i = 0; i < N; i++)
			{
				jSeq = 1;
				currentJMax = 1;
				for (int j = 0; j < M - 1; j++)
				{
					if (arr[i, j] == arr[i, j + 1]) jSeq++;
					else
					{
						if (jSeq > currentJMax)
							currentJMax = jSeq;
						jSeq = 1;
					}
					if (j == M - 2)
					{
						if (jSeq > currentJMax) currentJMax = jSeq;
					}
				}
				if (currentJMax > jMax) jMax = currentJMax;
			}

			//Vertical
			int iSeq = 1;
			int currentIMax = 1;
			int iMax = 1;

			for (int j = 0; j < M; j++)
			{
				iSeq = 1;
				currentIMax = 1;
				for (int i = 0; i < N - 1; i++)
				{
					if (arr[i, j] == arr[i + 1, j]) iSeq++;
					else
					{
						if (iSeq > currentIMax)
							currentIMax = iSeq;
						iSeq = 1;
					}
					if (i == M - 2)
					{
						if (iSeq > currentIMax) currentIMax = iSeq;
					}
				}
				if (currentIMax > iMax) iMax = currentIMax;
			}

			//Diagonal: Left to Right
			int dSeq = 1;
			int currentDMax = 1;
			int dMax = 1;
			for (int j = 0; j < M; j++)
			{
				for (int i = 0; i < N; i++)
				{
					dSeq = 1;
					currentDMax = 1;
					int p = 0;
					if (N > M && i <= N - M)
					{
						p = 0;
					}
					else p++;
					int diag1 = i;
					int diag2 = j;
					for (int count = 0;count<Math.Min(N,M) - p;count++)
					{
						if (diag1 + 1 >= N || diag2 + 1 >= M) break;
						if (arr[diag1, diag2] == arr[diag1 + 1, diag2 + 1])
						{
							dSeq++;
						}
						else
						{
							if (dSeq > currentDMax) currentDMax = dMax;
							dSeq = 1;
						}
						if (dSeq > currentDMax) currentDMax = dSeq;
						diag1++;
						diag2++;
					}
					if (currentDMax > dMax) dMax = currentDMax;
				}
			}

			//Diagonal: Right to Left
			int lSeq = 1;
			int currentLMax = 1;
			int lMax = 1;
			for (int j = M-1; j >= 0; j--)
			{
				for (int i = 0; i < N; i++)
				{
					lSeq = 1;
					currentLMax = 1;
					int p = 0;
					if (N > M && i <= N - M)
					{
						p = 0;
					}
					else p++;
					int diag1 = i;
					int diag2 = j;
					for (int count = 0; count < Math.Min(N, M) - p; count++)
					{
						if (diag1 + 1 >= N || diag2 - 1 < 0) break;
						if (arr[diag1, diag2] == arr[diag1 + 1, diag2 - 1])
						{
							lSeq++;
						}
						else
						{
							if (lSeq > currentLMax) currentLMax = lMax;
							lSeq = 1;
						}
						if (lSeq > currentLMax) currentLMax = lSeq;
						diag1++;
						diag2--;
					}
					if (currentLMax > lMax) lMax = currentLMax;
				}
			}

			int maximalSequence = Math.Max(Math.Max(iMax, jMax), Math.Max(dMax, lMax));
			Console.WriteLine(maximalSequence);
		}
	}
}


