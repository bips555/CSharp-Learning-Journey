namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Radio radio = new Radio(true,"HP");
             radio.ListenRadio();
             TV tv = new TV(false, "Dell");
             tv.SwitchOn();
             tv.WatchTV();*/

            //116) Override and virtual keywords

            /*Dog dog = new Dog("puppy",9);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old. ");
            dog.Eat();
            dog.MakeSound();
            dog.Play();*/

            /*  Post post1 = new Post("THanks you everbody for the birthday wishes", true, "bips subedi");
              post1.Update("NO thanks", true);
              Console.WriteLine(post1.ToString());


              Post post2 = new Post("I am sick", true, "bips subedi");
              Console.WriteLine(post2.ToString());
              ImagePost imagePost = new ImagePost("new image post","bips subedi","abc.jpeg",true);
              Console.WriteLine(imagePost.ToString());
              VideoPost videoPost = new VideoPost("VLog Video","bips subedi","https://Videos/Vlog1",10,true);
              Console.WriteLine(videoPost.ToString());
              videoPost.Play();
              videoPost.Stop();*/

            Employee empl = new Employee("bips subedi", "bips", 40000);
            empl.Work();
            Boss boss = new Boss("bips subedi","Auto","bips",123450);
            boss.Lead();
            Trainees trainee = new Trainees("trainee", 5, 6, "bips", 2000);
            trainee.Work();
            trainee.Learn();
            Console.ReadKey();

        }
    }
}
