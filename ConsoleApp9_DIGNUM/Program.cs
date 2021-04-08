using System;

namespace ConsoleApp9_DIGNUM
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                

                string liniaGora = Console.ReadLine();

                if (liniaGora == "" || liniaGora == " " || liniaGora == null)
                    break;

                string liniaSrodek = Console.ReadLine();
            string liniaDol = Console.ReadLine();

                

                char[] znakiGora = liniaGora.ToCharArray();
                char[] znakiSrodek = liniaSrodek.ToCharArray();
                char[] znakiDol = liniaDol.ToCharArray();

                int x = -3;
                int y = -2;
                int z = -1;
                int licznik = 0;
                while (licznik != znakiGora.Length / 3)
                {
                    licznik++;
                    if (znakiGora[y + 3] == ' ') // 1 lub 4
                    {
                        if (znakiSrodek[y + 3] == '_')
                            Console.Write("4");
                        else
                            Console.Write("1");
                    }
                    else if (znakiSrodek[z + 3] == ' ') // 5 lub 6
                    {
                        if (znakiDol[x + 3] == ' ')
                            Console.Write("5");
                        else
                            Console.Write("6");
                    }
                    else if (znakiDol[x + 3] == '|' && znakiDol[y + 3] == '_') // 2 lub 6 lub 8 lub 0
                    {
                        if (znakiSrodek[y + 3] == ' ')
                            Console.Write("0");
                        else if (znakiDol[z + 3] == ' ')
                            Console.Write("2");
                        else if (znakiSrodek[y + 3] == '_')
                            Console.Write("8");
                    }
                    else if (znakiSrodek[y + 3] == '_' && znakiSrodek[z + 3] == '|' && znakiDol[z + 3] == '|')
                    {
                        if (znakiDol[y + 3] == '_')
                            Console.Write("3");
                        else
                            Console.Write("9");
                    }
                    else if (znakiSrodek[x + 3] == ' ' && znakiDol[x + 3] == ' ')
                        if (znakiGora[y + 3] == '_')
                            Console.Write("7");
                        else
                            break;
                    x += 3;
                    y += 3;
                    z += 3;
                    
                }
                Console.WriteLine();
            }
        }

    }
}
