using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Furntiture
    {
        
       protected string Color { get; set; }
       protected string Material {  get; set; }
        public Furntiture() {
            this.Color = "White";
            this.Material = "Wood";
        }
        public Furntiture(string color,string material)
        {
            this.Color = color;
            this.Material = material;
        }
       
    }
}
