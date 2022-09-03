using System;

namespace inneZadanie16
{
    class Program
    {
        public static void Wzorek(int n)
        {
            if (n % 2 == 0)
                n = n - 1;
            int srodek = n / 2;
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(j>=srodek-i && j <= srodek+i)
                        Console.Write("*");
                        else
                                Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Wzorek(8);
        }
    }
}
