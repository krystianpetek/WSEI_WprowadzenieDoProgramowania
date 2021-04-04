using System;

namespace ConsoleApp11_labWzorki8
{
    class Program
    {
        // labWzorki8
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarNl() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceNl() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();
        public static void trojkatPusty2(int n)
        {
            if (n % 2 == 0)
                n = n - 1;

            // PIERWSZA LINIA
            for (int i = 0; i < n; i++)
                Star();
            NewLine();


            // ŚRODEK
            for (int i = 1; i < n / 2; i++)
            {
                for (int j = 0; j < i; j++)
                    Space();
                Star();
                for (int k = 0; k < n - 2 - 2 * i; k++)
                    Space();
                StarNl();
            }

            //OSTATNIA LINIA
            for (int i = 0; i < n / 2; i++)
                Space();
            Star();
        }
        static void Main(string[] args)
        {
            trojkatPusty2(8);
        }
    }
}