using System;

namespace inneZadanie2
{
    class Program
    {
        static void Wzorki(int n)
        {

            for (int i = 0; i < n; i++)
                Console.Write("*");
            Console.WriteLine();
            for (int x = n; x > 1; x--)
            {
                for (int y = 2; y < x; y++)
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
