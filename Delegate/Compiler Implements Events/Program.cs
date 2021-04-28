using System;

class Cow
{
    public event Action Mooing;

}
class MainClass
    {
        static void Main()
        {
            Cow c = new Cow();
            c.Mooing();
        }
    }

