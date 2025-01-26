using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Car : Vehicle,IDestroyable
    {

        public string DestructionSound {  get; set; }

        public List<IDestroyable> destroyablesNearyby;
        //CLass cannot have multiple base classes
        //Need to implement all the members when we inherit the interface
        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            DestructionSound = "CarExplosionSound.mp3";

          destroyablesNearyby =  new List<IDestroyable>();
        }
        public void Destroy()
        {
            Console.WriteLine("Playing Destruction Sound {0}", DestructionSound);
            Console.WriteLine("Creating fire.");
            foreach (IDestroyable destroyable in destroyablesNearyby)
            {
                destroyable.Destroy();
            }
        }
    } 
}
