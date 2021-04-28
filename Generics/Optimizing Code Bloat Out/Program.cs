using System;
class mainclass
    {
    //static void DoSometing(int args) { }
    //static void DoSometing(char args) { }
    //static void DoSometing(bool args) { }
    //static void DoSometing(mainclass args) { }
    //static void DoSometing(string args) { }

    static void DoSometing<T>(T args) { }
    static void Main(string[] args)
        {
            DoSometing(5);
        DoSometing('j');
        DoSometing(false);
        DoSometing(new mainclass());
        DoSometing("hello");
        DoSometing(new object());

    }
    }
