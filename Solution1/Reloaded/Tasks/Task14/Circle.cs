﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task14
{
    public class Circle
    {
        public double Radius {get; set;}
        public double Area => Math.PI * Math.Pow(Radius, 2);
    }
}
