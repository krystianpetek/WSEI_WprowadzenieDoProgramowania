using System;

namespace ConsoleApp14_characterPatterns5
{
    class Program
    {
        // Character Patterns 5
        // DANE WEJSCIOWE:
        // 3
        // 3 1 2
        // 4 4 1
        // 2 5 2

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string linia = Console.ReadLine();
                string[] ciagLiczb = linia.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int l = int.Parse(ciagLiczb[0]); // WIERSZ
                int c = int.Parse(ciagLiczb[1]); // KOLUMNA
                int s = int.Parse(ciagLiczb[2]); // KWADRAT

                for (int iloscWierszy = 0; iloscWierszy < l; iloscWierszy++)
                {
                    int gwiazdkiPierwsze;
                    for (int pierwszaLinia = 0; pierwszaLinia < c; pierwszaLinia++)
                    {

                        Console.Write("*");
                        for (gwiazdkiPierwsze = 0; gwiazdkiPierwsze < s; gwiazdkiPierwsze++)
                            Console.Write("*");

                        if (pierwszaLinia == c - 1)
                            Console.WriteLine("*");
                    }

                    for (int liniaWysokosc = 0; liniaWysokosc < s; liniaWysokosc++)
                    {
                        for (int kolumna = 0; kolumna < c; kolumna++)
                        {
                            Console.Write("*");
                            if (iloscWierszy % 2 == 0)
                            {
                                if (kolumna % 2 == 1)
                                {
                                    for (int x = s; x > 0; x--)
                                    {
                                        if (liniaWysokosc == x - 1)
                                            Console.Write(@"/");
                                        else
                                            Console.Write(".");
                                    }
                                }
                                else
                                {
                                    for (int x = 0; x < s; x++)
                                    {
                                        if (liniaWysokosc == x)
                                            Console.Write(@"\");
                                        else
                                            Console.Write(".");
                                    }
                                }
                            }
                            else
                            {
                                if (kolumna % 2 == 0)
                                {

                                    for (int x = s; x > 0; x--)
                                    {
                                        if (liniaWysokosc == x - 1)
                                            Console.Write(@"/");
                                        else
                                            Console.Write(".");
                                    }
                                }
                                else
                                {
                                    for (int x = 0; x < s; x++)
                                    {
                                        if (liniaWysokosc == x)
                                            Console.Write(@"\");
                                        else
                                            Console.Write(".");
                                    }
                                }
                            }
                        }
                        Console.WriteLine("*");
                    }

                    if (iloscWierszy == l - 1)
                    {
                        int gwiazdkiOstatnie;
                        for (int ostatniaLinia = 0; ostatniaLinia < c; ostatniaLinia++)
                        {
                            Console.Write("*");
                            for (gwiazdkiOstatnie = 0; gwiazdkiOstatnie < s; gwiazdkiOstatnie++)
                                Console.Write("*");

                            if (ostatniaLinia == c - 1)
                                Console.WriteLine("*");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

