using System;

namespace _10.Fibonacci_Numbers
{
	class Program
	{
		static void Main()
		{
			uint N = uint.Parse(Console.ReadLine());
			ulong secondNum = 0;
			ulong firstNum = 0;
			ulong sum;
			for (int i = 1; i <= N; i++)
			{
				sum = i == 2 ? 1 : firstNum + secondNum;
				Console.Write(i == N ? "{0}\n" : "{0}, ", sum);
				firstNum = secondNum;
				secondNum = sum;
			}
		}
	}
}
