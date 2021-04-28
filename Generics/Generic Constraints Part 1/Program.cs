using System;

class ClassOne { public ClassOne() { }  }
class ClassTwo: ClassOne { public ClassTwo() { } }
class ClassThree { public ClassThree(int i, char c) { } }
class Program
{
    static T Product<T>() where T : ClassOne, new ()
    {

        T returnVal = new T();

        return returnVal;


    }
    static void Main(string[] args)
    {
        Product<ClassOne>();
        Product<ClassTwo>();
    }
}

