﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesDemo
{
    public class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Rate { get; set; }
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
        public Employee(string Role, string Name, int Age, int Rate)
        {

            this.Role = Role;
            this.Name = Name;
            this.Age = Age;
            this.Rate = Rate;
        }
    }
}
