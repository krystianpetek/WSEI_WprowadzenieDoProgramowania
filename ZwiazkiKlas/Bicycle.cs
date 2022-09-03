using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZwiazkiKlas
{
    public class Bicycle : Vehicle
    {
        public override void Drive()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
        public override string ToString() => "Bicycle: " + this.GetHashCode().ToString();
    }
}