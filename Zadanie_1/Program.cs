using System;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int wielkosc_tablicy = args.Length;
            string imie;
            string nazwisko;
            int wiek;

            if (wielkosc_tablicy == 0)
            {
                Console.WriteLine("Brak danych");
            }
            else if(wielkosc_tablicy == 1)
            {
                imie = args[0];
                Console.WriteLine("Witaj {0} ", imie);
            }
            else if(wielkosc_tablicy == 2)
            {
                imie = args[0];
                nazwisko = args[1];
                Console.WriteLine("Witaj {0} {1} ",imie, nazwisko);
            }
            else
            {
                imie = args[0];
                nazwisko = args[1];
                Console.WriteLine($"Witaj {imie} {nazwisko}");

                wiek = Convert.ToInt32(args[2]);
                if (wiek <= 0)
                {
                    Console.WriteLine("BŁĘDNE DANE");
                }
                else if (wiek < 67)
                {
                    Console.WriteLine($"Mając {wiek} lat do emerytury zostało Ci jeszcze {67-wiek} lat");
                }
                else
                {
                    Console.WriteLine("Jesteś już emerytem");
                }
            }
        }
    }
}
