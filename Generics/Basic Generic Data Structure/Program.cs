using System;

class list<T>
{
    T[] ints = new T[3];
    int currentindex;
    public void add(T i)
    {
        if (currentindex == ints.Length)
            grow();
        ints[currentindex] = i;
        currentindex++;
    }
    public T get(int index)
    {
        return ints[index];
    }
    void grow()
    {
        T[] temp = new T[ints.Length * 2];
        Array.Copy(ints, temp, ints.Length);
        ints = temp;
    }
    public int length { get { return ints.Length; } }

}
class Program
    {
        static void Main(string[] args)
        {
        list<int> myints = new list<int>();
        myints.add(12); myints.add(12); myints.add(12); myints.add(12); myints.add(12);

        for (int i = 0; i < myints.length - 1; i++)
            Console.WriteLine(myints.get(i));
        list<string> mystring = new list<string>();
        mystring.add("fgh"); mystring.add("dfg"); mystring.add("dfg"); mystring.add("dfg"); mystring.add("dfg");

        for (int i = 0; i < mystring.length - 1; i++)
            Console.WriteLine(mystring.get(i));

    }
    }

