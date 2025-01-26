using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractClassesC
{
    internal class Sphere:Shape
    {
        const double PI = 3.14;
        public double Radius { get; set; }
        public Sphere(int radius)
        {
            this.Radius = radius;
            Name = "Sphere";
        }
        public override double Volume()
        {
            return 4/3 * PI * Math.Pow(Radius, 3);
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"radius of {Name} is {Radius}");
            Console.WriteLine($"Volume of {Name} is {Volume()}");
        }
    }
}
