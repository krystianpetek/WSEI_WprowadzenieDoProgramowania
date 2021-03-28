using System;
using System.Numerics; // BIG INTEGER
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                var linia = Console.ReadLine();
                var tab = linia.Split(" ");
                BigInteger suma = 0;
                for(int x = 0;x<=1;x++)
                {
                    BigInteger a = BigInteger.Parse(tab[0]);
                    BigInteger b = BigInteger.Parse(tab[1]);
                     suma = (a + b);
                }

                Console.WriteLine(suma);
            }
        }
    }
}
