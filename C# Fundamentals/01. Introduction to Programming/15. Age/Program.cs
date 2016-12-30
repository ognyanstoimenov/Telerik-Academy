using System;

class Program
{
    static void Main()
    {

        DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", null);
        DateTime currentDate = DateTime.Now;
        int Age = currentDate.Year - birthDate.Year;
        {
            if (birthDate.Month > currentDate.Month)
                Age-=1;

            else if (birthDate.Month == currentDate.Month && birthDate.Day > currentDate.Day)
                Age-=1;

            Console.WriteLine(Age);
            Console.WriteLine(Age + 10);
        }
    }

}
