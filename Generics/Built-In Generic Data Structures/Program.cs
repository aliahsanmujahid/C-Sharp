using System;
using System.Collections.Generic;

class Program
{
    static void printitems<T>(List<T> items)
    {
        foreach (T item in items)
            Console.WriteLine(item);
    }
    static void Main(string[] args)
    {

        List<int> myints = new List<int>();
        myints.Add(12); myints.Add(12); myints.Add(12); myints.Add(12); myints.Add(12);
        printitems(myints);

        List<string> mystring = new List<string>();
        mystring.Add("fgh"); mystring.Add("fgh"); mystring.Add("fgh"); mystring.Add("fgh");
        printitems(mystring);


    }
}

