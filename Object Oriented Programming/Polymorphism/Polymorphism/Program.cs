namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            List<Car> cars = new List<Car>()
            {
                new BMW ("120ps","white","b-1"),
                new Audi("130ps","black","a-1")

            };
            foreach(Car car in cars)
            {
                car.Repair();
            }
            Car bmw = new BMW("140ps", "white", "b-4");
            Car audi = new Audi("100ps", "green", "a-3");
            bmw.ShowDetails();
            audi.ShowDetails();

            BMW bmw2 = new BMW("160ps", "red", "b-4");
            bmw2.ShowDetails();

            Car car1 = (Car)bmw2;
            car1.ShowDetails();

            BMW bm3 = new BMW("120ps", "white", "b-6");
            bm3.SetCarIdInfo(123,"bips");
            bm3.GetCarIdInfo();
            Console.ReadKey();
        }
    }
}
