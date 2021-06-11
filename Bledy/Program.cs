using System;

namespace Bledy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 1, 4, 7, 9, 3, 12 };
            int i = 0;
            while (i < tab.Length)
            {
                if (tab[i] % 2 == 0)
                    Console.WriteLine("{0} to liczba parzysta", tab[i]);
                else
                    i++;
            }
            Console.ReadKey();
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("Wprowadź liczbę");
            int liczba = int.Parse(Console.ReadLine());
            if (liczba >= 0)
            {
                Console.WriteLine("Pierwiastek {0}", Math.Sqrt(liczba));
            } // Klamra do usunięcia
            Console.WriteLine("Potęga {0}", Math.Pow(liczba, 2));
            Console.ReadKey();
        }
    }
}
