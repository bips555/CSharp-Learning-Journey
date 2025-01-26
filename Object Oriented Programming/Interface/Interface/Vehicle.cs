using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Vehicle
    {
        protected float Speed { get; set; }
        protected string Color { get; set; }

        public Vehicle()
        {
            this.Speed = 30.02f;
            this.Color = "Black";
        }
        public Vehicle(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
        }
    }
}
