using System;
using System.Collections.Generic;

delegate bool MeDelegate(int n);
class Program
{
    static bool lesstanfive(int n) { return n < 5; }
    static bool lesstanten(int n) { return n < 10; }
    static bool gratetanfive(int n) { return n > 5; }
    static void Main()
    {
        int[] numbers = new[] { 2, 7, 1, 4, 9, 0 };
        IEnumerable<int> res = lessthanfive(numbers, n => n < 5);
        foreach (int num in res)
            Console.WriteLine(num);
    }

    static IEnumerable<int> lessthanfive(IEnumerable<int> nums, MeDelegate kormo)
    {
        foreach (int num in nums)
            if (kormo(num))
                yield return num;
    }


}

