using System;
using System.Text;
namespace sprawdzianZadanie4
{
    class Program
    {
        public static void Print(int[] a, int[] b)
        {
            StringBuilder wynik = new StringBuilder();
            for (int x = 0; x < a.Length; x++)
            {
                bool check = true;
                for (int y = 0; y < b.Length; y++)
                {
                    if (a[x] == b[y])
                        check = false;
                }
                if (check == true)
                    wynik.Append($"{a[x]} ");
                    
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
                    wynik.Append($"{b[x]} ");
                    
            }

            if (wynik.ToString() == "")
            {
                Console.WriteLine("empty");
                return;
            }
            string[] tab = wynik.ToString().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(tab);
            foreach(var x in tab)
                Console.Write($"{x} ");
        }
        static void Main()
        {
            //int[] a = new int[] { 0, 1, 1, 2, 3, 3, 3 };
            //int[] b = new int[] { 0, 1, 2, 3, 3 };
            int[] a = new int[] { -2, -1, 0, 1, 4 };
            int[] b = new int[] { -3, -2, -1, 1, 2, 3 };

            //int[] a = new int[] { -2, -1, 0, 1, 4 };
            //int[] b = new int[] { -2, -1, 0, 1, 4, 5, 6 };
            Print(a, b);
        }
    }

}
