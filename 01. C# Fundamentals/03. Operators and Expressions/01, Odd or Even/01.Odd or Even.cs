using System;

namespace _01__Odd_or_Even
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine((number%2==0)? "even " + number : "odd " + number);
        }
    }
}
