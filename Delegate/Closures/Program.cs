using System;

class Program
 {
        static void Main()
        {
        //int i = 0;
        //Action a = () => i++;
        Action a = Givemeaction();
          a();
          a();

    }
    static Action Givemeaction() {

        Action ret = null;
        int i = 0;
        ret += () =>
        {
            Console.WriteLine("First Method " + i++);
            i++;
        };
        ret += () =>
        {
            Console.WriteLine("Second Method " + i++);
            i++;
        };
        return ret;
    }

}
