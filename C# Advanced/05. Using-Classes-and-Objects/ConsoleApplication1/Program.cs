using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			int calories;
			Cat Tom = new Cat();
			Cat Meme = new Cat();
			Tom.Eat(2);
			Meme.Eat(1);
			Console.WriteLine(Cat.weight);


		}
	}

	public class Cat
	{
		public static int weight = 10;
		public void Eat(int calories)
		{
			weight += calories;
		}
	}

}
