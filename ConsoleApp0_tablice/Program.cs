using System;

namespace ConsoleApp0_tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = Tab1D.GenTab(10, 1, 100); //size = 10, min = 1, max = 100
            Console.WriteLine(Tab1D.ConvertToString(tab));

            int[] tab1 = Tab1D.GenTab(15, -5, 5);
            Console.WriteLine(Tab1D.ConvertToString(tab1));


            int[] tab3 = Tab1D.GenTab(5, 1, 10);
            Console.WriteLine($"Suma liczb parzystych: {Tab1D.SumaParzystych(tab3)}");

           // (int min, int max) = Tab1D.MinMax(tab1); //trzeba zaprogramować MinMax
           //Console.WriteLine($"min={min} max={max}");
        }
    }
}
