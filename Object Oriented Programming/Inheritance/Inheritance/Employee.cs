using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee
    {
     public string Name { get; set; }
      public string FirstName { get; set; }
        
      public float Salary { get; set; }

        public virtual void Work()
        {
            Console.WriteLine($"{Name} is Working");
            Console.WriteLine($"{Salary} is salary." );
           
        }
        public void Pause()
        {
            Console.WriteLine($"{Name} has paused working.");
        }
        public Employee(string name,string firstName,float salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }
        

    }
}
