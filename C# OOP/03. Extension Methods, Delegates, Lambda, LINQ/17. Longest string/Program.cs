namespace _17.Longest_string
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	class Program
	{
		static void Main()
		{
			string[] arrOfStrings = { "Meme", "Neshto drugo", "Neshto", "Orgomen string e tova", "Neshtobaqdulgo", "Ne dostatuchno dulug string", "Eto tova e nai dulgiq string, koito trqbva da vurne programata :)" };

			var result =
				(from str in arrOfStrings
				 orderby str.Length descending
				 select str).First();

			Console.WriteLine(result);
				
		}
	}
}
