using System.Collections.Generic;
using System.Text;

public class GSM
{
	public static GSM iPhone4s = new GSM("Apple", "iPhone 4s", 300, "Az", "NonRemovable", 200, 8, BatteryType.LiIon, 3.5f, 16);

	private List<Call> callHistory = new List<Call>();

	public GSM(string manufacturer, string model, decimal? price = null, string owner = null, string batteryModel = null, int? batteryHoursIdle = null, int? batteryHoursTalk = null, BatteryType? batteryType = null, float? displaySize = null, int? displayNumberOfColors = null)
	{
		Manufacturer = manufacturer;
		Model = model;
		Price = price;
		Owner = owner;
		Battery = new Battery(batteryModel, batteryHoursIdle, batteryHoursTalk);
		Display = new Display(displaySize, displayNumberOfColors);
	}

	public string Manufacturer { get; set; }
	public string Model { get; set; }
	public decimal? Price { get; set; }
	public string Owner { get; set; }
	public Battery Battery { get; set; }
	public Display Display { get; set; }
	public List<Call> CallHistory
	{
		get { return callHistory; }
		set { callHistory = value; }
	}

	public void AddCall(Call call)
	{
		CallHistory.Add(call);
	}
	public void RemoveCall(int index)
	{
		CallHistory.RemoveAt(index);
	}
	public void ClearCallHistory()
	{
		CallHistory = new List<Call>();
	}

	public override string ToString()
	{
		StringBuilder calls = new StringBuilder();
		foreach (var call in CallHistory)
		{
			calls.Append("\n\t\t");
			calls.Append(call);
		}

		return string.Format("Manufacturer: {0}\nModel: {1}\nPrice: {2}\nOwner: {3}\nBattery:\n\tModel: {4}\n\tHoursIdle: {5}\n\tHoursTalk: {6}\nDisplay:\n\tSize: {7}\n\tNumberOfColors: {8} million\n\tCall History: {9}", 
			Manufacturer, Model, Price, Owner, Battery.Model, Battery.HoursIdle, Battery.HoursTalk, Display.Size, Display.NumberOfColors, calls);
	}
}