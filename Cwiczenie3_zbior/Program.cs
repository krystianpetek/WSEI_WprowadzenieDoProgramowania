using System;
using System.Collections.Generic;
namespace Cwiczenie3_zbior
{
    class Program
    {
        static int[] dane = { 4, 3, 6, 1, 2, 7, 8, 9, 4, 2, 2 };
        static void Main(string[] args)
        {
            HashSet<int> zbiorA = new HashSet<int>(dane);
            zbiorA.Add(-1);

            foreach (var x in zbiorA)
                Console.WriteLine(x);

            Console.WriteLine(string.Join(' ', zbiorA));

            zbiorA.CopyTo(dane);
            Console.WriteLine(string.Join(' ', dane));
            Console.WriteLine();

            // -----------------------------------------

            var zbiorB = new SortedSet<int>(dane);
            Console.WriteLine(string.Join(' ', zbiorB));
            zbiorB.Add(5);
            Console.WriteLine(string.Join(' ', zbiorB));
            zbiorB.ExceptWith(zbiorA);
            Console.WriteLine(string.Join(' ', zbiorB));
        }
    }
}
