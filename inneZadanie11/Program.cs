using System;

namespace inneZadanie11
{
    class Program
    {
        public static double Srednia(int[][] tab)
        {
            double suma = 0.0;
            int licznik = 0;
            for (int glowna = 0; glowna < tab.Length; glowna++)
            {
                for (int x = 0; x < tab[glowna].Length; x++)
                {
                    if (tab[glowna][x] < 0)
                        continue;
                    suma += tab[glowna][x];
                    licznik++;
                }
            }

            suma = Math.Round(suma / licznik, 2);
            if (double.IsNaN(suma))
                return 0.00;
            return suma;
        }
        static void Main(string[] args)
        {
            int[][] tablicaLiczb = new int[3][];
            tablicaLiczb[0] = new int[] { 1, 1, 1, 1 };
            tablicaLiczb[1] = new int[] { 2, 2 };
            tablicaLiczb[2] = new int[] { 3, 3, 3, 3, 3, 3 };

            //int[][] tablicaLiczb = new int[1][];
            //tablicaLiczb[0] = new int[] { 1,2,3 };

            //int[][] tablicaLiczb = new int[3][];
            //tablicaLiczb[0] = new int[] { -1 };
            //tablicaLiczb[1] = new int[] { 1 };
            //tablicaLiczb[2] = new int[] { 1 };

            //int[][] tablicaLiczb = new int[2][];
            //tablicaLiczb[0] = new int[] { 1,1 };
            //tablicaLiczb[1] = new int[] { 2,-1};

            //int[][] tablicaLiczb = new int[2][];
            //tablicaLiczb[0] = new int[] { -1, -2 };
            //tablicaLiczb[1] = new int[] { -3, -4 };

            //int[][] tablicaLiczb = new int[2][];
            //tablicaLiczb[0] = new int[] { };
            //tablicaLiczb[1] = new int[] { };

            Console.WriteLine($"{Srednia(tablicaLiczb):F2}");
        }
    }
}
