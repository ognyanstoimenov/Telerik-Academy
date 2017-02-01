using System;

namespace _13.Modify_Bit
{
	class Program
	{
		static void Main()
		{

			ulong N = ulong.Parse(Console.ReadLine());
			int P = int.Parse(Console.ReadLine());
			ulong v = ulong.Parse(Console.ReadLine());
			ulong mask = 1;
			if (v == 0)
			{
				v = ~(mask << P);
				Console.WriteLine(N & v);
			}
			else
			{
				v = (mask << P);
				Console.WriteLine(N | v);
			}
		}
	}
}
