using System;

class Pair<T, U>
{
    public T First { get; set; }
    public U Second { get; set; }
    public override string ToString()
    {
        return "{" + First + ", " + Second + " }";
    }
}
 class Program
    {
        static void Main(string[] args)
        {
        Pair<int, int> p = new Pair<int, int> { First=3, Second=6 };


        Pair<string, string> marrage1 = new Pair<string, string> { First = "poi", Second = "poipoi" };
        Console.WriteLine(p);
        Console.WriteLine(marrage1);
    }
    }

