namespace StringBuilder.Substring
{
	using System;
	using System.Text;

	class Program
	{
		static void Main(string[] args)
		{
			StringBuilder testText = new StringBuilder("memence");
			testText.Substring(3, 3);
			Console.WriteLine(testText);
		}
	}
}
