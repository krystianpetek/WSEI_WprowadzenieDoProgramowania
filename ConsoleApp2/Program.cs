using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            
            for(int i = 0; i < 3; i++)
            {
                var x = int.Parse(Console.ReadLine());
                suma += x;
            }
            Console.WriteLine(suma);
        }
    }
}
