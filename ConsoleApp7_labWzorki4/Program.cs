using System;

namespace ConsoleApp7_labWzorki4
{
    class Program
    {
        // labWzorki4
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarNl() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceNl() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();
        public static void wyswietlZ(int n)
        {
            if (n < 3) throw new ArgumentException("Zbyt mały rozmiar");
        
            // PIERWSZA LINIA
            for(int i = 0; i < n;i++)
                Star();
            NewLine();

            // ŚRODEK
            for(int i = 1; i<n-1;i++)
            {
                for (int j = n-1; j > i; j--)
                    Space();
                StarNl();
            }
            // OSTATNIA LINIA
            for (int i = 0; i < n; i++)
                Star();
        }
        
        static void Main(string[] args)
        {
            wyswietlZ(8);
        }
    }
}
