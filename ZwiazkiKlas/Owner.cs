using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZwiazkiKlas
{
    public class Owner : Person
    {
        private List<Car> cars;
        public Owner(string name) : base(name)
        {
            cars = new List<Car>();
        }

        public new void Print()
        {
            base.Print();
            if (cars.Count == 0)
                Console.WriteLine("brak pojazdów");
            else
                Console.WriteLine(String.Join(",", cars));
        }
        public override string ToString() => $"{Name}: {String.Join(",",cars)}";

        public void Buy(Car car)
        {
            if (car == null) return;

            if (!cars.Contains(car))
                cars.Add(car);

            car.Owner = this;
        }
        public void Sell(Car car)
        {
            if (car is null) return;
            if (cars.Contains(car)) cars.Remove(car);
            car.Owner = null;
        }

    }
}