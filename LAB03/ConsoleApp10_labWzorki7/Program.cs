using System;

namespace ConsoleApp10_labWzorki7
{
    class Program
    {
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarNl() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceNl() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();
        public static void trojkatPusty1(int n)
        {
            if (n % 2 == 0) n -= 1;

            // PIERWSZY PUNKT
            for (int i = n / 2; i > 0; i--)
                Space();
            StarNl();

            // ŚRODEK TROJKATA
            for (int i = 1; i < n / 2; i++)
            {
                for (int j = n / 2; j-1*i> 0; j--)
                    Space();
                Star();
                for (int k = 1; k < i+1*i; k++)
                    Space();
                StarNl();
            }

            // OSTATNIA LINIA
            for(int i = 0;i<n;i++)
            {
                Star();
            }
            NewLine();
        }
        static void Main(string[] args)
            {
                trojkatPusty1(14);
            }
        
    }
}