using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        double razlika = Math.Abs(a - b);
        if (razlika < eps)
        {
            Console.WriteLine("true");
        }
        else Console.WriteLine("false");

    }
}
