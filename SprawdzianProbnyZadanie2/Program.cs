using System;

namespace SprawdzianProbnyZadanie2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Test: AddScore
            Player p = new Player(name: "mol123", password: "aB12.,aC");
            Console.WriteLine(p);
            try
            {
                p.AddScore(-1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                p.AddScore(101);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            p.AddScore(100);
            Console.WriteLine(p);
            p.AddScore(0);
            Console.WriteLine(p);

        }
    }
}
