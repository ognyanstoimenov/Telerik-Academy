using System;

class Program
{
    static int sumOfDeviders(int a)
    {
        int sum = 0;
        for (int i = 2; i <= a; i += 2)
        {
            if (a % i == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = A; i <= B; i++)
        {
            sum += sumOfDeviders(i);
        }
        Console.WriteLine(sum);
    }
}

