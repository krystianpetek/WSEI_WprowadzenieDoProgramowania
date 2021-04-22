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

                //for(int a = 0;a<s-1;a++)
                //{
                //    Console.Write(".");
                //}
                //Console.Write("/");
                //Console.Write("\\");
                //for(int a = s-1;a>0;a--)
                //{
                //    Console.Write(".");
                //}

                for (int a = s; a >0 ; a--)
                {
                    for (int b = a; b >1 ; b--)
                    {
                        Console.Write(".");
                    }
                    Console.Write("/");

                    for(int x = s; x>a;x--)
                    {
                        Console.Write(".");
                    }


                    for(int b = 0;b<s;b++)
                    {
                        Console.Write(".");
                        for(int y = b;y>0;y--)
                            Console.Write("\\");
                    }
                    Console.WriteLine();


                }

            //    for (int x = 0; x < s; x++)
            //    {

            //        Console.Write("\\");
            //        for (int y = x; y < s; y++)



            //            Console.Write(".");

            //    }
            }
        }
    }
}
