using System;
using System.Collections.Generic;

namespace SprawdzianZadanie1
{
    class Program
    {
        public static void Analyze(string logs)
        {
            string[] rozdzieloneLinie = logs.Split("\n");
            string[] rozdzieloneIP = new string[rozdzieloneLinie.Length];
            string[] rozdzieloneLoginy = new string[rozdzieloneLinie.Length];

            string[,] lista = new string[rozdzieloneLinie.Length,2];
            for (int i = 0; i < rozdzieloneLinie.Length; i++)
            {
                rozdzieloneIP[i] = rozdzieloneLinie[i].Split(" ")[3];
                rozdzieloneLoginy[i] = rozdzieloneLinie[i].Split(" ")[2];
                lista[i, 0] = rozdzieloneLoginy[i];
                lista[i, 1] = rozdzieloneIP[i];
            }

            SortedList<string,int> listaLoginow = new SortedList<string, int>();
            for (int a = 0; a < lista.GetLength(0); a++)
            {
                for (int b = a; b < lista.GetLength(0); b++)
                {
                int licznik = 0;
                    if (lista[a,0] == lista[b,0])
                    {
                        if (lista[a,1] != lista[b,1])
                            licznik++;
                    }
                    if (licznik > 0)
                        listaLoginow.Add(lista[a, 0], 1);
                }
            }

            var wynik = "";
            foreach (var x in listaLoginow)
            {
                    wynik += x.Key + ", ";
            }

            if (wynik == "")
                Console.WriteLine("empty");
            else
            {
                var wynik2 = wynik.Substring(0, wynik.Length - 2);
                Console.WriteLine(wynik2);
            }
        }
        static void Main(string[] args)
        {
            string logi = 
                "2021-06-10 5:20 mirek 180.40.41.121\n" +
                "2021-06-10 10:20 adam 80.40.41.12\n" +
                "2021-06-10 10:21 admin 192.168.4.10\n" +
                "2021-06-11 8:09 maciek 149.40.53.12\n" +
                "2021-06-11 8:10 adam 80.40.41.120\n" +
                "2021-06-11 18:10 mirek 180.40.41.122";

            logi =
                "2021-06-10 5:20 mirek 180.40.41.120'n" +
                "2021-06-10 10:20 adam 80.40.41.120\n" +
                "2021-06-10 10:21 admin 192.168.4.10\n" +
                "2021-06-11 8:09 maciek 149.40.53.12\n" +
                "2021-06-11 8:10 kazik 80.40.41.120";

            logi =
                "2021-06-10 5:20 mirek 180.40.41.120\n" +
                "2021-06-10 10:20 adam 80.40.41.120\n" +
                "2021-06-10 10:21 admin 192.168.4.10\n" +
                "2021-06-11 8:09 admin 149.40.53.12\n" +
                "2021-06-11 8:10 adam 80.40.41.120\n" +
                "2021-06-11 18:10 mirek 180.40.41.120";

            Analyze(logi);
        }
    }

}
