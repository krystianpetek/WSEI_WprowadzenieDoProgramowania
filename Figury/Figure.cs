using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figury
{
    public abstract class Figure
    {
        public string Label { get; set; }
        public System.Drawing.Color Color { get; set; }

        private static int counter = 0;
        public Figure()
        {
            counter++;
            this.Color = Color.Black;
            Label = $"{GetType().Name} #{counter}";
        }
        abstract public void Draw();

        public override string ToString() => $"Figure: {Label}";

        public const int FRACTIONAL_DIGITS = 4;
    }
}