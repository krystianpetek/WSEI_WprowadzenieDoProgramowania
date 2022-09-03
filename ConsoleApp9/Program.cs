using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            var linia = Console.ReadLine();
            var tab = linia.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            int a = int.Parse(tab[0]);
            int b = int.Parse(tab[1]);
            int suma = 0;
            for (int i = a;i <= b ;i++)
            {
                int oblicz = i * i;
                suma += oblicz;
            }
            Console.WriteLine(suma);
        }
    }
}
