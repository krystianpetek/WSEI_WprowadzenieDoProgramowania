using System;

namespace ConsoleApp8_labWzorki5
{
    class Program
    {
        // labWzorki5
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarNl() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceNl() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();
        public static void klepsydra(int n)
        {
            if (n < 5)
                throw new ArgumentException("Zbyt mały rozmiar");

            // PIERWSZA LINIA
            for (int i = 0; i < n; i++)
                Star();
            NewLine();

            // GÓRA KLEPSYDRY
            for (int i = 1; i < n / 2; i++)
            {
                for (int j = 0; i > j; j++)
                    Space();
                Star();
                for (int k = 0; k < n - 2 - 2 * i; k++)
                    Space();
                StarNl();
            }

            // PUNKT STYCZNOSCI
            if(n % 2 == 1)
            {
                for (int i = 0; i < n / 2; i++)
                    Space();
                StarNl();
            }

            //DÓŁ KLEPSYDRY
            for (int x = n / 2; x > 1; x--)
            {
                for (int i = x - 1; i > 0; i--)
                    Space();
                Star();
                for (int j = 0; j < n - 2 * x; j++)
                    Space();
                StarNl();
            }

            // OSTATNIA LINIA
            for (int i = 0; i < n; i++)
                Star();
            NewLine();
        }
        static void Main(string[] args)
        {
            klepsydra(7);
        }
    }
}
