using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZwiazkiKlas
{
    public class Car : Vehicle
    {
        public Owner Owner { get; set; } = null;

        private CarTrailer carTrailer = null;
        public CarTrailer Trailer
        {
            get => carTrailer;
            set
            {
                if (value is null)
                { carTrailer.Disconnect();
                    return;
            }
                if(value.ConnectedTo == null)
                {
                    carTrailer = value;
                    value.ConnectTo(this);
                }
            }
            
        }

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
        public override string ToString() => this.Owner.Name + " " + this.Trailer;

        private Engine engine = new Engine();
        private class Engine
        {
            internal void TurnOn()
            {

            }
            internal void TurnOff()
            {

            }
        }

    }
    
}