using System;

    class Program
    {
        static void Main()
        {
        int a = 5;
        int b = 10;
        int c;
        Console.WriteLine(a);
        Console.WriteLine(b);
        c = b;// c = 10;
        b = a;// b = 5;
        a = c;
        Console.WriteLine(a);
        Console.WriteLine(b);
        }
    }

