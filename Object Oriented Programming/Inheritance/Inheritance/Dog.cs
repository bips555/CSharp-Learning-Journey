using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Dog:Animal
    {
        bool IsHappy { get; set; }  
        public Dog(string name,int age ):base(name,age) {
            IsHappy = true;
        
        }

        public override void Eat()
        {
            //If you want to call the method of base class.
            base.Eat();

        }
        //Overriding the make sound method of Parent class Animal.
        public override void MakeSound()
        {
            Console.WriteLine("Woof.");
        }
        public override void Play()
        {
            if (IsHappy)
            {
               base.Play();
            }
            else
            {
                Console.WriteLine("Dog is not Playing.");
            }
        }
    }
}
