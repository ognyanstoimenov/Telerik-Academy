using System;

namespace _04.Four_Digits
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int first = N / 1000;
            int second = (N / 100) % 10;
            int third = (N / 10) % 10;
            int fourth = N % 10;

            int sum = first + second + third + fourth;
            string reverse = string.Format("{3}{2}{1}{0}", first, second, third, fourth);
            string lastFirst = string.Format("{3}{0}{1}{2}", first, second, third, fourth);
            string middleChange = string.Format("{0}{2}{1}{3}", first, second, third, fourth);

            Console.WriteLine(sum + "\n" + reverse + "\n" + lastFirst + "\n" + middleChange);
           
        }
    }
}
