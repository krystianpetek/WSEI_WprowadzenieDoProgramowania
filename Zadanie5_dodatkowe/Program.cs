using System;
using System.Collections.Generic;
namespace Zadanie5_dodatkowe
{
    class Program
    {
        static string Sprawdz(string wczytaj)
        {

            bool OK = true;
            Stack<char> stos = new Stack<char>();
            int i = 0;
            char[] tablicaZnakow = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '(', ')', '/', '*', '-', '+', '=' };
            while (i < wczytaj.Length && OK)
            {
                char znak = wczytaj[i];

                bool check = false;
                for (int z = 0; z < tablicaZnakow.Length; z++)
                    if (wczytaj[i] == tablicaZnakow[z])
                    {
                        check = true;
                        break;
                    }

                if (!check)
                    return "null";

                if (znak == '(')
                    stos.Push('(');
                else
                  if (znak == ')')
                    if (stos.Count == 0)
                    {
                        OK = false;
                        return i.ToString();
                    }
                    else
                        stos.Pop();

                i++;
            }

            //if (OK && stos.Count == 0)
            //    Console.WriteLine("wszystko jest poprawnie");
            //else if (OK && stos.Count != 0)
            //    Console.WriteLine("za dużo nawiasów otwierających");
            //else if (!OK)
            //    Console.WriteLine("za dużo nawiasów zamykających");

            string wynik = String.Empty;
            if (OK)
                if (stos.Count == 0)
                    wynik = "0";
                else
                    wynik = "stos nie jest pusty " + i.ToString();
            else
                wynik = i.ToString();

            return wynik;
        }
        static void Main()
        {

            var odczytaj = Sprawdz(Console.ReadLine());
            Console.WriteLine(odczytaj);
        }

        static void Mai1n(string[] args)
        {
            Stack<char> stos = new Stack<char>();
            char[] wejscie = Console.ReadLine().ToCharArray();

            for (int i = 0; i < wejscie.Length; i++)
            {
                try
                {
                    if (wejscie[i] == '(')
                        stos.Push(wejscie[i]);
                    else if (wejscie[i] == ')')
                        stos.Pop();

                    if (i == wejscie.Length - 1 && stos.Count == 0)
                        Console.WriteLine("Wszystko ok");
                    else if (i == wejscie.Length - 1 && stos.Count != 0)
                        Console.WriteLine("za dużo nawiasów otwierających");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("za dużo nawiasów zamykających");
                    break;
                }

            }

        }
    }
}
