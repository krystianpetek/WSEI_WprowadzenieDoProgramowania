using System;
using System.Numerics;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                BigInteger suma = 0;
                var linia = Console.ReadLine();
                if (linia == null || linia == "") break;
                for (int i = 0; i < 2; i++)
                {
                    var tab = linia.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                    BigInteger a = BigInteger.Parse(tab[0]);
                    BigInteger b = BigInteger.Parse(tab[1]);
                    suma = (a - b);
                }
                Console.WriteLine(suma);
            }
        }
    }
}
