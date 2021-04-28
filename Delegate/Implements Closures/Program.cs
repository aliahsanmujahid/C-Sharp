using System;

class Program
{
    class DisplayClass
    {
        public int i;
        public void thelamdaexpgeneration()
        {
            i++;
            Console.WriteLine(i);
        }
    }
    static void Main()
    {

        Action a = Givemeaction();
        a();
        a();

    }
    static Action Givemeaction()
    {
        
        return new Action(new DisplayClass().thelamdaexpgeneration);
 
    }

}
