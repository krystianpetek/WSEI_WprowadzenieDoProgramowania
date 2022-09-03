using System;
using System.Collections.Generic;

namespace SprawdzianProbnyZadanie1
{
    class Program
    {
        public static void Analyze(string logs)
        {
            string[] rozdzieloneLinie = logs.Split("\n");
            string[] rozdzieloneDaty = new string[rozdzieloneLinie.Length];
            string[] rozdzieloneLoginy = new string[rozdzieloneLinie.Length];
            Dictionary<string, int> listaDni = new Dictionary<string, int>();
            for (int i = 0; i < rozdzieloneLinie.Length; i++)
            {
                rozdzieloneDaty[i] = rozdzieloneLinie[i].Split(" ")[0];
                rozdzieloneLoginy[i] = rozdzieloneLinie[i].Split(" ")[2];
                //   Console.WriteLine(rozdzieloneDaty[i]);
                //   Console.WriteLine(rozdzieloneLoginy[i]);

                if (listaDni.ContainsKey(rozdzieloneDaty[i]))
                    listaDni[rozdzieloneDaty[i]] += 1;
                else
                    listaDni.Add(rozdzieloneDaty[i], 1);
            }

            SortedDictionary<string, int> listaLoginow = new SortedDictionary<string, int>();
            for (int i2 = 0; i2 < rozdzieloneLoginy.Length; i2++)
            {
                if (listaLoginow.ContainsKey(rozdzieloneLoginy[i2]))
                {
                    listaLoginow[rozdzieloneLoginy[i2]] += 1;
                }
                else
                {
                    listaLoginow.Add(rozdzieloneLoginy[i2], 1);
                }
            }
            var wynik = "";
            foreach (var x in listaLoginow)
            {
                if (x.Value == listaDni.Count)
                    wynik += x.Key + ", ";
            }


            if (wynik == "")
                Console.WriteLine("empty");
            else {
            var wynik2 = wynik.Substring(0, wynik.Length - 2);
            Console.WriteLine(wynik2);
        }

        }
        static void Main(string[] args)
        {
            string logi = "2021-06-10 5:20 mirek 180.40.41.120\n2021-06-10 10:20 adam 80.40.41.120\n2021-06-10 10:21 admin 192.168.4.10\n2021-06-11 8:09 maciek 149.40.53.12\n2021-06-11 8:10 adam 80.40.41.120\n2021-06-11 18:10 mirek 180.40.41.120";
            //logi = "2021-06-10 5:20 mirek 180.40.41.120\n2021-06-10 10:20 adam 80.40.41.120\n2021-06-10 10:21 admin 192.168.4.10\n2021-06-11 8:09 maciek 149.40.53.12\n2021-06-11 8:10 kazik 80.40.41.120";
            Analyze(logi);
        }

    }
}
