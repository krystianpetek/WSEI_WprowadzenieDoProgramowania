using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            string wejscie = Console.ReadLine();
            int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);
            short a = Convert.ToInt16(dane[0]);
            short b = Convert.ToInt16(dane[1]);

            if (a == b || a - b == 1 || b - a == 1)
            {
                Console.WriteLine("empty");
            }
            else if (a > b)
            {
                short temp = a;
                a = b;
                b = temp;
            }
            a+=1;
            for (short i = a; i < b; i++)
            {
                if(b - a > 10)
                {
                    for(short j = 1; j <= 3; j++)
                    {
                        Console.Write($"{i}, ");
                        i++;

                    }
                    Console.Write($"..., {b-2}, {b-1}");
                    break;
                }
                
                if (i == b - 1)

                    Console.WriteLine(i);
                else

                    Console.Write($"{i}, ");
            }
        }
    }
}
