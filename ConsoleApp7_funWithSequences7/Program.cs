using System;

namespace ConsoleApp7_funWithSequences7
{
    class Program
    {
        // Fun With Sequences Act7

        /* 5
         * -2 -1 0 1 4
         * 6
         * -3 -2 -1 1 2 3
         */

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();
            string[] tablicaS = S.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (tablicaS.Length != n)
                throw new ArgumentException("Error");

            int m = int.Parse(Console.ReadLine());
            string Q = Console.ReadLine();
            string[] tablicaQ = Q.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (tablicaQ.Length != m)
                throw new ArgumentException("Error");

            int sumaS = 0;
            for (int x = 0; x < n; x++)
                sumaS += int.Parse(tablicaS[x]);

            int sumaQ = 0;
            for (int y = 0; y < m; y++)
                sumaQ += int.Parse(tablicaQ[y]);

            double dzielenieS = (double)sumaS / (double)n;
            double dzielenieQ = (double)sumaQ / (double)m;

            if (dzielenieS > dzielenieQ)
                Console.WriteLine(S);
            else
                Console.WriteLine(Q);
        }
    }
}
