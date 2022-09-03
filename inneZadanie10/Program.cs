using System;

namespace inneZadanie10
{
    class Program
    {
        static void Print(int[] a, int[] b)
        {
            string wynik = "";
            bool sprawdz = true;
            for(int i = 0;i<a.Length;i++)
            {
                sprawdz = true;
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                        sprawdz = false;
                }
                if (sprawdz)
                    wynik += $"{a[i]} ";
            }

            if (wynik.ToString() == "")
            {
                Console.WriteLine("empty");
                return;
            }

            string[] tab = wynik.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(tab);

            string[] temp = new string[tab.Length];
            int x = 0;
            for (int i = 0; i < tab.Length-1; i++)
            {
                if (tab[i] != tab[i + 1])
                    temp[x++] = tab[i];
            }
            temp[x++] = tab[tab.Length - 1];

            foreach(var X in temp)
                Console.Write($"{X} ");
        }
        static void Main()
        {
            //int[] a = new int[] { 0, 1, 1, 2, 3, 3, 3 };
            //int[] b = new int[] { 0, 1, 2, 3, 3 };

            //int[] a = new int[] { -2, -1, 0, 1, 4 };
            //int[] b = new int[] { -3, -2, -1, 1, 2, 3 };

            int[] a = new int[] { -2, -1, 0, 1, 4 };
            int[] b = new int[] { -2, -1, 0, 1, 4, 5, 6 };
            Print(a, b);
        }
    }
}
