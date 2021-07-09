using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZwiazkiKlas
{
    public class ElectricBicycle : Vehicle, IWithEngine
    {
        public override void Drive()
        {
            throw new NotImplementedException();
        }

        public Engine GetEngine()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
        public override string ToString() => "Electic bicycle: " + this.GetHashCode().ToString();
    }
}