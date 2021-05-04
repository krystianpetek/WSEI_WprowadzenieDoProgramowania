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
//5 14
//##############
//#----###-*-#-#
//###***##*#-*-#
//#***-#########
//##############

namespace ConsoleApp4_hotelFloors
{
    class Program
    {
        static void Main()
        {
            int ilosc = int.Parse(Console.ReadLine());
            for (int i = 0; i < ilosc; i++)
            {
                // WEJSCIE DANYCH
                string[] linia = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int M = Convert.ToInt32(linia[0]);
                int N = Convert.ToInt32(linia[1]);

                // PRZYPISANIE WARTOŚCI DO TABLICY
                char[,] rzutGora = new char[M, N];
                for (int x = 0; x < rzutGora.GetLength(0); x++)
                {
                    string wejscie = Console.ReadLine();
                    for (int y = 0; y < rzutGora.GetLength(1); y++)
                    {
                        if (wejscie[y] != '#' && wejscie[y] != '-' && wejscie[y] != '*')
                            throw new ArgumentException("Błędne dane");

                        rzutGora[x, y] = wejscie[y];
                    }
                }

                // LICZENIE OSOB
                int liczbaOsob = 0;
                for (int aa = 1; aa < rzutGora.GetLength(0) - 1; aa++)
                    for (int bb = 1; bb < rzutGora.GetLength(1) - 1; bb++)
                        if (rzutGora[aa, bb] == '*')
                            liczbaOsob++;

                // LICZENIE POMIESZCZEŃ
                int pomieszczenie = 0;
                Stack stosPrzebiegu = new Stack();

                for (int a = 1; a < rzutGora.GetLength(0) - 1; a++)
                {
                    for (int b = 1; b < rzutGora.GetLength(1) - 1; b++)
                    {
                        if (rzutGora[a, b] == '.' || rzutGora[a, b] == '#')
                            continue;
                        else
                        {
                            while (true)
                            {
                                var gora = rzutGora[a - 1, b];
                                var prawo = rzutGora[a, b + 1];
                                var dol = rzutGora[a + 1, b];
                                var lewo = rzutGora[a, b - 1];

                                //Console.WriteLine($"{a},{b}, {rzutGora[a, b]} COUNT{myStack.Count} {gora},{prawo},{dol},{lewo}");
                                rzutGora[a, b] = '.';

                                if (gora == '#' | gora == '.' && prawo == '#' | prawo == '.' && dol == '#' | dol == '.' && lewo == '#' | lewo == '.')
                                {
                                    if (stosPrzebiegu.Count > 0)
                                    {
                                        //Console.WriteLine($"{a},{b}, {rzutGora[a, b]} COUNT{myStack.Count} {gora},{prawo},{dol},{lewo}");
                                        b = Convert.ToInt32(stosPrzebiegu.Pop());
                                        a = Convert.ToInt32(stosPrzebiegu.Pop());
                                        continue;
                                    }
                                    else
                                    {
                                        pomieszczenie++;
                                        break;
                                    }

                                }
                                if (gora == '-' || gora == '*')
                                {
                                    stosPrzebiegu.Push(a);
                                    stosPrzebiegu.Push(b);
                                    a--;
                                    continue;
                                }

                                if (prawo == '-' || prawo == '*')
                                {
                                    stosPrzebiegu.Push(a);
                                    stosPrzebiegu.Push(b);
                                    b++;
                                    continue;
                                }

                                if (dol == '-' || dol == '*')
                                {
                                    stosPrzebiegu.Push(a);
                                    stosPrzebiegu.Push(b);
                                    a++;
                                    continue;
                                }

                                if (lewo == '-' || lewo == '*')
                                {
                                    stosPrzebiegu.Push(a);
                                    stosPrzebiegu.Push(b);
                                    b--;
                                    continue;
                                }
                            }
                        }
                    }
                }

                // OBLICZENIE WYNIKU
                double oblicz = (double)liczbaOsob / (double)pomieszczenie;
                Console.WriteLine($"{Math.Round(oblicz, 2):F2}");

                // WYSWIETL PRZELICZONE PIETRO
                //for (int iter = 0; iter < M; iter++)
                //    for (int iter2 = 0; iter2 < N; iter2++)
                //    {
                //        Console.Write(rzutGora[iter, iter2]);
                //        if (iter2 == N - 1)
                //            Console.WriteLine();
                //    }
            }
        }
    }
}