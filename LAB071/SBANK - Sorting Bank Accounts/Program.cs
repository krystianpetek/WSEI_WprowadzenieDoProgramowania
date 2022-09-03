using System;
using System.Collections.Generic;
using System.Text;

namespace SBANK___Sorting_Bank_Accounts
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
            for (int i = 0; i < t; i++)
            {
                Dictionary<string, int> slownik = new Dictionary<string, int>();
                int n = int.Parse(Console.ReadLine());

                for (int j = 0; j < n; j++)
                {
                    var konto = Console.ReadLine();
                    if (slownik.ContainsKey(konto))
                        slownik[konto]++;
                    else
                        slownik.Add(konto, 1);
                }
                string[] slowo = new string[slownik.Keys.Count];
                slownik.Keys.CopyTo(slowo, 0);
                Array.Sort(slowo);
                foreach (var wpis in slowo)
                    wynik.AppendLine($"{wpis} {slownik[wpis]}");
                wynik.AppendLine();
                Console.ReadLine();
            }
            Console.Write(wynik);
        }
    }
}
