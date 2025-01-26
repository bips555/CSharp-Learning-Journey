using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Dog
    {
        public string Name { get; set; }    

        public bool IsNaughty { get; set; }

        public Dog(string name,bool isNaughty)
        {
            this.Name = name;
            this.IsNaughty = isNaughty;
        }
        public void GiveTreat(int numberOfTreats)
        {
            Console.WriteLine("Dog: {0} said woof {1} times! ",Name,numberOfTreats);
        }
    }
}
