using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("GSM TEST");
		GSMTest.Start();

		Console.WriteLine(new string('=', 50));
		Console.WriteLine(new string('=', 50));

		Console.WriteLine("CALL HISTORY TEST");
		GSMCallHistoryTest.Start();
	}
}