using System;

namespace ConsoleApp5_funWithSequences5
{
    class Program
    {
        // Fun With Sequences Act5

        /* DANE WEJSCIOWE:
         * 6
         * 3 1 -2 -2 -1 3
         */

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 2 || n > 100)
            {
                throw new ArgumentException("Liczba z poza zakresu 2-100");
            }
            string S = Console.ReadLine();
            string[] tablicaS = S.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (tablicaS.Length != n)
                throw new ArgumentException("Ilosc liczb w zbiorze rózna od deklaracji ilosci liczb");

            int dlugoscS = n-1;
            int x = 0;


            for (; x < tablicaS.Length; x++)
                if (Convert.ToInt32(tablicaS[x]) > Convert.ToInt32(tablicaS[x + 1]))
                    dlugoscS--;
                else {
                    x++;
                    break;
                }
            for (int y = x; y < tablicaS.Length-1; y++) 
            {
                if (Convert.ToInt32(tablicaS[y]) < Convert.ToInt32(tablicaS[y + 1]))
                    dlugoscS--;
                else
                    break;
            }
            if(dlugoscS==1)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}


