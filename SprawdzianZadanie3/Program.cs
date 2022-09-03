using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SprawdzianZadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            // klasa Prostokat, konstruktor domyślny
            Prostokat p = new Prostokat();
            Console.WriteLine(p);
            p.Rysuj();
        }
    }
}
