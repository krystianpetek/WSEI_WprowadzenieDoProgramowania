using System;
using System.Collections.Generic;
namespace KolekcjeAgregatorLogow
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortedDictionary<string, string/*SortedDictionary<string, int>*/> slownik = new SortedDictionary<string, string/*SortedDictionary<string, int>*/>();
            //SortedDictionary<string, List<string>> slownik = new SortedDictionary<string, List<string>>();
            SortedDictionary<string, string> slownikIP = new SortedDictionary<string, string>();
            SortedDictionary<string, int> slownikCzasu = new SortedDictionary<string, int>();

            //Wczytywanie liczby N
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 1000)
                throw new ArgumentException("error");

            //Wczytywanie N wierszów
            for (int i = 0; i < n; i++)
            {
                string[][] tab = new string[n][];
                tab[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string wejscieIP = tab[i][0], wejscieUSER = tab[i][1], wejscieDURATION = tab[i][2];

                // Sprawdzenie poprawności adresu IP
                try
                {
                    string[] adresIP = new string[4];
                    adresIP = wejscieIP.Split(".", StringSplitOptions.RemoveEmptyEntries);
                    for (int x = 0; x < 4; x++)
                        if (int.Parse(adresIP[x]) < 0 || int.Parse(adresIP[x]) > 255)
                            throw new ArgumentException("error");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                // Sprawdzenie poprawności nazwy użytkownika
                try
                {
                    foreach (var znak in wejscieUSER)
                        if (char.IsLetter(znak) == false)
                            throw new ArgumentException("nazwa nie jest literą");

                    if (wejscieUSER.Length > 20 || wejscieUSER.Length <= 0)
                        throw new ArgumentException("długość nazwy wykracza poza zakres");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                // Sprawdzenie poprawności czasu trwania sesji
                try
                {
                    var duration = int.Parse(wejscieDURATION);

                    if (duration < 1 || duration > 1000)
                        throw new ArgumentException("przekroczono czas");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                // SUMA CZASU UZYTKOWNIKOW
                if (slownikCzasu.ContainsKey(wejscieUSER))
                    slownikCzasu[wejscieUSER] += int.Parse(wejscieDURATION);
                else
                    slownikCzasu.Add(wejscieUSER, int.Parse(wejscieDURATION));

                // SUMA ADRESOW IP
                if (slownikIP.ContainsKey(wejscieUSER))
                {
                    if (slownikIP.ContainsValue(wejscieIP) == false)
                        slownikIP[wejscieUSER] += $" {wejscieIP}";
                }
                else
                    slownikIP.Add(wejscieUSER, wejscieIP);
            }

            string[] tablicaUSER = new string[slownikIP.Count];
            slownikIP.Keys.CopyTo(tablicaUSER, 0);
            string[] tablicaIP = new string[slownikIP.Count];
            slownikIP.Values.CopyTo(tablicaIP, 0);
            string[][] tablicaSortIP = new string[slownikIP.Keys.Count][];


            // Podzielenie ciągu adresów na oddzielne adresy IP
            int X = 0;
            while (true)
            {
                if (X == tablicaSortIP.Length)
                    break;
                tablicaSortIP[X] = tablicaIP[X].Split(" ");
                X++;
            }

            string[][] temp = new string[tablicaSortIP.Length][];

            for (int h = 0; h < tablicaSortIP.Length; h++)
            {
                temp[h] = new string[tablicaSortIP[h].Length];
                int j = 0;
                for (int i = 0; i < tablicaSortIP[h].Length - 1; i++)
                {
                    if (tablicaSortIP[h][i] != tablicaSortIP[h][i + 1])
                    {
                        temp[h][j++] = tablicaSortIP[h][i];
                    }
                }
                temp[h][j++] = tablicaSortIP[h][tablicaSortIP[h].Length - 1];

                Array.Sort(temp[h]);
                string wynik="";

                for (int z = 0; z < temp[h].Length; z++)
                    if (temp[h][z] == null)
                        continue;
                    else
                        if (z == temp[h].Length-1)
                        wynik += $"{temp[h][z]}";
                    else
                        wynik += $"{temp[h][z]}, ";
                Console.WriteLine($"{tablicaUSER[h]}: {slownikCzasu[tablicaUSER[h]]} [{wynik}]");

            }
        }
    }
}