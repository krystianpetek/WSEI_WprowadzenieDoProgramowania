using System;

namespace ConsoleApp3_tablicaPostrzepiona
{
    class Program
    {
        static char[][] ReadJaggedArrayFromStdInput()
        {
            int linia = int.Parse(Console.ReadLine());
            char[][] tab = new char[linia][];
            for (int i = 0; i < linia; i++)
            {
                tab[i] = Console.ReadLine().ToCharArray();
            }

            return tab;
        }

        static void PrintJaggedArrayToStdOutput(char[][] tab)
        {
            for (int x = 0; x < tab.Length; x++)
            {
                for (int y = 0; y < tab[x].Length; y++)
                {
                    Console.Write(tab[x][y]);
                }
                Console.WriteLine();
            }
        }

        static char[][] TransposeJaggedArray(char[][] tab)
        {
            // Utworzenie nowej tablicy bez SPACJI
            char[][] nowaTablica = new char[tab.GetLength(0)][];
            for (int n = 0; n < tab.Length; n++)
            {
                string slowo = "";
                for (int i = 0; i < tab[n].Length; i++)
                {
                    if (tab[n][i] == ' ')
                        continue;
                    else
                        slowo += tab[n][i];
                }
                nowaTablica[n] = slowo.ToCharArray();
            }

            // Ustalenie najdłuższej transponowanej tablicy
            int najdluzsza = 0;
            for (int i = 0; i < nowaTablica.Length; i++)
                if (nowaTablica[i].Length > najdluzsza)
                    najdluzsza += nowaTablica[i].Length;

            char[][] transpose = new char[najdluzsza][];
            for (int x = 0; x < najdluzsza; x++)
                transpose[x] = new char[nowaTablica.GetLength(0) * 2 - 1];
            for (int a = 0; a < najdluzsza; a++)
            {
                int iterator = 0;
                for (int b = 0; b < transpose[a].Length; b++)
                {
                    try
                    {
                        transpose[a][b] = nowaTablica[iterator][a];
                        if (b == transpose[a].Length - 1)
                        { }
                        else
                        {
                            b++;
                            transpose[a][b] = ' ';
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        transpose[a][b] = ' ';
                        if (b == transpose[a].Length - 1)
                        { }
                        else
                        {
                            b++;
                            transpose[a][b] = ' ';
                        }
                    }
                    iterator++;
                }
            }
            return transpose;
        }
        static void Main(string[] args)
        {
            char[][] jagged = ReadJaggedArrayFromStdInput();
            PrintJaggedArrayToStdOutput(jagged);
            jagged = TransposeJaggedArray(jagged);
            Console.WriteLine();
            PrintJaggedArrayToStdOutput(jagged);
        }
    }
}
