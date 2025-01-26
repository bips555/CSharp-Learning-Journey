using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Boss:Employee
    {
        string CompanyCar { get; set; }

        public void Lead()
        {
            Console.WriteLine($"{Name} is leading the company");
            Console.WriteLine($"{CompanyCar} is company car.");
            Console.WriteLine($"{Salary} is salary.");
        }
      
        public Boss(string name,string companyCar,string firstName,int salary):base(name,firstName,salary)
        {
            this.CompanyCar = companyCar;
        }
    }
}
