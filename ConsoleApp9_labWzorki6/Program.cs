using System;

namespace ConsoleApp9_labWzorki6
{
    class Program
    {   
        // labWzorki6
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarNl() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceNl() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();
        public static void X(int n)
        {
            for (int i = 0; i < n/2; i++)
            {
                
                for (int j = 0; i> j; j++)
                    Space();
                Star();
                for (int k = 0; k < n - 2-2*i; k++)
                    Space();
                StarNl();
            }
            if (n % 2 == 1)
                for (int x = 0; x < n/2; x++)
                    Space();
                StarNl();
            for(int i = n/2;i>0;i--)
            {
                for(int j = i-1;j>0;j--)
                Space();
                Star();
                for(int k = 0; k<n-2*i;k++)
                {
                    Space();
                }
                StarNl();
            }
        }
        static void Main(string[] args)
        {
            X(7);
        }
    }
}
