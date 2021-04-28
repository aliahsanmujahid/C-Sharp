using System;

delegate void MeDelegate(int value);
class MainClass
{
    static void Main()
    {
        MeDelegate d = foo;
        Console.WriteLine(d.Method);
        Console.WriteLine(d.Target);
        MainClass m = new MainClass();
        d = m.goo;
        Console.WriteLine(d.Method);
        Console.WriteLine(d.Target);
    }

    static void foo(int u) { }
    void goo(int asdf){}

}

