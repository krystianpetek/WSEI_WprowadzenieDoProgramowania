using System;

namespace MinimalnyProstokatOtaczajacy
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Punkt(3, 3);
            var k1 = new Kolo(new Punkt(5, 5), 5);
            var o1 = new Odcinek(new Punkt(4, 4), new Punkt(6, 6));
            var PR1 = new Prostokat();
            Console.WriteLine(PR1);
        }
    }
}
