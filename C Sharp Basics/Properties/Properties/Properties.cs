using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Properties
    {
        private int length = 3;
        private int width=3; 
        public int volume;
       
        public Properties(int length,int width,int height) {
            this.length = length;
            this.width = width;
            this.Height = height;
        }
        public int FrontSurface
        {
            get
            {
                return length * width;
            }
        }
       public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
       public int Height { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine("Lenth is {0}, width is {1},height is {2}",Length,Width,Height);
        }
        public int CalculateVolume()
        {
            return length * width * Height;
        }
    }
    class Members
    {
        //private fields
        private string memberName;
        private int memberAge;
        private int salary = 20000;
        //public properties
        public string MemberName {
            get
            {
                return memberName;
            }
            set
            {
                memberName = value;
            }

        }
        public int MemberAge
        {
            get
            {
                return memberAge;
            }
            set
            {
                memberAge = value;
            }

        }
        //Methods as members of class
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}",memberName);
            }
        }
        private void SharingPrivateInfo()
        {
            Console.WriteLine("My Salary is {0}", salary
                );
        }
    }
}
