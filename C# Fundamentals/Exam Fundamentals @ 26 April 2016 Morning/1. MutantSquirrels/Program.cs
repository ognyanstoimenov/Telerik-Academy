using System;

class Program
{
    static void Main()
    {
        ulong trees = ulong.Parse(Console.ReadLine());
        ulong branches = ulong.Parse(Console.ReadLine());
        ulong squirrelsOnABranch = ulong.Parse(Console.ReadLine());
        ulong tails = ulong.Parse(Console.ReadLine());

        ulong totalTails = (tails * squirrelsOnABranch * branches * trees);
        if (totalTails % 2 == 0)
        {
            Console.WriteLine("{0:F3}", (totalTails * 376439d));
        }
        else Console.WriteLine("{0:F3}", totalTails / 7d);
    }
}
