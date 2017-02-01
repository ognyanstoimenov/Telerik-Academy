using System;

namespace _03.Compare_char_arrays
{
	class Program
	{
		static void Main()
		{
			string A = Console.ReadLine();
			string B = Console.ReadLine();
			int smaller = Math.Min(A.Length, B.Length);
			for (int i = 0; i < smaller;i++){

				if (A[i] > B[i])
				{
					Console.WriteLine(">");
					break;
				}

				if(A[i] < B[i])
				{
					Console.WriteLine("<");
					break;
				}

				if (i == smaller-1)
				{
					if (A.Length == B.Length)
					{
						Console.WriteLine("=");
					}
					else if (A.Length > B.Length)
					{
						Console.WriteLine(">");
					}
					else Console.WriteLine("<");
				}
			}
		}
	}
}
