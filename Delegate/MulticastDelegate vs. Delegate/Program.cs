using System;
using System.Collections.Generic;

delegate int MeDelegate();
class Program
{
    static void Main()
    {
        MeDelegate d = returnfive;
        d += returnten;
        d += return22;
        int value = d();
        foreach(int i in getall(d))
           Console.WriteLine(i);
    }

    static List<int> getall(MeDelegate d)
    {
        List<int> ints = new List<int>();
        foreach (MeDelegate del in d.GetInvocationList())
            ints.Add(del());
        return ints;  
    }

    static int returnfive() { return 5; }
    static int returnten() { return 10; }
    static int return22() { return 22; }


}

