using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ELectricalDevice 
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public ELectricalDevice(bool isOn,string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand; 
        }

        public void SwitchOn()
        {
            this.IsOn = true;
        }
        public void SwitchOff()
        {
            this.IsOn = false;
        }
    }
}
