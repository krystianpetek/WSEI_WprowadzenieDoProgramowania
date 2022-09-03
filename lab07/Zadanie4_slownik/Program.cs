using System;
using System.Collections.Generic;
using System.Linq;
namespace Zadanie4_slownik
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> slownikZwierzat = new Dictionary<string, int>()
            {
                { "kot",4 },
                { "pies",4 },
                { "krowa",4 },
                { "wąż", 0 },
                { "stonoga", 100 },
                { "rak", 10 }
            };
            foreach (var x in slownikZwierzat)
                Console.WriteLine($"{x} ");

            Console.WriteLine("\nCzy słownik zawiera element 'wąż'");
            Console.WriteLine(slownikZwierzat.ContainsKey("wąż") ? "TAK" : "NIE");
            Console.WriteLine(slownikZwierzat.TryGetValue("wąż", out int wyjscie));

            Console.WriteLine("\nCzy słownik zawiera zwierze które ma 6 nóg?");
            Console.WriteLine(slownikZwierzat.ContainsValue(6) ? "TAK" : "NIE");

            //if (slownikZwierzat.ContainsKey("pająk"))
            //    slownikZwierzat["pająk"] += 8;
            //else
            Console.Write("\nDodaje pająka z liczbą nóg 6");
            slownikZwierzat.Add("pająk", 6);

            Console.WriteLine();
            foreach (var x in slownikZwierzat)
                Console.WriteLine($"{x} ");

            //int iloscNog;
            //slownikZwierzat.TryGetValue("pająk", out iloscNog);

            slownikZwierzat["pająk"] = 8;

            string[] tablicaNazw = new string[slownikZwierzat.Count];
            slownikZwierzat.Keys.CopyTo(tablicaNazw, 0);
            Array.Sort(tablicaNazw);
            Console.WriteLine("\nNazwy zwierząt w kolejności rosnącej:");
            foreach (var x in tablicaNazw)
                Console.WriteLine($"{x} ");

            Console.WriteLine("\nLiczba nóg zwierząt: ");
            int[] tablicaNog = new int[slownikZwierzat.Values.Count];
            slownikZwierzat.Values.CopyTo(tablicaNog, 0);
            foreach (var x in tablicaNog)
                Console.WriteLine($"{x} ");

            Array.Clear(tablicaNazw, 0, tablicaNazw.Length);
            slownikZwierzat.Keys.CopyTo(tablicaNazw, 0);
            Array.Clear(tablicaNog, 0, tablicaNog.Length);
            slownikZwierzat.Values.CopyTo(tablicaNog, 0);

            Console.WriteLine("\nZwierzęta które mają 4 nogi: ");
            for (int i = 0; i < tablicaNazw.Length; i++)
                if (tablicaNog[i] == 4)
                    Console.WriteLine(tablicaNazw[i]);

            int sumaNog = 0;
            Console.WriteLine("\nSuma nóg wszystkich zwierząt: ");
            for (int i = 0; i < tablicaNog.Length; i++)
                sumaNog += tablicaNog[i];
            Console.WriteLine(sumaNog);

            slownikZwierzat.Remove("pająk");

            Console.WriteLine("\nPosortowane ilością nóg");
            foreach (var x in slownikZwierzat.OrderBy(i => i.Value))
                Console.WriteLine(x);
        }
    }
}
