using System;

class Program
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        char c = char.Parse(Console.ReadLine());

        Console.Write(' ');
        Console.Write(c);
        Console.Write(new String(' ', s / 4 -1));
        Console.WriteLine(c);

        for (int i = 0; i < s / 4-1; i++)
        {
            Console.Write(' ');
            Console.Write(new String(c, s / 4 + 1));
            Console.WriteLine();
        }

        for (int i = 0; i < s / 4-1; i++)
        {
            Console.Write("  ");
            Console.Write(new String(c, s / 4-1));
            Console.WriteLine();
        }

        for (int i = 0; i < s / 4-1; i++)
        {
            Console.Write(' ');
            Console.Write(new String(c, s / 4 +1));
            Console.WriteLine();
        }

        Console.Write(' ');
        Console.Write(new String(c, s / 4 + 1));
        Console.Write(new String(' ', 3));
        Console.Write(new String(c, s / 4));
        Console.WriteLine();

        for (int i = 0; i < s / 4 + 1; i++)
        {
            Console.Write(new String(c, s / 4 + 3));
            Console.Write("  ");
            Console.Write(c);
            Console.WriteLine();
        }

        Console.Write(new String(c, s / 4 + 3));
        Console.Write(' ');
        Console.Write(new String(c,2));
        Console.WriteLine();

        Console.Write(' ');
        Console.Write(new String(c, s / 4 + 4));
        Console.WriteLine();
    }
}

