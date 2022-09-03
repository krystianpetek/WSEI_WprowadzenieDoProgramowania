using System;
using System.Collections;

//4
//5 5
//#####
//#**##
//###*#
//#**##
//#####
//6 10
//##########
//#---*--*##
//###-*----#
//#**#######
//##***---##
//##########
//5 14
//##############
//#----#-#-*-#-#
//###***-#*#**-#
//#***-#########
//##############
//13 19
//###################
//#--------*--------#
//#-#-###-#-#-###-#-#
//#-#-#---#-#---#-#*#
//#-#-###-#-#-###-#-#
//###################
//#-#-#-###-###-#-#-#
//#-----------------#
//#-#-###-#-#-###-#-#
//#-#-#---#-#-**#-#-#
//#-#-###-#-#-###-#-#
//#-----------*-----#
//###################

namespace ConsoleApp4_hotelFloors
{
    class Program
    {
        static void Main()
        {
            int M, N, x = 0, y = 0;
            int ileLiczb = int.Parse(Console.ReadLine());
            for (int i = 0; i < ileLiczb; i++)
            {
                // WEJSCIE DANYCH
                string[] linia = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                M = Convert.ToInt32(linia[0]);
                N = Convert.ToInt32(linia[1]);

                // PRZYPISANIE WARTOŚCI DO TABLICY
                char[,] rzutPietra = new char[M, N];
                for (x = 0; x < rzutPietra.GetLength(0); x++)
                {
                    string liniaRzutu = Console.ReadLine();
                    for (y = 0; y < rzutPietra.GetLength(1); y++)
                    {
                        if (liniaRzutu[y] != '#' && liniaRzutu[y] != '-' && liniaRzutu[y] != '*')
                            throw new ArgumentException("Błędne dane");
                        rzutPietra[x, y] = liniaRzutu[y];
                    }
                }

                // LICZENIE OSOB
                int liczbaOsob = 0;
                for (x = 1; x < rzutPietra.GetLength(0) - 1; x++)
                    for (y = 1; y < rzutPietra.GetLength(1) - 1; y++)
                        if (rzutPietra[x, y] == '*')
                            liczbaOsob++;

                // LICZENIE POMIESZCZEŃ
                int iloscPomieszczen = 0;
                Stack stosPrzebiegu = new Stack();

                for (x = 1; x < rzutPietra.GetLength(0) - 1; x++)
                {
                    for (y = 1; y < rzutPietra.GetLength(1) - 1; y++)
                    {
                        if (rzutPietra[x, y] == '.' || rzutPietra[x, y] == '#')
                            continue;
                        else
                        {
                            while (true)
                            {
                                var gora = rzutPietra[x - 1, y];
                                var prawo = rzutPietra[x, y + 1];
                                char dol = rzutPietra[x + 1, y];
                                char lewo = rzutPietra[x, y - 1];

                                //Console.WriteLine($"x:{x} y:{y} znak:{rzutPietra[x, y]} stos:{stosPrzebiegu.Count} {gora},{prawo},{dol},{lewo}");
                                rzutPietra[x, y] = '.';

                                if (gora == '#' | gora == '.' && prawo == '#' | prawo == '.' && dol == '#' | dol == '.' && lewo == '#' | lewo == '.')
                                {
                                    if (stosPrzebiegu.Count > 0)
                                    {
                                        //Console.WriteLine($"x:{x} y:{y} znak:{rzutPietra[x, y]} stos:{stosPrzebiegu.Count} {gora},{prawo},{dol},{lewo}");
                                        y = Convert.ToInt32(stosPrzebiegu.Pop());
                                        x = Convert.ToInt32(stosPrzebiegu.Pop());
                                        continue;
                                    }
                                    else
                                    {
                                        iloscPomieszczen++;
                                        break;
                                    }

                                }
                                if (gora == '-' || gora == '*')
                                {
                                    stosPrzebiegu.Push(x);
                                    stosPrzebiegu.Push(y);
                                    x--;
                                    continue;
                                }

                                if (prawo == '-' || prawo == '*')
                                {
                                    stosPrzebiegu.Push(x);
                                    stosPrzebiegu.Push(y);
                                    y++;
                                    continue;
                                }

                                if (dol == '-' || dol == '*')
                                {
                                    stosPrzebiegu.Push(x);
                                    stosPrzebiegu.Push(y);
                                    x++;
                                    continue;
                                }

                                if (lewo == '-' || lewo == '*')
                                {
                                    stosPrzebiegu.Push(x);
                                    stosPrzebiegu.Push(y);
                                    y--;
                                    continue;
                                }
                            }
                        }
                    }
                }

                // OBLICZENIE WYNIKU
                double oblicz = (double)liczbaOsob / (double)iloscPomieszczen;
                Console.WriteLine($"{Math.Round(oblicz, 2):F2}");

                ////WYSWIETL PRZELICZONE PIETRO
                //Console.WriteLine();
                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine("RZUT PIĘTRA");
                //Console.ForegroundColor = ConsoleColor.White;

                //for (x = 0; x < M; x++)
                //    for (y = 0; y < N; y++)
                //    {
                //        if (rzutPietra[x, y] == '.')
                //        {
                //            Console.ForegroundColor = ConsoleColor.Red;
                //            rzutPietra[x, y] = '#';
                //        }
                //        else
                //            Console.ForegroundColor = ConsoleColor.White;
                //        Console.Write(rzutPietra[x, y]);
                //        if (y == N - 1)
                //            Console.WriteLine();
                //    }
            }
        }
    }
}