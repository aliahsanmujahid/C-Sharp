using System;

class myclass<T>
{
    public static int value;
    static myclass()
    {
        Console.WriteLine(typeof(myclass<T>));
    }
}
class mainclass
{
    static void Main(string[] args)
    {
        myclass<myclass<string>>.value = 10;

    }
}

