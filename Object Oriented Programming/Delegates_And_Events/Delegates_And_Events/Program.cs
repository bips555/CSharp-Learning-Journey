namespace Delegates_And_Events
{
    internal class Program
    {
        public delegate bool FilterDelegate(Person p);
        static void Main(string[] args)
        {
            //Delegate Basic delegate is implicit as it is in RemoveAll method.
            /*  List<string> names = new List<string>() { "bips", "sips", "dips", "sam" };
              Console.WriteLine("...........Before");
              foreach (string name in names)
              {
                  Console.WriteLine(name);
              }
              names.RemoveAll(Filter);
              Console.WriteLine("........After");
              foreach (string name in names) 
              {
                  Console.WriteLine(name);
                      };*/

            /*  List<Person> personList = new List<Person>()
              {
                  new Person("Buwa",73),
                  new Person("Ram prasad",66),
                  new Person("Shyam",55),
                  new Person("Pradeep",36),
                  new Person("Roxxy",17),
                  new Person("Ishan",25),
                  new Person("Samriddhi",23),
                  new Person("Akshyata",26)
              };
              DisplayPeople("kids", personList, IsMinor);
              DisplayPeople("Adult", personList, IsAdult);
              DisplayPeople("Senior", personList, IsSenior);*/


            //Anonymous methods : Methods without a name

            /*FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };
            DisplayPeople("People in the age between 20 and 30", personList, filter);

            DisplayPeople("All", personList, delegate (Person p)
            {
                return true;
            });*/

            //Lambda expressions

            //  Statement labda
            /* DisplayPeople("People having age greather than 25 and containing 'A' in their names", personList, p =>
             {
                 if (p.Name.Contains("A") && p.Age > 25)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             });
             DisplayPeople("people having age 25", personList, p => p.Age == 25);*/


           AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();
            Game game = new Game("bips");
            Game game2 = new Game("sips");
            GameEventManager.TriggerGameStart();
            Console.WriteLine("Game is running.Press any key to end the game");
            Console.ReadLine();
            GameEventManager.TriggerGameStop();

            Console.ReadKey();
            


        }
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine($"Title is {title}");
            foreach (Person person in people)
            {
               
                if(filter(person))
                {
                    Console.WriteLine($"Name of Person is {person.Name}");
                    Console.WriteLine($"Age of pereson is {person.Age}");
                }
            }
            
        }
        static bool IsMinor(Person p) {
            return p.Age < 18;
        
        }
        static bool IsAdult(Person p)

        {
            return p.Age > 18;
        }

        static bool IsSenior(Person p)

        {
            return p.Age > 65;
        }
       
        static bool Filter(string s)
        {
            return s.Contains("i");
        }
        
           

    }
}
