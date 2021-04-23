using System;

namespace ConsoleApp16_characterPatterns7
{
    class Program
    {
        // Character Patterns 7
        // DANE WEJSCIOWE:
        // 3
        // 3 1 2
        // 4 4 1
        // 2 5 2

        static void Main(string[] args)
        {
            // S - 3
            //../\..
            //./..\.
            ///....\
            //\..../
            //.\../.
            //..\/..

            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string linia = Console.ReadLine();
                string[] liniaTab = linia.Split(" ");
                int r = int.Parse(liniaTab[0]); // rows
                int c = int.Parse(liniaTab[1]); // columns
                int s = int.Parse(liniaTab[2]); // size of each diamond

                for (int rows = 0; rows < r; rows++)
                {

                    for (int a = s; a > 0; a--)
                    {
                        for (int cols = 0; cols < c; cols++)
                        {

                            for (int b = a; b > 1; b--)
                                Console.Write(".");
                            Console.Write("/");

                            for (int d = s; d > a; d--)
                                Console.Write(".");

                            for (int g = a; g < s; g++)
                                Console.Write(".");
                            Console.Write("\\");

                            for (int h = a; h > 1; h--)
                                Console.Write(".");
                        }
                        Console.WriteLine();
                    }

                    for (int a = 0; a < s; a++)
                    {
                        for (int cols = 0; cols < c; cols++)
                        {
                            for (int b = 0; b < a; b++)
                                Console.Write(".");
                            Console.Write("\\");

                            for (int d = s; d > a + 1; d--)
                                Console.Write(".");
                            
                            for (int g = s; g > a + 1; g--)
                                Console.Write(".");
                            Console.Write("/");
                            
                            for (int h = 0; h < a; h++)
                                Console.Write(".");
                        }
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
