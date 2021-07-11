using System;
using System.Numerics;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0;i<1;i++)
            {
                
                BigInteger liczbaRazem = BigInteger.Parse(Console.ReadLine());
                BigInteger liczbaWiecej = BigInteger.Parse(Console.ReadLine());
                
                if(liczbaRazem < liczbaWiecej /*|| liczbaRazem % 2 == 1 || liczbaWiecej % 2 == 1*/)
                {
                    break;
                }

                    BigInteger licz1 = (liczbaRazem - liczbaWiecej);
                    var klaudia = (licz1 / 2 + liczbaWiecej);
                    var natalia = licz1 / 2;

            }
        }
    }
}
