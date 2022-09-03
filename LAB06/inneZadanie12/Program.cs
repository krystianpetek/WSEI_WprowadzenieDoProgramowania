using System;

namespace inneZadanie12
{
    class Program
    {
        public static void Wzorek(int n)
        {
            Console.Write(" ");
            for (int pierwsza = 0; pierwsza < n - 1; pierwsza++)
                Console.Write("*");
            Console.WriteLine();

            for (int srodkowa = (n - 3) / 2; srodkowa > 0; srodkowa--)
            {
                    Console.Write("*");

                Console.WriteLine();
            }
            Console.Write(" ");
            for (int pierwsza = 0; pierwsza < n - 1; pierwsza++)
                Console.Write("*");
            Console.WriteLine();

            for (int srodkowa = (n - 3) / 2; srodkowa > 0; srodkowa--)
            {
                    Console.Write("*");

                Console.WriteLine();
            }

            Console.Write(" ");
            for (int pierwsza = 0; pierwsza < n - 1; pierwsza++)
                Console.Write("*");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 5)
                throw new ArgumentException("Błędne dane n musi być większe od 5");
            Wzorek(n);
        }
    }
}
