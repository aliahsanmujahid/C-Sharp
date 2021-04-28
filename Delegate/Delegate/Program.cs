using System;

delegate void MeDelegate();
class Program
{
    static void Main()
    {
        //MeDelegate del0 = new MeDelegate(Foo);
        //MeDelegate del = Foo;
        //del();
        invokeDelegate(new MeDelegate(Foo));
        invokeDelegate(Goo);
    }
    static void invokeDelegate(MeDelegate deler)
    {
        deler();
    }
    static void Foo()
    {
        Console.WriteLine("Hello World!");
    }
    static void Goo()
    {
        Console.WriteLine("Hello World!");
    }
}

