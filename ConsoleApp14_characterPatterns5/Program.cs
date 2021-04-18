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
                int l = int.Parse(ciagLiczb[0]); // Wiersz
                int c = int.Parse(ciagLiczb[1]); // Kolumna
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

                        for (int gwiazdkiLinia = 0; gwiazdkiLinia < c; gwiazdkiLinia++)
                        {
                            int liniaSzerokosc;
                            Console.Write("*");
                            for (liniaSzerokosc = 0; liniaSzerokosc < s; liniaSzerokosc++)
                            {

                                if (iloscWierszy % 2 == 0)
                                {
                                    if (liniaWysokosc % 2 == 0)
                                    {

                                        if (gwiazdkiLinia % 2 == 0)
                                        {

                                            if (liniaSzerokosc % 2 == 0)
                                                Console.Write(@"\");
                                            else
                                                Console.Write(".");
                                        }
                                        else
                                        {
                                            if (liniaSzerokosc % 2 == 0 && s > 1)
                                                Console.Write(".");
                                            else
                                                Console.Write(@"/");
                                        }
                                    }
                                    else
                                    {
                                        if (gwiazdkiLinia % 2 == 0)
                                        {

                                            if (liniaSzerokosc % 2 == 0 && s > 1)
                                                Console.Write(@".");
                                            else
                                                Console.Write(@"\");
                                        }
                                        else
                                        {
                                            if (liniaSzerokosc % 2 == 0)
                                                Console.Write(@"/");
                                            else
                                                Console.Write(".");
                                        }
                                    }
                                }
                                else
                                {
                                    if (liniaWysokosc % 2 == 0)
                                    {

                                        if (gwiazdkiLinia % 2 == 0)
                                        {

                                            if (liniaSzerokosc % 2 == 0 && s > 1)

                                                Console.Write(".");
                                            else
                                                Console.Write(@"/");
                                        }
                                        else
                                        {
                                            if (liniaSzerokosc % 2 == 0)
                                                Console.Write(@"\");
                                            else
                                                Console.Write(".");
                                        }
                                    }
                                    else
                                    {
                                        if (gwiazdkiLinia % 2 == 0)
                                        {

                                            if (liniaSzerokosc % 2 == 0)
                                                Console.Write(@"/");
                                            else
                                                Console.Write(@".");
                                        }
                                        else
                                        {
                                            if (liniaSzerokosc % 2 == 0 && s > 1)
                                                Console.Write(".");
                                            else
                                                Console.Write(@"\");
                                        }
                                    }
                                }

                            }

                            if (gwiazdkiLinia == c - 1)
                                Console.WriteLine("*");
                        }



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
































                /*int x, // c
                y, // l
                A = 0;

                int PRAWO;

                for (y = 0; y < l; y++)
                {
                    //PIERWSZA LINIA
                    for (x = 0; x < c; x++)
                    {
                        Console.Write("*");
                        for (PRAWO = 0; PRAWO < s; PRAWO++)
                            Console.Write("*");

                        if (x == c - 1)
                            Console.WriteLine("*");
                    }


                    for (int DOL = 0; DOL < s; DOL++)
                    {
                        for (x = 0; x < c; x++)
                        {
                            Console.Write("*");
                            for (PRAWO = 0; PRAWO < s; PRAWO++)
                            {
                                if (DOL % 2 == 1)
                                {
                                    if (x % 2 == 0)
                                    {
                                        if (PRAWO % 2 == 0)
                                            Console.Write(".");
                                        else
                                            Console.Write(@"\");
                                    }
                                    else
                                    {
                                        if (PRAWO % 2 == 0)
                                            Console.Write(@"/");
                                        else
                                            Console.Write(".");
                                    }
                                }
                                else
                                {
                                    if (x % 2 == 0)
                                    {
                                        if (PRAWO % 2 == 0)
                                            Console.Write(@"\");
                                        else
                                            Console.Write(".");
                                    }
                                    else
                                    {
                                        if (PRAWO % 2 == 0)
                                            Console.Write(".");
                                        else
                                            Console.Write(@"/");
                                    }
                                }
                            }
                            if (x == c - 1)
                                Console.WriteLine("*");

                        }
                    }

                    if(y == l-1)
                    {
                        for (x = 0; x < c; x++)
                        {
                            Console.Write("*");
                            for (PRAWO = 0; PRAWO < s; PRAWO++)
                                Console.Write("*");

                            if (x == c - 1)
                                Console.WriteLine("*");
                        }
                    }
                }
                */
            }
        }
    }
}

