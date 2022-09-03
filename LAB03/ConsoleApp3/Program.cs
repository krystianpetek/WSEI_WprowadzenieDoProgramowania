using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string wejscie = Console.ReadLine();
            int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);
            short a = Convert.ToInt16(dane[0]);
            short b = Convert.ToInt16(dane[1]);
            ushort c = Convert.ToUInt16(dane[2]);

            //ZABEZPIECZENIE
            if (c == 0) return;

            //SORTOWANIE
            if (a > b)
            {
                short temp = a;
                a = b;
                b = temp;
            }
            // OKRESLENIE DLUGOSCI TABLICY
            a += 1;
            int dlugoscTablicy = 0;
            for (short i = a; i < b; i++)
            {
                if (i % c == 0)
                {
                    dlugoscTablicy++;
                }
            }
            short[] tablica = new short[dlugoscTablicy];
            // ZAPISANIE LICZB W TABLICY
            int licznikIteracji = 0;
            for (short i = a; i < b; i++)
            {
                if (i % c == 0)
                {
                    tablica[licznikIteracji] = i;
                    licznikIteracji++;
                }
            }
            if(tablica.Length == 0)
            {
                Console.WriteLine("empty");
            }
            //WYPISANIE WARTOSCI
            for (short i = 0; i < tablica.Length; i++)
            {
                if (tablica.Length > 10)
                {
                    for (short j = 0; j < 3; j++)
                    {
                        Console.Write($"{tablica[j]}, ");
                    }
                    Console.Write($"..., {tablica[tablica.Length - 2]}, {tablica[tablica.Length - 1]}");
                    break;
                }
                if (tablica[tablica.Length - 1] == tablica[i])
                    Console.WriteLine(tablica[i]);
                else
                    Console.Write($"{tablica[i]}, ");
            }
        }
    }
}
