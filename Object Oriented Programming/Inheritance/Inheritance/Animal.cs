using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
      public  string Name { get; set; }
      public  int Age { get; set; }
      public  bool IsHungry { get; set; }

        public Animal(string name,int age)
        {
            this.Name = name;
            this.Age = age; 
            this.IsHungry = true;
        }
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is now playing.");
        }
        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is Eating.");
            }
            else
            {
                {
                    Console.WriteLine($"{Name} is not hungry.");
                }
            }
        }
        public virtual void MakeSound()
        {
        }
    }
}
