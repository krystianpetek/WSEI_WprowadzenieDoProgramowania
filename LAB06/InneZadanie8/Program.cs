using System;

namespace inneZadanie8
{
    class Program
    {
        public static void Wzorek(int n)
        {
            if (n % 2 == 0)
                n -= 1;

            for (int a = 0; a < n; a += 2)
            {
                for (int b = a; b < n-1; b++)
                    Console.Write(" ");
                for (int c = 0; c < a+1; c++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 3)
                throw new ArgumentException("Błędne dane");
            Wzorek(n);
        }
    }
}
