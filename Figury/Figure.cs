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
        private static int counter = 0;
        public const int FRACTIONAL_DIGITS = 4;
        public string Label { get; set; }
        public System.Drawing.Color Color { get; set; }
        abstract public void Draw();
        public Figure()
        {
            counter++;
            this.Color = Color.Black;
            Label = $"{GetType().Name} #{counter}";
        }
        public override string ToString() => $"Figure: {Label}";
    }
}