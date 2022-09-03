using System;
using System.Text;
namespace sprawdzianZadanie4
{
    class Program
    {
        public static void Print(int[] a, int[] b)
        {
            //StringBuilder wynik = new StringBuilder();
            string wynik = "";
            for (int x = 0; x < a.Length; x++)
            {
                bool check = true;
                for (int y = 0; y < b.Length; y++)
                {
                    if (a[x] == b[y])
                        check = false;
                }
                if (check == true)
                    // wynik.Append($"{a[x]} ");
                    wynik += $"{a[x]} ";
            }
            
            for (int x = 0; x < b.Length; x++)
            {
                bool check = true;
                for (int y = 0; y < a.Length; y++)
                {
                    if (b[x] == a[y])
                        check = false;
                }
                if (check == true)
                    //wynik.Append($"{b[x]} ");
                    wynik += $"{b[x]} ";
            }
            if (wynik.ToString() == "")
            {
                Console.Write("empty");
                return;
            }
            string[] tab = wynik.ToString().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[] tablica = new int[tab.Length];
            
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = int.Parse(tab[i]);
            }
            
            Array.Sort(tablica);

            int[] temp = new int[tablica.Length];
            int j = 0;
          
            #region duplikaty
            for (int i = 0; i < tablica.Length-1; i++)
            {
                if(tablica[i] != tablica[i+1])
                {
                    temp[j++] = tablica[i];
                }
            }
            temp[j++] = tablica[tablica.Length - 1];
            #endregion
            foreach (var x in temp)
                Console.Write($"{x} ");
        }
        static void Main()
        {
            int[] a = new int[] { -2, -1, 0, 1, 4 };
            int[] b = new int[] { -3, -2, -1, 1, 2, 3 };
            Print(a, b);

            Console.WriteLine();
            a = new int[] { -2, -1, 0, 1, 4 };
            b = new int[] { -2, -1, 0, 1, 4, 5, 6 };
            Print(a, b);

            Console.WriteLine();
            a = new int[] { 1 };
            b = new int[] { 1 };
            Print(a, b);

            Console.WriteLine();
            a = new int[] { 1 };
            b = new int[] { 2 };
            Print(a, b);

            Console.WriteLine();
            a = new int[] { 1 };
            b = new int[] { 1, 2 };
            Print(a, b);

            Console.WriteLine();
            a = new int[] { 1 };
            b = new int[] { 2, 3 };
            Print(a, b);
            
            Console.WriteLine();
            a = new int[] { 1,2 };
            b = new int[] { 1 };
            Print(a, b);

            Console.WriteLine();
            a = new int[] { 1,2 };
            b = new int[] { 3 };
            Print(a, b);

            Console.WriteLine();
            a = new int[] { 1,2,3 };
            b = new int[] { 1,2,3 };
            Print(a, b);

            Console.WriteLine();
            a = new int[] { 1, 2, 3 };
            b = new int[] { -3, -2, -1 };
            Print(a, b);

            Console.WriteLine();
            a = new int[] { 0, 1, 1, 2, 3, 3, 3 };
            b = new int[] { 0, 1, 2, 3, 3 };
            Print(a, b);

        }
    }

}
