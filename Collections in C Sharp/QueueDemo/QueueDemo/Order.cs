using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    public class Order
    {
        public  int Id { get; set; }
        public int Quantity { get; set; }
        public Order(int id, int quantity)
        {
            this.Id = id;
            this.Quantity = quantity;
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Order Processed: {0}",Id);
        }
        

    }
}
