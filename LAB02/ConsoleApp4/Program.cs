using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                var linia = Console.ReadLine();
                var tablica = linia.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int suma = 0;
                for (int j = 0; j < n; j++)
                {
                    var x = int.Parse(tablica[j]);
                    suma += x;
                }
                Console.WriteLine(suma);
            }
        }
    }
}