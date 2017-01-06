namespace StringBuilder.Substring
{
	using System;
	using System.Text;

	static class ExtensionMethods
	{
		public static StringBuilder Substring(this StringBuilder text,int index,int length)
		{
			return text.Remove(index, length);
		}
	}
}
