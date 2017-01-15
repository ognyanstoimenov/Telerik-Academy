using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Range_Exceptions
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				throw new RangeExceptions<int>(2, 5);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			try
			{
				throw new RangeExceptions<DateTime>(DateTime.Now, DateTime.Now.AddDays(5));
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
