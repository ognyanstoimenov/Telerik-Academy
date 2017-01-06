namespace _07.Timer
{
	using System;
	using System.Threading;

	class Program
	{
		public delegate void MyDelegate(Action act, int t);

		static void Main()
		{
			MyDelegate timer = Repeat;
			timer(Timer.Print, 3);
		}
		public static void Repeat(Action f, int t)
		{
			while (true)
			{
				f();
				Thread.Sleep(t * 1000);
			}
		}
	}
}
