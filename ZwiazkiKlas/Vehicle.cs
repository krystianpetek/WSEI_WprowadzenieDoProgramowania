using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZwiazkiKlas
{
    public abstract class Vehicle
    {
        public Owner Owner { get; set; } = default;

        public abstract void Drive();
        public abstract void Stop();
        public override string ToString() => "Jakiś wehikuł";
    }
}