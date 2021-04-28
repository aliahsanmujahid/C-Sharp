using System;

class Program
    {
        static void Main(string[] args)
        {
        //Func<int, bool> func = delegate (int i) { return i > 5; };
        //Func<int, string, bool> func = delegate (int i, string s) { return i > 5; };
        Func<int, bool> func = i => i > 5;
        Console.WriteLine(func(3));
        Console.WriteLine(func(7));
    }
    }

