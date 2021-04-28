using System;

delegate void MeDelegate();
class Program
{
    static void Main()
    {

        MeDelegate d = Foo;
        d();
        d += Goo;
        d += Soo;
        d -= Foo;
        d();

    }
    static void Foo()
    {
        Console.WriteLine("Hello foo!");
    }
    static void Goo()
    {
        Console.WriteLine("Hello goo!");
    }
    static void Soo()
    {
        Console.WriteLine("Hello soo!");
    }
}

