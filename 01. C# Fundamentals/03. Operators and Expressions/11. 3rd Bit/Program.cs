using System;


namespace _11._3rd_Bit
{
	class Program
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			int thirdBit = n>>3;
			int mask = 1;

			Console.WriteLine(thirdBit & mask);
			
		}
	}
}
