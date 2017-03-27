using System;

namespace _2
{
	class Program
	{
		static void Main()
		{
			string directions = Console.ReadLine();
			int position = 0;
			for(int i = 0; i < directions.Length; i+=0)
			{
				if (directions[i] == '^')
				{
					Console.WriteLine("Djor and Djano are at the party at {0}!",i);
					break;
				}
				if(directions[i] >= 'a')
				{
					i += directions[i] - 'a' + 1;
				}
				else if(directions[i] >= 'A' )
				{
					i -= directions[i] - 'A' + 1;
				}
				
				if (i < 0)
				{
					Console.WriteLine("Djor and Djano are lost at {0}!",i);
					break;
				}
				if (i > directions.Length)
				{
					Console.WriteLine("Djor and Djano are lost at {0}!", i);
					break;
				}
			}
		}
	}
}
