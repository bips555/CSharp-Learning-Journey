using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Objects
{
    public class Human
    {
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        public Human()
        {
            Console.WriteLine("COnstructor called. Object created.");
        }

        public Human(string firstName,string lastName,string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age; 
        }
        public Human(string firstName, string lastName, string eyeColor )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
          
        }
        public Human(string firstName, string lastName )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            
        }
        public Human(string firstName)
        {
            this.firstName = firstName;
        }
        public void IntroduceMyself()
        {
            if (age != 0 && firstName!= null && lastName != null && eyeColor!=null)
            {
                Console.WriteLine($"Hello, I am {firstName + " " + lastName}");
                Console.WriteLine($"My eye color is {eyeColor} and my age is {age}");
            }
            else if (firstName != null && lastName != null && eyeColor != null)
            {
                Console.WriteLine($"Hello, I am {firstName + " " + lastName}");
                Console.WriteLine($"My eye color is {eyeColor}.");
            }
            else if (firstName != null && lastName != null)
            {
                Console.WriteLine($"Hello, I am {firstName + " " + lastName}");
            }
            else if (firstName !=null)
            {
                Console.WriteLine("HI my name is {0}",firstName);
            }

        }

    }
}
