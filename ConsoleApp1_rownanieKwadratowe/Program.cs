using System;

namespace ConsoleApp1_rownanieKwadratowe
{
    class Program
    {

        public static void QuadraticEquation(int a, int b, int c)
        {
            long A = a;
            long B = b;
            long C = c;
            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("infinity");
                return;
            }
            else if (a == 0 && b == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            else if (b == 0 || c == 0)
            {
                Console.WriteLine("x=0.00");
                return;
            }
            double delta = Math.Round(Math.Pow(B, 2) - (4 * A * C), 2);
            if (delta > 0)
            {
                if (A == 0)
                {
                    double x1 = (C * -1.0) / B;
                    Console.WriteLine($"x={x1:F2}");
                }
                else
                {
                    double x1 = Math.Round(((B * -1) + Math.Sqrt(delta)) / (2 * A), 2);
                    double x2 = Math.Round((((B * -1) + (Math.Sqrt(delta) * -1)) / (2 * A)), 2);
                    if (x1 > x2)
                    {
                        var temp = x1;
                        x1 = x2;
                        x2 = temp;
                    }
                    Console.WriteLine($"x1={x1:F2}");
                    Console.WriteLine($"x2={x2:F2}");
                }
            }
            else if (delta == 0)
            {
                double x1 = Math.Round(((B * -1.0) / 2 * A), 2);
                Console.WriteLine($"x={x1:F2}");
            }
            else
                Console.Write("empty");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wspołczynniki równania kwadratowego");
            Console.WriteLine("Podaj A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj B");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj C");
            int c = int.Parse(Console.ReadLine());

            QuadraticEquation(a, b, c);
        }
    }
}
