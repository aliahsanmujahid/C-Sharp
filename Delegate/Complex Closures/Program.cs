using System;

class Program
{
    static void Main()
    {

        Action a = Givemeaction();
        Action b = Givemeaction();

        b(); a(); a(); a();

    }
    public class Displayaodi
    {
        int i = 5;
        public void ascas() {

            i++;
            Console.WriteLine(i);
        }
        public void asdsdcas()
        {
            i += 2;
            Console.WriteLine(i);
        }
    }
    static Action Givemeaction()
    {

        Action ret = null;
        var temp = new Displayaodi();
        ret += temp.ascas;
        ret += temp.asdsdcas;

        return ret;

    }

}
