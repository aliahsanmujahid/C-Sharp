using System;
class Program
{
    static void Main()
    {
        Action del = (Action)Foo + BeNaugty + Goo;
        foreach (Action a in del.GetInvocationList())
        {
            try
            {
                a();
            }
            catch
            {
                Console.WriteLine("error");
            }
        }

            

    }
    static void Foo()
    {
        Console.WriteLine("Hello World!");
    }
    static void BeNaugty()
    {
        throw new Exception();
    }
    static void Goo()
    {
        Console.WriteLine("Hello World!");
    }
}

