using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class TV : ELectricalDevice
    {
      
        public TV(bool isOn, string brand):base(isOn,brand)
        {
           
        }
    
        public void WatchTV()
        {
            if (this.IsOn)
            {
                Console.WriteLine("Watching to the TV.");
            }
            else
            {
                Console.WriteLine("Tv is turned off. Turn it On!");
            }

        }
    }
}
