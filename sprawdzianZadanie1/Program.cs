using System;

namespace sprawdzianZadanie1
{
    class Program
    {
        public static void Wzorek(int n)
        {
            if (n % 2 == 0)
                n -= 1;
            for (int i = 0; i < n; i += 2)
            {

                for (int x = i; x > 0; x--)
                {
                    Console.Write(" ");
                }

                for (int y = n; y > i; y--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 3)
                throw new ArgumentException("Błędne dane");
            Wzorek(n);
        }
    }
}
