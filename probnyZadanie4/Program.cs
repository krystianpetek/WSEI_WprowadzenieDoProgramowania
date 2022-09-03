using System;

namespace probnyZadanie4
{
    class Program
    {
        public static double Srednia(int[,] tab)
        {
            double suma = 0.0;
            int licznik = 0;
            for (int x = 0; x < tab.GetLength(0); x++)
            {
                for (int y = 0; y < tab.GetLength(1); y++)
                {
                    if (tab[x, y] > 0)
                    {
                        suma += tab[x, y];
                        licznik++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            suma = Math.Round(suma / licznik, 2);
            if (double.IsNaN(suma))
                return 0.00;
            return suma;
        }
        static void Main(string[] args)
        {
            int[,] tablicaLiczb = { { 1, 1, 1, 1, 1, 1 }, { 2, 2, 2, 2, 2, 2 }, { 3, 3, 3, 3, 3, 3, } };
            //int[,] tablicaLiczb = { { 1, 1 }, { 2, -1 } };
            //int[,] tablicaLiczb = { { -1 } };
            //int[,] tablicaLiczb = { };
            Console.WriteLine($"{Srednia(tablicaLiczb):F2}");

        }
    }
}
