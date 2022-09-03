using System;

namespace ConsoleApp13_characterPatterns4
{
    class Program
    {
        // Character Patterns 4
        // DANE WEJSCIOWE:
        // 3
        // 3 1 2 1
        // 4 4 1 2
        // 2 5 2 2

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string linia = Console.ReadLine();
                string[] ciagLiczb = linia.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int l = int.Parse(ciagLiczb[0]); // Wiersz
                int c = int.Parse(ciagLiczb[1]); // Kolumna
                int h = int.Parse(ciagLiczb[2]); // Wysokość
                int w = int.Parse(ciagLiczb[3]); // Szerokość

                int y, x, n, m;

                for (y = 0; y < l; y++)
                {
                    for (x = 0; x < c; x++)
                    {
                        Console.Write("*");

                        for (n = 0; n < w; n++)
                            Console.Write("*");

                        if (x == c - 1)
                            Console.WriteLine("*");
                    }
                    for (m = 0; m < h; m++)
                    {
                        for (x = 0; x < c; x++)
                        {
                            Console.Write("*");

                            for (n = 0; n < w; n++)
                                Console.Write(".");

                            if (x == c - 1)
                                Console.WriteLine("*");
                        }
                    }
                    if (y == l - 1)
                    {
                        for (x = 0; x < c; x++)
                        {
                            Console.Write("*");

                            for (n = 0; n < w; n++)
                                Console.Write("*");

                            if (x == c - 1)
                                Console.WriteLine("*");
                        }
                    }
                }
            }
        }
    }
}
