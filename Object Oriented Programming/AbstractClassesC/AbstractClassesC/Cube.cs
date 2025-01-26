using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesC
{
    internal class Cube:Shape
    {
        public int Length { get; set; }
        public Cube(int length)
        {
            this.Name = "Cube";
            this.Length = length;
        }
        public override double Volume()
        {
            return Length * Length * Length;
        }
        public override void GetInfo()
        {
           base.GetInfo();
            Console.WriteLine($"Volume of {Name} is {Volume()}");
            Console.WriteLine($"Cube has a length of {Length}");
        }
    }
}
