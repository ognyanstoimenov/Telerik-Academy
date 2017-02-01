public class Battery
{
	public Battery(string model, int? hoursIdle = null, int? hoursTalk = null, BatteryType? batteryType = null)
	{
		Model = model;
		HoursIdle = hoursIdle;
		HoursTalk = hoursTalk;
		Type = batteryType;
	}

	public string Model { get; set; }
	public int? HoursIdle { get; set; }
	public int? HoursTalk { get; set; }
	public BatteryType? Type { get; set; }
}

public enum BatteryType
{
	LiIon, NiMH, NiCd
}