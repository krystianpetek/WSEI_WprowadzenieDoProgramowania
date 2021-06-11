using System;
using System.Collections.Generic;

namespace StrukturaStos
{
    public class Program
    {
        static void Main()
        {

            var stos = new Stos<char>();
            if (stos is StrukturaStos.IStos<char>)
                Console.WriteLine("Stos<T> implemented");
            else
                Console.WriteLine("Stos<T> not implemented");

            var s = new Stos<string>();
            s.Push("aaa");
            s.Push("bbb");
            s.Push("ccc");
            foreach (var x in s.ToArray())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine($"na szczycie jest: {s.Peek}");
            Console.WriteLine($"liczba elementów na stosie: {s.Count}");
            while (!s.IsEmpty)
            {
                Console.WriteLine($"zdejmuje: {s.Pop()}");
            }
            if (s.IsEmpty)
                Console.WriteLine("stos jest pusty");
        }
    }
}
