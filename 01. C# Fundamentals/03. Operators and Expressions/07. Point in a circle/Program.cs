using System;

namespace _07.Point_in_a_circle
{
    class Program
    {
        static void Main()
        {
            double x = int.Parse(Console.ReadLine());
            double y = int.Parse(Console.ReadLine());

            double z = Math.Sqrt(x * x + y * y);
            if (z < 2)
            {
                Console.WriteLine("yes {0:F2}",z);
            }
            else Console.WriteLine("no {0:F2}",z);
        }
    }
}