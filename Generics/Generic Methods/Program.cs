using System;
using System.Collections.Generic;

class list<T>
{
    T[] ints = new T[3];
    int currentindex;
    public void Add(T i)
    {
        if (currentindex == ints.Length)
            Grow();
        ints[currentindex] = i;
        currentindex++;
    }
    public T Get(int index)
    {
        return ints[index];
    }
    void Grow()
    {
        T[] temp = new T[ints.Length * 2];
        Array.Copy(ints, temp, ints.Length);
        ints = temp;
    }
    public int Length { get { return ints.Length; } }

}
class Program
{
    static void printitems<T>(list<T> items)
    {
        for (int i = 0; i < items.Length; i++)
            Console.WriteLine(items.Get(i));
    }
    static void Main(string[] args)
    {

        list<int> myints = new list<int>();
        myints.Add(12); myints.Add(12); myints.Add(12); myints.Add(12); myints.Add(12);
        printitems(myints);

        list<string> mystring = new list<string>();
        mystring.Add("fgh"); mystring.Add("fgh"); mystring.Add("fgh"); mystring.Add("fgh");
        printitems(mystring);


    }
}

