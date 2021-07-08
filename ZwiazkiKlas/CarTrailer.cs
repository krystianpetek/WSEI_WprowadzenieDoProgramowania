using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZwiazkiKlas
{
    public class CarTrailer
    {

        public Car ConnectedTo { get; private set; }
        public bool ConnectTo(Car car)
        {
            if (ConnectedTo != null) return false;

            // ToDo czy pojazd nie ma innej przyczepy podpietej
            ConnectedTo = car;
            return true;
        }

        public void Disconnect()
        {
            ConnectedTo = null;
            // info o odpięciu
        }
        public override string ToString()
        {
            if (ConnectedTo is null) return "brak";
            return "jest przyczepka";
        }
    }
}