using System;
using System.Text;
namespace inneZadanie7
{
    class Program
    {
        public static void Print(int[] a, int[] b)
        {
            string wynik = "";
            for (int x = 0; x < a.Length; x++)
            {
                bool check = false;
                for (int y = 0; y < b.Length; y++)
                {
                    if (a[x] == b[y])
                        check = true;
                }
                if (check == true)
                {
                    if(!wynik.Contains($"{a[x]}"))
                    wynik += $"{a[x]} ";
                }
            }

            if (wynik.ToString() == "")
            {
                Console.WriteLine("empty");
                return;
            }

            //string koniec = "";
            //for (int x = 0; x < wynik.Length; x++)
            //{
            //    if (koniec.Contains(wynik[x]))
            //        continue;
            //    else
            //    {
            //        koniec += $"{wynik[x]} ";
            //    }

            //}



            Console.WriteLine(wynik);

        }
        static void Main()
        {
            //int[] a = new int[] { 0, 1, 1, 2, 3, 3, 3 };
            //int[] b = new int[] { 0, 1, 2, 3, 3 };

            //int[] a = new int[] { -2, -1, 0, 1, 4 };
            //int[] b = new int[] { -3, -2, -1, 1, 2, 3 };

            //int[] a = new int[] { -2, -1, 0, 1, 4 };
            //int[] b = new int[] { -2, -1, 0, 1, 4, 5, 6 };
            Print(a, b);
        }
    }
}
