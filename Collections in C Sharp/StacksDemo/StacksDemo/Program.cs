namespace StacksDemo
{
    internal class Program
    {
        static int removedItem = 0;
        static void Main(string[] args)
        {
          Stack<int> myStack = new Stack<int>();
            /*   myStack.Push(1);
               myStack.Push(2);
               myStack.Push(3);
               myStack.Push(4);
               myStack.Push(5);
               myStack.Push(6);*/
            /*   foreach(int i in myStack)
               {
                   Console.Write(i +" ");   
               }
               Console.WriteLine();
               removedItem = myStack.Pop();

               foreach (int i in myStack)
               {
                   Console.Write(i+" ");
               }
               Console.WriteLine();
               Console.WriteLine(myStack.Peek());
               while(myStack.Count > 0)
               {
                   removedItem = myStack.Pop();
                   Console.WriteLine("Popped item is {0}",removedItem);
                   Console.WriteLine("Count of stack is now : {0}",myStack.Count);
               }*/
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            foreach(int i in numbers)
            {
                Console.Write(i + " ");
                myStack.Push(i);
            }
            Console.WriteLine();
           while(myStack.Count > 0)
            {
                removedItem = myStack.Pop();
                Console.Write(removedItem + " ");
            }

            Console.ReadKey();    
        }
    }
}
