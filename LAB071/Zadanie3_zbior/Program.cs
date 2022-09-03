using System;
using System.Collections.Generic;
namespace Zadanie3_zbior
{
    class Program
    {
        static int numer = 0;
        static int num()
        {
            numer++;
            return numer;
        }
        static void Srednia(HashSet<int> zbior)
        {
            Console.Write($"\n\nŚrednia arytmetyczna zbioru #{numer}: ");
            int suma = 0;
            foreach (int x in zbior)
                suma += x;
            double srednia = (double)suma / zbior.Count;
            Console.Write(srednia);
        }
        static void DisplaySet<T>(ISet<T> set)
        {
            num();
            Console.Write($"\nZbiór #{numer}: ".PadRight(14) + "{ ");
            foreach (var x in set)
                Console.Write($"{x} ");
            Console.Write("}".PadRight(15));
        }
        static void Main()
        {
            HashSet<int> A = new HashSet<int>() { 1, 3, 5, 2, 7, 8 };
            HashSet<int> B = new HashSet<int>() { 2, 1, 5, 3, 9, 6 };

            Console.WriteLine("Zbiór A: ");
            foreach (int a in A)
                Console.Write($"{a} ");
            Console.WriteLine("\n");
            Console.WriteLine("Zbiór B: ");
            foreach (int b in B)
                Console.Write($"{b} ");
            Console.WriteLine();

            HashSet<int> C = new HashSet<int>(A);
            C.UnionWith(B);
            Console.Write("\nSuma zbiorów A oraz B");
            DisplaySet(C);

            int[] dane = new int[C.Count];
            C.CopyTo(dane);
            Array.Sort(dane, (x, y) => y.CompareTo(x));
            C = new HashSet<int>(dane);
            Console.Write("\n\nSuma zbiorów A oraz B posortowana malejąco");
            DisplaySet(C);
            Srednia(C);

            C = new HashSet<int>(A);
            C.IntersectWith(B);
            Console.Write("\n\nCzęść wspólna zbioru A i B");
            DisplaySet(C);

            C = new HashSet<int>(A);
            C.SymmetricExceptWith(B);
            Console.Write("\n\nRoznica symetryczna zbiorów A i B");
            DisplaySet(C);

            Console.WriteLine("\n\nCzy zbiór {6,9} należy do roznicy symetrycznej zbiorów A i B ?");
            Console.Write((C.Contains(6) && C.Contains(9) ? "TAK" : "NIE"));
            Console.WriteLine();
                

        }
    }
}
