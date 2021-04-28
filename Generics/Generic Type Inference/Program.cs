using System;

class myclass<T>
{
    public myclass(T args) { }

}
class Program
    {
        static void p<T> (T item) { Console.WriteLine(item); }
        static void Main(string[] args)
        {
        myclass<int> m = new myclass<int>(5);
        p(5);
        p("tvgbhnj");
        p<string>("sdfg");
    }
    }

