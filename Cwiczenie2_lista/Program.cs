using System;
using System.Collections.Generic;
namespace Cwiczenie2_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zwierzeta = { "mucha", "krowa", "zebra" };
            List<string> spisZwierzat = new List<string>(zwierzeta);
            spisZwierzat.Add("kot");
            spisZwierzat.Add("pies");

            for (int i = 0; i < spisZwierzat.Count; i++)
                Console.WriteLine(spisZwierzat[i]);

            Console.WriteLine();
            Console.WriteLine(string.Join(';', spisZwierzat));

            spisZwierzat.Sort();
            Console.WriteLine(string.Join(';', spisZwierzat));

            spisZwierzat.Sort((s1, s2) => s1.Length - s2.Length);
            Console.WriteLine(string.Join(';', spisZwierzat));
        }
    }
}
