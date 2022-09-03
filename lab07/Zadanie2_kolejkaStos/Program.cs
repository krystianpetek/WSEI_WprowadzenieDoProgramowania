using System;
using System.Collections.Generic;
namespace Zadanie2_kolejkaStos
{
    class Program
    {
        static void Podglad(Stack<string> stos, Queue<string> kolejka)
        {
            
            string[] wyswietlStos = stos.ToArray();
            Console.Write("Stos: ".PadRight(12));
            for (int i = 0; i < wyswietlStos.Length; i++)
                Console.Write($"{wyswietlStos[i]} ");

            Console.WriteLine();
            string[] wyswietlKolejka = kolejka.ToArray();
            Console.Write("Kolejka: ".PadRight(12));
            for (int i = 0; i < wyswietlKolejka.Length; i++)
                Console.Write($"{wyswietlKolejka[i]} ");

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var stos = new Stack<string>();
            var kolejka = new Queue<string>();

            stos.Push(1.ToString());
            stos.Push(2.ToString());
            stos.Push(3.ToString());
            stos.Push(4.ToString());

            kolejka.Enqueue("a");    
            kolejka.Enqueue("b");    
            kolejka.Enqueue("c");    
            kolejka.Enqueue("d");
            Console.WriteLine("Po inicjalizacji");
            Podglad(stos, kolejka);

            kolejka.Enqueue(stos.Pop());
            kolejka.Enqueue(stos.Pop());

            Console.WriteLine("Po zmianach #1");
            Podglad(stos, kolejka);

            Console.WriteLine($"Szczytowy element stosu: {stos.Peek()}");
            Console.WriteLine($"Pierwszy element kolejki: {kolejka.Peek()}");

            stos.Pop();
            stos.Pop();
            kolejka.Enqueue("e");

            Console.WriteLine("Po zmianach #2");
            Podglad(stos, kolejka);

        }
    }
}
