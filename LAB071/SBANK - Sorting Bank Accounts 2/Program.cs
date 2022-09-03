using System;
using System.Text;
using System.Collections.Generic;

namespace SBANK___Sorting_Bank_Accounts_2
{    
    //2
    //6
    //03 10103538 2222 1233 6160 0142 
    //03 10103538 2222 1233 6160 0141 
    //30 10103538 2222 1233 6160 0141 
    //30 10103538 2222 1233 6160 0142 
    //30 10103538 2222 1233 6160 0141 
    //30 10103538 2222 1233 6160 0142 

    //5
    //30 10103538 2222 1233 6160 0144 
    //30 10103538 2222 1233 6160 0142 
    //30 10103538 2222 1233 6160 0145 
    //30 10103538 2222 1233 6160 0146 
    //30 10103538 2222 1233 6160 0143 

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder wynik = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            for (int x = 0; x < t; x++)
            {
                Dictionary<string, int> slownikKont = new Dictionary<string, int>();
                int n = int.Parse(Console.ReadLine());

                for (int j = 0; j < n; j++)
                {
                    var konto = Console.ReadLine();
                    if (slownikKont.ContainsKey(konto))
                        slownikKont[konto]++;
                    else
                        slownikKont.Add(konto, 1);
                }

                string[] tablicaKont = new string[slownikKont.Keys.Count];
                slownikKont.Keys.CopyTo(tablicaKont, 0);

                int ktoraCyfra = tablicaKont[0].Length - 1;
                string[] tablicaWynik = new string[tablicaKont.Length];
                int[] tablicaZliczen = new int[10];

                while (ktoraCyfra != 0)
                {
                    ktoraCyfra--;
                    Array.Clear(tablicaZliczen, 0, tablicaZliczen.Length);
                    wynik.Clear();

                    for (int i = 0; i < tablicaKont.Length; i++)
                    {
                        if (tablicaKont[i][ktoraCyfra] == ' ')
                            continue;
                        int iP = int.Parse(tablicaKont[i][ktoraCyfra].ToString());
                        tablicaZliczen[iP]++;
                    }

                    tablicaZliczen[0]--;
                    for (int i = 0; i < tablicaZliczen.Length - 1; i++)
                    {
                        tablicaZliczen[i + 1] += tablicaZliczen[i];
                    }
                    //Console.WriteLine("tablica zsumowana"); foreach (int x in tablicaZliczen) { Console.Write($"{x}\n"); }

                    for (int i = tablicaKont.Length - 1; i >= 0; i--)
                    {
                        if (tablicaKont[i][ktoraCyfra] == ' ')
                            continue;

                        int iP = int.Parse(tablicaKont[i][ktoraCyfra].ToString());
                        int iK = tablicaZliczen[iP];
                        tablicaZliczen[iP]--;
                        tablicaWynik[iK] = tablicaKont[i];
                    }
                    tablicaWynik.CopyTo(tablicaKont, 0);

                }
                foreach (var wpis in tablicaKont)
                    wynik.AppendLine($"{wpis} {slownikKont[wpis]}");
                Array.Clear(tablicaKont, 0, tablicaKont.Length);
                wynik.AppendLine();
                Console.ReadLine();
                Console.WriteLine(wynik);
            }
        }
    }
}
