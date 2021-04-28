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
        myclass<string>.value = 10;
        myclass<char>.value = 10;
        myclass<mainclass>.value = 10;

        Console.WriteLine(myclass<string>.value);
        Console.WriteLine(myclass<char>.value);
        Console.WriteLine(myclass<mainclass>.value);
    }
    }

