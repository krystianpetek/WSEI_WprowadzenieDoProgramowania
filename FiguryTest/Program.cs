using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figury;

namespace FiguryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== default constructor ==");
            Point P0 = new Point();
            Console.WriteLine(P0);
            P0.Draw();

            Console.WriteLine("\n== new point (1,2) ==");
            Point P1 = new Point(1, 2);
            Console.WriteLine(P1);
            P1.Draw();

            Console.WriteLine("\n== another new point (1,2) ==");
            Point P2 = new Point(1, 2);
            P2.Color = System.Drawing.Color.Red; // bo konflikt nazw
            Console.WriteLine(P2);
            P2.Draw();

            Console.WriteLine("P1 equals P2: " + (P1 == P2));

            Console.WriteLine("\n== another new point (1.00001, 2.000009) ==");
            Point P3 = new Point(1.00001, 2.000009);
            P3.Color = System.Drawing.Color.Yellow; // bo konflikt nazw
            Console.WriteLine(P3);
            P3.Draw();

            Console.WriteLine("P1 equals P3: " + (P1 == P3));

            // LINE

            var linia = new LineSegment();
            linia.StartPoint = new Point(2, 2);
            Console.WriteLine(linia);
            linia.Draw();
            var linia2 = new LineSegment(new Point(2, 2), new Point(0, 0));
            Console.WriteLine(linia2);
            Console.WriteLine(linia == linia2);
            
            // CIRCLE
            Console.WriteLine();
            var okrag = new Circle();
            okrag.Srodek = new Point(2, 5);
            okrag.Promien = 3;
            okrag.Draw();
            var okrag2 = new Circle(new Point(2, 5), 1);
            Console.WriteLine(okrag2 == okrag);
            okrag2.Promien = 3;
            Console.WriteLine(okrag == okrag2);

            //WHEEL
            Console.WriteLine(); 
            var kolo = new Wheel();
            kolo.Srodek = new Point(5, 4);
            kolo.Promien = 3;
            kolo.Draw();
            var kolo2 = new Wheel(new Point(5, 4), 3);
            kolo2.Draw();
            Console.WriteLine(kolo == kolo2);

            // VECTOR
            var vector1 = new Vector(-11, 2);
            Console.WriteLine();
            Console.WriteLine("Okrag");
            okrag.Draw();
            okrag.Move(vector1);
            okrag.Draw();
            Console.WriteLine(  );
            Console.WriteLine("KOLO");
            kolo.Draw();
            kolo.Move(vector1);
            kolo.Draw();

            var vector2 = new Vector(5, -3);
            Console.WriteLine();
            Console.WriteLine("Linia");
            linia2.EndPoint = new Point(1, 1);
            linia2.Draw();
            linia2.Move(vector2);
            linia2.Draw();

            Console.WriteLine("\n==================================\n");
            var trojkat = new Triangle(new Point(1, 1), new Point(5, 1), new Point( 4,4));
            Console.WriteLine( trojkat.Length);
        }
    }
}
