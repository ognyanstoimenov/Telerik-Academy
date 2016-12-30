using System;

namespace _14.BitExchange
{
	class Program
	{
		static void Main()
		{
			uint Number = uint.Parse(Console.ReadLine());

			uint first3 = (Number & (7 << 3))>>3;
			uint far3 = (Number & (7 << 24)) >> 24;

			uint NumberFirstZeros = (uint)(Number & (~(7 << 3)));
			uint NumberFirst = NumberFirstZeros | (far3 << 3);

			uint NumberLastZeros = (uint)(NumberFirst & (~(7 << 24)));
			uint NumberLast = (NumberLastZeros | (first3 << 24));

			Console.WriteLine(NumberLast);


		}
	}
}
