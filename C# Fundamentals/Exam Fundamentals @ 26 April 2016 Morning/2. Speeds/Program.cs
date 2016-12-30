using System;

class Program
{
    static void Main()
    {
        short c = short.Parse(Console.ReadLine());
        int[] s = new int[c];
        int[] newS = new int[c];
        int tempSum = 0;
        int tempGroup = 1;
        int longestGroup = 1;
        int sum = 0;
        for (int i = 0; i < c; i++)
        {
            s[i] = short.Parse(Console.ReadLine());
            newS[i] = s[i];
        }

        for (int i = 1; i <= c; i++)
        {
            if (s[i - 1] < s[i])
            {
                s[i] = s[i - 1];
                tempSum += newS[i - 1];
                tempGroup++;
            }
            else
            {
                if (tempGroup > longestGroup)
                {
                    tempSum += newS[i];
                    longestGroup = tempGroup;
                    sum = tempSum;
                }

                tempGroup = 1;
                tempSum = 0;
            }
            if (tempGroup > longestGroup)
            {
                longestGroup = tempGroup;
            }
        }
        if (longestGroup == 1)
        {
            for (int i = 1; i < c; i++)
            {
                int max = newS[0];
                if (newS[i] > max)
                {
                    max = newS[i];
                }
                sum = max;
            }
        }
        Console.WriteLine(sum);
    }
}
