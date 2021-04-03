using System;

namespace ConsoleApp4_labWzorki1
{
    class Program
    {
        // labWzorki1
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(' ');
        static void SpaceLn() => Console.WriteLine(' ');
        static void NewLine() => Console.WriteLine();

        public static void Prostokat(int n, int m)
        {
            // PIERWSZA LINIA
            for (int i = 0; i < n; i++)
                Star();
            NewLine();

            // ŚRODEK
            for(int j = 1; j<m-1;j++)
            {
                Star();
                for(int i = 1; i< n-1;i++)
                    Space();
                StarLn();
            }

            // OSTATNIA LINIA
            for (int i = 0; i < n; i++)
                Star();
            NewLine();
        }
        public static void Main(string[] args)
        {
            Prostokat(10,6);
        }
    }
}
