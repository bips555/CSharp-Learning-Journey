using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Objects
{
    internal class Members
    {
        private string name;
        private string jobTitle;
        public int age;
        private int salary;

        public string JobTitle
        {
            get
            {

                return this.jobTitle;
            }
            set
            {
                this.jobTitle = value;
            }
        }
        public void Introduction(bool isFriend)
        {
            if (isFriend)
            {
                SharePrivateInfo();
            }
            else
            {
                Console.WriteLine("Name is {0} age is {1} and jobtitle is {2}", name, age, jobTitle);
            }
        }
        public void SharePrivateInfo()
        {
            Console.WriteLine("Salary is {0}",salary);
        }
        public Members()
        {
            this.name = "bips";
            JobTitle = "developer";
            this.age = 23;
            this.salary = 20000;
            
        }

        ~Members()
        {
            Console.WriteLine("This is finalizer");
            Debug.Write("Object has been destroyed");
        }
    }
}
