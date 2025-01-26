namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ticket t1 = new Ticket(10);
              Ticket t2 = new Ticket(20);
              Console.WriteLine(t1.Equals(t2));
              t2.UpdateTicket(10);
              Console.WriteLine(t1.Equals(t2));*/

            //Creating your own interface

            /*  Chair officeChair = new Chair("Brown","Plastic");
              Chair gamingChair = new Chair("Black", "Wood"); 
              Car toyota = new Car(120f,"Pink");
              toyota.destroyablesNearyby.Add(officeChair);
              toyota.destroyablesNearyby.Add(gamingChair);
              toyota.Destroy();*/

            //IEnumerable<T> interface and IEnumerator<T> method

            /* DogShelter dogShelter = new DogShelter();

             foreach(Dog dog in dogShelter)
             {
                 if(!dog.IsNaughty)
                 {
                     dog.GiveTreat(2);
                 }
                 else
                 {
                     dog.GiveTreat(1);
                 }
             }*/

            //Ienumerable example 1

            /*   IEnumerable<int> myCollection = GetCollection(1);

               Console.WriteLine("This is a list");

               foreach (int i in myCollection)
               {
                   Console.WriteLine(i);

               }
               myCollection = GetCollection(2);
               Console.WriteLine("THis is queue");
               foreach (int i in myCollection)
               {
                   Console.WriteLine(i);
               }
               myCollection = GetCollection(3);
               Console.WriteLine("this is array");
               foreach (int i in myCollection)
               {
                   Console.WriteLine(i);
               }*/

            int[] numbers = { 12, 34, 5 };

            CollectionSum(numbers);

            List<int> list = new List<int>() { 1, 2, 3, 4 };
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
                
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            CollectionSum(queue);
            CollectionSum(list);

            Console.ReadKey();
        }
        static IEnumerable<int> GetCollection(int option)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            if (option == 1)
            {
                return list;
            }
            else if (option == 2)
            {
                return queue;
            }
            else
            {
                return new int[] { 2, 3, 4, 5 };
            }


        }

        //Passing Inumerable as a parameter in a method
        static void CollectionSum(IEnumerable<int> collection)
        {
            int sum = 0;

            foreach (int i in collection)
            {
                sum += i;
            }
            Console.WriteLine("sum is {0}", sum);
        }
    }

}