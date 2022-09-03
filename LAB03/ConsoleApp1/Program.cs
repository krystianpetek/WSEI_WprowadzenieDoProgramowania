using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (i != j)
                    {
                        n--;
                    }
                }

            }
            Console.WriteLine(n);
        }
    }
}
