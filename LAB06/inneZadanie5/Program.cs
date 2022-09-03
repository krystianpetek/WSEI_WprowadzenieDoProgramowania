using System;

namespace inneZadanie5
{
    class Program
    {
        static void Main()
        {
            string napis1 = Console.ReadLine();
            string napis2 = Console.ReadLine();
            string napis3 = Console.ReadLine();
            int jeden, dwa, trzy, suma;
            int min, max;
            try
            {
                jeden = int.Parse(napis1);
                min = jeden;
                max = jeden;
                dwa = int.Parse(napis2);
                if (dwa > max)
                {
                    max = dwa;
                }
                else if (dwa < min)
                {
                    min = dwa;
                }
                trzy = int.Parse(napis3);
                if (trzy > max)
                {
                    max = trzy;
                }
                else if (trzy < min)
                {
                    min = trzy;
                }
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
                    suma = max - min;
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
