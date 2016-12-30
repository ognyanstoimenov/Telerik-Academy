public class Display
{
	public Display(float? size = null, int? numberOfColors = null)
	{
		Size = size;
		NumberOfColors = numberOfColors;
	}

	public float? Size { get; set; }
	public int? NumberOfColors { get; set; }
}