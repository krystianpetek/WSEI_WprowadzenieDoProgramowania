using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            if (T > 50 || T < 1) return;
            for (int i = 0; i < T; i++)
            {

                int licznik = 0;
                var linia = Console.ReadLine();
                var tab = linia.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                long n = long.Parse(tab[0]);
                if (n < 1 || n > 100000) return;
                long S = long.Parse(tab[1]);
                if (S < 1 || S > 10000000000) return;
                var linia2 = Console.ReadLine();
                var liczbytab = linia2.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (string sprawdz in liczbytab)
                {
                    if (int.Parse(sprawdz) > 1000000000 || int.Parse(sprawdz) < 1)
                    {
                        return;
                    }
                }
                for (int j = 0; j < n; j++)
                {
                    for (int k = j + 1; k != liczbytab.Length; k++)
                    {
                        if (long.Parse(liczbytab[j]) + long.Parse(liczbytab[k]) == S)
                        {
                            licznik++;
                        }
                    }
                }
                Console.WriteLine($"Case {i + 1}: {licznik}");
            }
        }
    }
}
