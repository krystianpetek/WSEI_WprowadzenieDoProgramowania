
using System;
using System.Collections.Generic;
using System.Text;

namespace RKS___RK_Sorting
{
    //9 55
    //1 2 3 4 55 55 44 2 0
    class Program
    {
        static void Main(string[] args)
        {
            string[] pierwszaLinia = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int N = int.Parse(pierwszaLinia[0]);
            int C = int.Parse(pierwszaLinia[1]);

            if (N < 1 || N > 1000 && C < 1 || C > 1000000000) // Sprawdzenie wejscia
                throw new ArgumentException("ERROR");

            string[] drugaLinia = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int x = 0; x < drugaLinia.Length; x++)
                if (int.Parse(drugaLinia[x]) > C)
                    throw new ArgumentException("ERROR");

            if (drugaLinia.Length != N)
                throw new ArgumentException("ERROR");

            Dictionary<string, int> katalog = new Dictionary<string, int>();

            for (int x = 0; x < drugaLinia.Length; x++)
            {
                if (katalog.ContainsKey(drugaLinia[x]))
                    katalog[drugaLinia[x]]++;
                else
                    katalog.Add(drugaLinia[x], 1);
            }

            string[] klucz = new string[katalog.Count];
            katalog.Keys.CopyTo(klucz, 0);
            int[] wartosc = new int[katalog.Count];
            katalog.Values.CopyTo(wartosc, 0);

            for (int x = 0; x < klucz.Length - 1; x++)
            {
                if (wartosc[x + 1] > wartosc[x])
                {
                    for (int sortPoprzedni = (x + 1); sortPoprzedni > 0; sortPoprzedni--)
                    {
                        if (wartosc[sortPoprzedni] > wartosc[sortPoprzedni - 1])
                        {
                            var temp = wartosc[sortPoprzedni];
                            wartosc[sortPoprzedni] = wartosc[sortPoprzedni - 1];
                            wartosc[sortPoprzedni - 1] = temp;

                            var tempKlucz = klucz[sortPoprzedni];
                            klucz[sortPoprzedni] = klucz[sortPoprzedni - 1];
                            klucz[sortPoprzedni - 1] = tempKlucz;
                        }
                    }
                }
            }

            StringBuilder wynik = new StringBuilder();

            for (int x = 0; x < wartosc.Length; x++)
                for (int W = wartosc[x]; W > 0; W--)
                    wynik.Append($"{klucz[x]} ");

            Console.Write(wynik);
        }
    }
}