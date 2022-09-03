using System;

namespace inneZadanie13
{
    class Program
    {
        static void Main()
        {
            string napis1 = Console.ReadLine();
            string napis2 = Console.ReadLine();
            string napis3 = Console.ReadLine();
            string napis4 = Console.ReadLine();
            int jeden, dwa, trzy, cztery;
            try
            {
                jeden = int.Parse(napis1);
                dwa = int.Parse(napis2);
                trzy = int.Parse(napis3);
                cztery = int.Parse(napis4);
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
            catch (Exception)
            {
                Console.WriteLine("non supported exception, exit");
                return;
            }

            try
            {
                checked
                {
                    if (jeden + dwa == trzy + cztery)
                        Console.WriteLine("yes");
                    else if (jeden + trzy == dwa + cztery)
                        Console.WriteLine("yes");
                    else if (dwa + trzy == jeden + cztery)
                        Console.WriteLine("yes");
                    else
                        Console.WriteLine("no");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("overflow exception, exit");
                return;
            }
        }
    }
}
