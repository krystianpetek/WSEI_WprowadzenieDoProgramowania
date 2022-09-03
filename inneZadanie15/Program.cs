using System;

namespace inneZadanie15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] napis = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            
            int jeden, dwa, trzy, suma;
            int min, max;
            try
            {
                jeden = int.Parse(napis[0]);
                min = jeden;
                max = jeden;
                dwa = int.Parse(napis[1]);
                if (dwa > max)
                {
                    max = dwa;
                }
                else if (dwa < min)
                {
                    min = dwa;
                }
                trzy = int.Parse(napis[2]);
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
            catch(Exception)
            {
                Console.WriteLine("not supported exception, exit");
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
