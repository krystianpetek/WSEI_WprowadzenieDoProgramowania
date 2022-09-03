using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZwiazkiKlas
{
    public class Car : Vehicle, IWithEngine
    {
        public override void Drive()
        {
            engine.TurnOn();
            //....
        }

        public override void Stop()
        {
            //....
            engine.TurnOff();
        }
        public override string ToString() => "Car: " + this.GetHashCode().ToString();

        public Engine GetEngine() => engine;

        private Engine engine = new Engine();
        
        private CarTrailer carTrailer;
        public CarTrailer Trailer
        {
            get => carTrailer;
            set
            {
                if (value is null)
                {
                    carTrailer.Disconnect();
                    return;
                }
                if (value.ConnectedTo == null)
                {
                    carTrailer = value;
                    value.ConnectTo(this);
                }
            }
        }
    }
}

