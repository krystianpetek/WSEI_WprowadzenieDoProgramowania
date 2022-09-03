using System;

namespace ConsoleApp12_characterPatterns3
{
    class Program
    {
        // Character Patterns 3
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

                for (int a = 0; a < c; a++)
                {
                    Console.Write("*");
                    Console.Write("*");
                    Console.Write("*");
                    if (a == c - 1)
                        Console.WriteLine("*");
                }

                for (int y = 0; y < l; y++)
                {
                    for (int x = 0; x < c; x++)
                    {
                        Console.Write("*");
                        Console.Write(".");
                        Console.Write(".");
                        if (x == c - 1)
                            Console.WriteLine("*");
                    }

                    for (int x = 0; x < c; x++)
                    {
                        Console.Write("*");
                        Console.Write(".");
                        Console.Write(".");
                        if (x == c - 1)
                            Console.WriteLine("*");
                    }

                    for (int x = 0; x < c; x++)
                    {
                        Console.Write("*");
                        Console.Write("*");
                        Console.Write("*");
                        if (x == c - 1)
                            Console.WriteLine("*");
                    }
                }
            }
        }
    }
}
