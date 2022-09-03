using System;

namespace inneZadanie19
{
    class Program
    {
        static void Wzorki(int n)
        {
            if (n < 3)
            {
                Console.WriteLine("Błąd");
                return;
            }

            for (int i = 1; i < n; i++)
            {
                Console.Write("*");
            }

            for (int x = 0; x < n; x++)
            {
                for (int y = x; y > 0; y--)
                    Console.Write(" ");
                Console.WriteLine("*");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Wzorki(n);
        }
    }
}
