using System;

namespace ConsoleApp3_funWithSequences3
{
    class Program
    {
        // Fun With Sequences Act3

        /* DANE WEJSCIOWE
         * 5
         * -2 -2 -1 1 4
         * 6
         * -3 -2 -1 1 2 3
         */

        static void Main(string[] args)
        {
            int iloscLiczbS = int.Parse(Console.ReadLine());
            string ciagLiczbS = Console.ReadLine();
            string[] S = ciagLiczbS.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (iloscLiczbS < 2 || iloscLiczbS > 100)
                throw new ArgumentException("Ilość liczb S musi być większa lub równa 2 i mniejsza od 100");

            //Wyczytaj Q
            int iloscLiczbQ = int.Parse(Console.ReadLine());
            string ciagLiczbQ = Console.ReadLine();
            string[] Q = ciagLiczbQ.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (iloscLiczbQ < 2 || iloscLiczbQ > 100)
                throw new ArgumentException("Ilość liczb Q musi być większa lub równa 2 i mniejsza od 100");
            
            int x = S.Length, y = Q.Length, dlugoscTablic = 0;

            if (x > y)
                dlugoscTablic = y-1;
            else
                dlugoscTablic = x-1;

            for (int i = 0; i < dlugoscTablic; i++)
            {
                if (S[i] == Q[i])
                    Console.Write($"{i+1} ");
            }
        }
    }
}
