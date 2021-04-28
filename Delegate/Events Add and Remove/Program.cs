using System;

class Cow
{
    public Action mooing;
    public event Action Mooing
    {
        add {
            mooing += value;
            mooing += value;
            mooing += value;
            Console.WriteLine("Adding ");
        }
        remove {
            mooing -= value;
            Console.WriteLine("Removing ");
        }
    }
    public void PushsleepingCow()
    {
        if (mooing != null)
            mooing();
    }

}


class MainClass
{
    static void Main()
    {
        Cow c = new Cow();
        c.Mooing += () => Console.WriteLine("Giggle");
        c.PushsleepingCow();
    }
}

