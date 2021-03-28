using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma3 = 0;
            while (true)
            {
                var linia = Console.ReadLine();
                if (linia == null || linia == "")
                {
                    break;
                }
                var tablica = linia.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int suma = 0;
                for (int i = 0; i < tablica.Length ;i++)
                {
                    
                    suma += int.Parse(tablica[i]);
                }
                if (tablica.Length == 1 && int.Parse(tablica[0]) == 0)
                {
                    int sum = 0;
                    Console.WriteLine(sum);
                    break;
                }

                int suma2 = 0;
                suma2 += suma;
                Console.WriteLine(suma2);
                suma3 += suma2;

            }

            Console.WriteLine(suma3);
        }
    }
}
