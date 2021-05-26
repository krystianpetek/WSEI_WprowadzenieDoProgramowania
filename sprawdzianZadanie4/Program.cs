using System;

namespace sprawdzianZadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void Print(int[] a, int[] b)
        {
            int i = 0;
            int j = 0;
            string wynik = "";
            for (; i < a.Length; i++)
            {
                for (; j < b.Length; j++)
                {

                }
            }
            Console.WriteLine(wynik);
        }
        static void Main()
        {
            int[] a = new int[] { 0, 1, 1, 2, 3, 3, 3 };
            int[] b = new int[] { 0, 1, 2, 3, 3 };
            //int[] a = new int[] { -2, -1, 0, 1, 4 };
            //int[] b = new int[] { -3, -2, -1, 1, 2, 3 };

            //int[] a = new int[] { -2, -1, 0, 1, 4 };
            //int[] b = new int[] { -2, -1, 0, 1, 4, 5, 6 };
            Print(a, b);
        }

    }

}
