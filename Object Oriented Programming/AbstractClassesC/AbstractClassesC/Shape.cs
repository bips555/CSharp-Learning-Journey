﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesC
{
    internal abstract class Shape
    {
        public string Name { get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine($"\nthis is a {Name}");
        }
        public abstract double Volume();
    }
}
