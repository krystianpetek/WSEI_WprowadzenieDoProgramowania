using System;

namespace ConsoleApp15_characterPatterns6
{
    class Program
    {
        // Character Patterns 6
        // DANE WEJSCIOWE:
        // 3
        // 3 1 2 1
        // 4 4 1 2
        // 2 5 3 2

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string liniaWejscia = Console.ReadLine();
                string[] odczyt = liniaWejscia.Split(' ');
                int l = int.Parse(odczyt[0]); // Wiersz
                int c = int.Parse(odczyt[1]); // Kolumna
                int h = int.Parse(odczyt[2]); // Wysokość
                int w = int.Parse(odczyt[3]); // Szerokość

                for (int wiersz = 0; wiersz < l; wiersz++)
                {
                    for (int wysokosc = 0; wysokosc < h; wysokosc++)
                    {

                        #region liniaPozioma
                        for (int kolumna = 0; kolumna < c; kolumna++)
                        {
                            for (int szerokosc = 0; szerokosc < w; szerokosc++)
                                Console.Write(".");
                            Console.Write("|");
                        }
                        for (int szerokosc = 0; szerokosc < w; szerokosc++)
                            Console.Write(".");
                        Console.WriteLine();

                        if (wysokosc == h - 1)
                        {
                            for (int kolumna = 0; kolumna < c; kolumna++)
                            {
                                for (int szerokosc = 0; szerokosc < w; szerokosc++)
                                    Console.Write("-");
                                Console.Write("+");
                            }
                            for (int szerokosc = 0; szerokosc < w; szerokosc++)
                                Console.Write("-");
                            Console.WriteLine();
                        }
                        #endregion
                    }
                    if (wiersz == l - 1)
                    {
                        for (int wysokosc = 0; wysokosc < h; wysokosc++)
                        {
                            for (int kolumna = 0; kolumna < c; kolumna++)
                            {
                                for (int szerokosc = 0; szerokosc < w; szerokosc++)
                                    Console.Write(".");
                                Console.Write("|");
                            }
                            for (int szerokosc = 0; szerokosc < w; szerokosc++)
                                Console.Write(".");
                            Console.WriteLine();
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
