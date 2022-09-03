using System;

namespace ConsoleApp11_characterPatterns2
{
    class Program
    {
        // Character Patterns 2
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
                    Console.Write("*");
                Console.WriteLine();

                for (int y = 1; y < l - 1; y++)
                {
                    Console.Write("*");
                    for (int x = 1; x < c - 1; x++)
                        Console.Write(".");

                    if (c > 1)
                        Console.WriteLine("*");
                    else
                        Console.WriteLine();
                }
                if (l > 1)
                    for (int b = 0; b < c; b++)
                        Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
