﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public interface IMeasurable2D : IMeasurable1D
    {
        double Circumference { get; }
        double Surface { get; }
    }
}
