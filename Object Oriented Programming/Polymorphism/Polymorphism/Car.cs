using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Car
    {
        protected string HP { get; set; }
        protected string Color { get; set; }  

        protected CarIdIdInfo cardIdInfo  = new CarIdIdInfo();

        public void SetCarIdInfo(int id,string owner)
        {
            cardIdInfo.CarId = id;
            cardIdInfo.Owner = owner;
        }
        public void GetCarIdInfo()
        {
            Console.WriteLine("Id of car is {0} and its owner is {1}", cardIdInfo.CarId,cardIdInfo.Owner);
        }
        public Car(string HP, string Color)
        {
            this.HP = HP;
            this.Color = Color;
        }
        public Car()
        {
            HP = "125ps";
            Color = "White";
        }
        public  void ShowDetails()
        {
            Console.WriteLine("HP of the car is {0} and color of the car is {1}",HP,Color);
        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired.");
        }
    }
}
