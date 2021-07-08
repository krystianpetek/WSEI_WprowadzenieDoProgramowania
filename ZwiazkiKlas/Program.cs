using System;

namespace ZwiazkiKlas
{
    class Program
    {
        static void Main(string[] args)
        {
            var kp = new Owner("Krystian Petek");
            Console.WriteLine(kp.ToString());
            kp.Print();

            var przyczepka = new CarTrailer();
            var myCar = new Car();
            myCar.Trailer = przyczepka;
            //Console.WriteLine(myCar);
        }
    }
}
