using System;

namespace _15.BitSwap
{
	class Program
	{
		static void Main()
		{
			uint n = uint.Parse(Console.ReadLine());
			int p = int.Parse(Console.ReadLine());
			int q = int.Parse(Console.ReadLine());
			int k = int.Parse(Console.ReadLine());

			uint mask = (uint)Math.Pow(2, k) - 1;

			uint takeP = (n & (mask << p)) >> p;
			uint takeQ = (n & (mask << q)) >> q;
		
			uint NumberPZeros = (n & ~(mask << p));
			uint PReplacedWithQ = NumberPZeros | (takeQ << p);  


			uint NumberQZeros = (PReplacedWithQ & ~(mask << q));
			uint QReplacedWihtP = NumberQZeros | (takeP << q);

			Console.WriteLine(QReplacedWihtP);
		}
	}
}
