using System;

class Program
{
    static void Main(string[] args)
    {
        Func<int, bool> test = i => i < 5;

        Console.WriteLine(test(4));
    }
}

