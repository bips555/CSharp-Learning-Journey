namespace QueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Dequeue();
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }*/
           Queue<Order> orderQueue = new Queue<Order>();
           foreach(Order order in ReceivedOrderFromBranch1())
            {
                orderQueue.Enqueue(order);
            }
           foreach(Order order in ReceivedOrderFromBranch2())
            {
                orderQueue.Enqueue(order); 
            }
           foreach(Order o in orderQueue)
            {
                Console.WriteLine(o.Id);
            }
            Console.ReadKey();
        }
        
        static Order[] ReceivedOrderFromBranch1()
        {
            Order[] order = new Order[]
            {
                new Order(1,2),
                new Order(2,3),
                new Order(3,4),
                new Order(4,5),
                new Order(5,6)
            };
            return order;
                
        }
        static Order[] ReceivedOrderFromBranch2()
        {
            Order[] order = new Order[]
            {
                new Order(11,21),
                new Order(21,31),
                new Order(31,41),
                new Order(41,51),
                new Order(51,61)
            };
            return order;
            
        }

    }
}
