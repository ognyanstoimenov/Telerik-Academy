using System;

namespace _02.Busses
{
	class Program
	{
		static void Main()
		{
			int C = int.Parse(Console.ReadLine());
			int previousSpeed = int.Parse(Console.ReadLine());
			int groups = 1;
			for (int i = 1; i < C; i++)
			{
				int currentSpeed = int.Parse(Console.ReadLine());
				if (currentSpeed > previousSpeed)
				{
					continue;
				}
				else
				{
					previousSpeed = currentSpeed;
					groups++;
				}
			}
			Console.WriteLine(groups);
		}
	}
}
