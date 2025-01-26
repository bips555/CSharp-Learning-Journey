using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Trainees:Employee
    {
        int WorkingHours { get; set; }
        int SchoolHours { get; set; }

        public void Learn()
        {

            Console.WriteLine($"{Name} studies for {SchoolHours} school hours in school.");
        }
        public override void Work()
        {
            Console.WriteLine($"{Name} should work for {WorkingHours} working hours and salary is {Salary}");
           
        }
        public Trainees(string name,int WorkingHours,int SchoolHours,string firstName,int salary):base(name,firstName,salary)
        {
            this.WorkingHours = WorkingHours;
            this.SchoolHours = SchoolHours;
        }
    }
}
