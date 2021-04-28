using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Expresion_Tree
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myclass = new MyClass();

            Func<MyClass, string> func = c => c.MyMethod(42, "my text number");

            var result = func(myclass);

            Console.WriteLine(result);

        }
    }
}
