using System;

namespace ConsoleApp10_characterPatterns1
{
    class Program
    {
        // Character Patterns 1
        // DANE WEJSCIOWE:
        // 3
        // 3 1
        // 4 4
        // 2 5

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string linia = Console.ReadLine();
                string[] ciagLiczb = linia.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int l = int.Parse(ciagLiczb[0]);
                int c = int.Parse(ciagLiczb[1]);
                for (int y = 0; y < l; y++)
                {
                    for (int x = 0; x < c; x++)
                    {
                        if (y % 2 == 0)
                        {
                            if (x % 2 == 1)
                                Console.Write(".");
                            else
                                Console.Write("*");
                        }
                        else
                        {
                            if (x % 2 == 0)
                                Console.Write(".");
                            else
                                Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
