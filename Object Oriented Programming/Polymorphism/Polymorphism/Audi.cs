using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Audi:Car
    {
        public string Model { get; set; }
        private string brand = "audi";
        public Audi(string hp, string color, string model):base(hp,color)
        {
           
            this.Model = model;
         
        }
        public  void ShowDetails()
        {
            Console.WriteLine("Hp of the car is {0} and color is {1} model is {2} and brand is {3}",this.HP,this.Color,this.Model,this.brand);
        }
        public override void Repair()
        {
            Console.WriteLine("Repairing car of brand {0}",this.brand);
        }
    }
}
