using System;

public class GSMCallHistoryTest
{
	public static void Start()
	{
		const decimal PRICE_PER_MINUTE = 0.37M;

		GSM S3Neo = new GSM("Samsung", "Galaxy S3 Neo", 300, "Gorchev", "Removable", 210, 9, BatteryType.LiIon, 4f, 16);


		S3Neo.AddCall(new Call(DateTime.Parse("01.01.2015 8:30:20"), "0881234567", 120, PRICE_PER_MINUTE));
		S3Neo.AddCall(new Call(DateTime.Parse("05.06.2016 20:30:20"), "0887654321", 360, PRICE_PER_MINUTE));
		S3Neo.AddCall(new Call(DateTime.Now, "0884312234", 30, PRICE_PER_MINUTE));

		Console.WriteLine(new string('-', 30));
		Console.WriteLine(S3Neo);

		decimal totalPrice = 0;
		foreach (var call in S3Neo.CallHistory)
		{
			totalPrice += call.Cost;
		}

		Console.WriteLine();
		Console.WriteLine("Total price before remove {0}", totalPrice);
		Console.WriteLine();

		int indexOfLongestCall = 0;
		int longestDuration = S3Neo.CallHistory[0].Duration;
		for (int i = 0; i < S3Neo.CallHistory.Count; i++)
		{
			if (S3Neo.CallHistory[i].Duration > longestDuration)
				indexOfLongestCall = i;
		}

		S3Neo.RemoveCall(indexOfLongestCall);

		totalPrice = 0;
		foreach (var call in S3Neo.CallHistory)
		{
			totalPrice += call.Cost;
		}

		Console.WriteLine();
		Console.WriteLine("Total price after remove {0}", totalPrice);
		Console.WriteLine();

		S3Neo.ClearCallHistory();

		Console.WriteLine(new string('-', 30));
		Console.WriteLine(S3Neo);
	}
}