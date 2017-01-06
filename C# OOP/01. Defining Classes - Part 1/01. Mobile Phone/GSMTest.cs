using System;

public class GSMTest
{
	public static void Start()
	{
		GSM[] GSMArray = 
		{
			GSM.iPhone4s,
			new GSM("Samsung", "Galaxy S3 Neo", 300, "Elvogi", "Removable", 210, 9, BatteryType.LiIon, 4f, 16),
			new GSM("Nokia", "100", null, "Meme", "Removable", int.MaxValue, int.MaxValue / 10, BatteryType.NiMH, 2.5f, 4)
		};

		foreach (var gsm in GSMArray)
		{
			Console.WriteLine(new string('-', 30));
			Console.WriteLine(gsm);
		}
	}
}