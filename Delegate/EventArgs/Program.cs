using System;

class Cow
{
    public string Name { get; set; }
    public event EventHandler moo;
    public void BeTippedOver()
    {

        if (moo != null)
            moo(this, EventArgs.Empty);
    }

}


class MainClass
{
    static void Main()
    {
        Cow c1 = new Cow() { Name = "dscs" };
        c1.moo += giggle;
        Cow c2 = new Cow() { Name = "sdcsd" };
        c2.moo += giggle;
        Cow victiim = new Random().Next() % 2 == 0 ? c1 : c2;
        victiim.BeTippedOver();
    }
    static void giggle(object sender, EventArgs e)
    {
        Cow c = sender as Cow;
        Console.WriteLine("ds sd " + c.Name + " dfvd df");

    }

}

