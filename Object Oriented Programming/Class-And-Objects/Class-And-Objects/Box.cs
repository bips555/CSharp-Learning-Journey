using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Objects
{
    internal class Box
    {
        private int length;
        public int width =5;
        public int height=4;
        public int FrontSurface
        {
            get
            {
                return length * height;
            }
        }

        /*public void SetLength(int length)
        {
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }*/

        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;    
            }
        }

        public void GetVolume()
        {
            Console.WriteLine("volume of box is {0}",length*width*height);
        }
    }
}
