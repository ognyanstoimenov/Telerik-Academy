namespace _03.Range_Exceptions
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class RangeExceptions<T> : ApplicationException
	{

		public RangeExceptions(T start, T end)
		{
			this.Start = start;
			this.End = end;
		}

		public T Start { get; private set; }

		public T End { get; private set; }

		public override string Message
		{
			get
			{
				return "Value out of range!";
			}
		}
	}
}

