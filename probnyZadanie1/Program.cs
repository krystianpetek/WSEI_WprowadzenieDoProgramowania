using System;

namespace probnyZadanie1
{
    class Program
    {
        public static void Wzorek(int n)
        {

            int wejscie = n / 2;
            if (n % 2 == 0)
                wejscie -= 1;

            for (int i = 0; i < wejscie + 1; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(" ");

                for (int x = wejscie + 1; x > i; x--)
                    Console.Write("*");

                for (int c = wejscie; c > i; c--)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Wzorek(n);
        }
    }
}
