using System;

namespace ConsoleApp4_funWithSequences4
{
    class Program
    {
        static void Main(string[] args)
        {
            string pierwszaLinia = Console.ReadLine();
            string drugaLinia = Console.ReadLine();
            string trzeciaLinia = Console.ReadLine();
            string[] tabPierwsza = pierwszaLinia.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] S = drugaLinia.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] Q = trzeciaLinia.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(tabPierwsza[0]);
            int x = int.Parse(tabPierwsza[1]);
            if (x > n)
            {
                throw new ArgumentException("X nie może być większe od N");
            }
            int odwrotnyX = x - (x * 2);
            string wynik = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = i + odwrotnyX; j <= i + x; j++)
                {
                    if (j > Q.Length - 1)
                        continue;
                    if (j < 0)
                        j++;
                    else
                    {
                        if (S[i] == Q[j])
                            wynik += $"{i + 1 } ";
                    }
                }
            }
            Console.WriteLine(wynik);

        }
    }
}
