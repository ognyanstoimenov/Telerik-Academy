using System;


namespace _05.Third_digit
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int thirdDigit = (N / 100) % 10;

            if (thirdDigit == 7)
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false " + );
        }
    }
}
