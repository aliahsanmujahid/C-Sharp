using System;
using System.Collections.Generic;

delegate T MeDelegate<T>();

class Program
{
    static void Main()
    {
        Func<int> d = returnfive;
        d += returnten;
        d += return22;
        Func<int, string, bool> f = intstrungbool;
        Action<string> a = takestringrv;
        int value = d();
        foreach (int i in getall(d))
            Console.WriteLine(i);
    }

    static bool intstrungbool(int i,string s)
    {
        return false;
    }
    static void takestringrv(string s)
    {
        
    }
    static IEnumerable<Targ> getall<Targ>(Func<Targ> d)
    {
        
        foreach (Func<Targ> del in d.GetInvocationList())
           yield return del();
        
    }

    static int returnfive() { return 5; }
    static int returnten() { return 10; }
    static int return22() { return 22; }


}

