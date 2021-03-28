using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            while (true)
            {
                var linia = Console.ReadLine();
                if (linia == null || linia == "")
                {
                    break;
                }

                var x = int.Parse(linia);
                suma += x;
                Console.WriteLine(suma);
            }
        }
    }
}
