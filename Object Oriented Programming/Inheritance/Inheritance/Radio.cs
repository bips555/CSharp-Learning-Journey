using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Radio: ELectricalDevice
    {
      public Radio(bool isOn,string brand):base(isOn,brand) 
        { 
        
        }
      
        
        public void ListenRadio()
        {
            if (this.IsOn)
            {
                Console.WriteLine("Listening to the radio.");
            }
        }
      
    }
}
