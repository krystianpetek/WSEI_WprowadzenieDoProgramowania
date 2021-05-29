using System;
using System.Collections.Generic;
namespace Zadanie1_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicjalizacja listy");
            List<string> listaZwierzat = new List<string>() { "kot", "pies" };
            listaZwierzat.AddRange(new string[] { "kunolis", "jaszczurka", "myszka", "wąż", "świnka" });
            for (int i = 0; i < listaZwierzat.Count; i++)
                Console.Write($"{listaZwierzat[i]} ");

            Console.WriteLine("\n");
            Console.WriteLine("Usuń pozycje 2 i ostatnią");
            listaZwierzat.RemoveAt(1);
            listaZwierzat.RemoveAt(listaZwierzat.Count - 1);
            for (int i = 0; i < listaZwierzat.Count; i++)
                Console.Write($"{listaZwierzat[i]} ");

            Console.WriteLine("\n");
            Console.WriteLine("Dodaj muchę na ostatniej pozycji i gazelę na 2");
            listaZwierzat.Add("mucha");
            listaZwierzat.Insert(1, "gazela");
            for (int i = 0; i < listaZwierzat.Count; i++)
                Console.Write($"{listaZwierzat[i]} ");

            Console.WriteLine("\n");
            Console.WriteLine("Usuń gazele");
            listaZwierzat.Remove("gazela");
            for (int i = 0; i < listaZwierzat.Count; i++)
                Console.Write($"{listaZwierzat[i]} ");

            Console.WriteLine("\n");
            Console.WriteLine("Jeśli lista zawiera 'krowa' wypisz true, w przeciwnym razie false");
            Console.WriteLine(listaZwierzat.Contains("krowa") ? "true" : "false");
            Console.WriteLine("\nIndeks 'mucha'");
            Console.WriteLine(listaZwierzat.IndexOf("mucha"));

            Console.WriteLine();
            Console.WriteLine("Odwróć liste");
            listaZwierzat.Reverse();
            for (int i = 0; i < listaZwierzat.Count; i++)
                Console.Write($"{listaZwierzat[i]} ");

            Console.WriteLine("\n");
            Console.WriteLine("Inny zapis");
            listaZwierzat.ForEach(a => Console.WriteLine("Zwierze: " + a));


            listaZwierzat.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine();
            Console.WriteLine("Posortowana lista malejąco");
            listaZwierzat.ForEach(a => Console.Write($"{a} "));

            listaZwierzat.Sort();
            Console.WriteLine("\n");
            Console.WriteLine("Posortowana lista rosnąco");
            listaZwierzat.ForEach(a => Console.Write($"{a} "));

            Console.WriteLine();


            bool posortowane = false;
            for (int x = 0; x < listaZwierzat.Count - 2; x++)
            {
                string temp;
                posortowane = true;
                for (int y = 0; y < listaZwierzat.Count - 1; y++)
                {
                    if (listaZwierzat[y].Length > listaZwierzat[y + 1].Length)
                    {
                        temp = listaZwierzat[y];
                        listaZwierzat[y] = listaZwierzat[y + 1];
                        listaZwierzat[y + 1] = temp;
                        posortowane = false;
                    }
                }
                if (posortowane == true) break;
                Console.WriteLine();
                Console.WriteLine($"Krok[{x + 1}]");

                for (int k = 0; k < listaZwierzat.Count; k++)
                    Console.Write(listaZwierzat[k] + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Posortowana lista długością");
            listaZwierzat.ForEach(a => Console.Write($"{a} "));

            Console.WriteLine();

        }
    }
}
