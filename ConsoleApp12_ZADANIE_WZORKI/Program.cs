using System;

namespace ConsoleApp12_ZADANIE_WZORKI
{
    class Program
    {
        // ZADANIE WZORKI
        /*
         * DANE WEJSCIOWE
         * B 15
         * LUB
         * A 12 9
         */

        const char gwiazdka = '*';
        const char kropka = '.';
        const char spacja = ' ';
        static void Gwiazdka() => Console.Write(gwiazdka);
        static void GwiazdkaNL() => Console.WriteLine(gwiazdka);
        static void Kropka() => Console.Write(kropka);
        static void KropkaNL() => Console.WriteLine(kropka);
        static void NowaLinia() => Console.WriteLine();

        public static void A(int n, int m)
        {
            if (n % 2 == 0)
                n += 1;
            if (m % 2 == 0)
                m += 1;

            // PIERWSZA LINIA
            for (int i = 0; i < n; i++)
                Gwiazdka();
            NowaLinia();

            // SRODEK GÓRNY
            for (int i = 1; i < m / 2; i++)
            {
                Gwiazdka();
                for (int j = 0; j < (n / 2) - 1; j++)
                    Kropka();
                Gwiazdka();
                for (int k = 0; k < (n / 2) - 1; k++)
                    Kropka();
                GwiazdkaNL();
            }

            // SRODKOWA LINIA
            for (int i = 0; i < n; i++)
                Gwiazdka();
            NowaLinia();

            // ŚRODEK DOLNY
            for (int i = 1; i < m / 2; i++)
            {
                Gwiazdka();
                for (int j = 0; j < (n / 2) - 1; j++)
                    Kropka();
                Gwiazdka();
                for (int k = 0; k < (n / 2) - 1; k++)
                    Kropka();
                GwiazdkaNL();
            }

            // OSTATNIA LINIA
            for (int i = 0; i < n; i++)
                Gwiazdka();
            NowaLinia();
        }
        public static void B(int n)
        {
            // PIERWSZA LINIA
            for (int i = 0; i < n; i++)
                Gwiazdka();
            NowaLinia();

            // ŚRODEK
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 0; j < i; j++)
                    Kropka();
                Gwiazdka();
                for (int k = n - i; k > 1; k--)
                    Kropka();
                NowaLinia();
            }

            // OSTATNIA LINIA
            for (int i = 0; i < n; i++)
                Gwiazdka();
            NowaLinia();
        }
        static void Main(string[] args)
        {
            string linia = Console.ReadLine();
            string[] tabLinia = linia.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (tabLinia[0] == "A" || tabLinia[0] == "a")
            {
                if (int.Parse(tabLinia[1]) >= 3 && int.Parse(tabLinia[1]) <= 100)
                {
                    if (int.Parse(tabLinia[2]) >= 3 && int.Parse(tabLinia[2]) <= 100)
                        A(int.Parse(tabLinia[1]), int.Parse(tabLinia[2]));
                    else throw new ArgumentException("Złe dane");
                }
                else throw new ArgumentException("Złe dane");

            }
            else if (tabLinia[0] == "B" || tabLinia[0] == "b")
            {
                B(int.Parse(tabLinia[1]));
            }
            else
            {
                throw new ArgumentException("Wprowadzono złe dane");
            }
        }
    }
}