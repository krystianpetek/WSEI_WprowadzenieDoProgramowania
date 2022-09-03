using System;

namespace probnyZadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            string napis1 = Console.ReadLine();
            string napis2 = Console.ReadLine();
            string napis3 = Console.ReadLine();
            int jeden = 0, dwa = 0, trzy = 0, suma = 0;

            try
            {
                jeden = int.Parse(napis1);
                dwa = int.Parse(napis2);
                trzy = int.Parse(napis3);
            }
            catch (FormatException)
            {
                Console.WriteLine("format exception, exit");
                return;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("argument exception, exit");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("overflow exception, exit");
                return;
            }

            try
            {
                checked
                {
                    suma = jeden + dwa + trzy;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("overflow exception, exit");
                return;
            }
            Console.WriteLine(suma);
        }
    }
}
