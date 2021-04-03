using System;

namespace ConsoleApp5_labWzorki2
{
    class Program
    {
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceLn() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();

        public static void wyswietlX(int n)
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
            if (n % 2 == 0) n = n + 1;

            for (int i = 0; i < n/2; i++)
            {
                for(int j = 0; j < i;j++)
                {
                    Space();
                }
                Star();
                for(int j = 0;j<n -2 -2 *i;j++)
                {
                    Space();
                }
                StarLn();
            }


            for(int i = 0;i<n/2;i++)
            {
                Space();
            }
            StarLn();

            int m = n;

            for(int x = m/2; x> 0; x--) 
            {
                for(int i = x-1; i>0 ;i--)
                {
                    Space();
                }
                Star();
                for(int j=0;j<m-2*x;j++)
                {
                    Space();
                }
                StarLn();

            }
        }
        static void Main(string[] args)
        {
            wyswietlX(14);
        }
    }
}
