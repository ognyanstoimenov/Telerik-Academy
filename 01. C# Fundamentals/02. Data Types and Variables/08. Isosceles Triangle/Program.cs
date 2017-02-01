using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        string triang = @"   ©

  © ©

 ©   ©

© © © ©";
        Console.WriteLine(triang);
    }
}
