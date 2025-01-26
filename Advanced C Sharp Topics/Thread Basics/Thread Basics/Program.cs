using System.Security.Cryptography.X509Certificates;
using System.Threading;
namespace Thread_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Hello, World! 1");
              Thread.Sleep(1000);
              Console.WriteLine("Hello, World! 2");
              Thread.Sleep(1000);
              Console.WriteLine("Hello, World! 3");
              Thread.Sleep(1000);+
              Console.WriteLine("Hello, World! 4");
              Thread.Sleep(1000);*/
            //Main Thread
            /*   new Thread(()=>
               {
                   Console.WriteLine("Thread 1");
                   Thread.Sleep(1000);

               }).Start();
                 new Thread(() =>
                 {
                     Console.WriteLine("Thread 2");
                     Thread.Sleep(1000);
                 }).Start();
                 new Thread(() =>
                 {
                     Console.WriteLine("Thread 3");
                     Thread.Sleep(1000);
                 }).Start();
                 new Thread(() =>
                 {
                     Console.WriteLine("Thread 4");
                     Thread.Sleep(1000);
                 }).Start();*/

            var taskCompletionSource = new TaskCompletionSource<bool>();

            var thread = new Thread(() =>
            {
                Console.WriteLine($"Thread id : {Thread.CurrentThread.ManagedThreadId} started");
                Thread.Sleep(5000);
                taskCompletionSource.TrySetResult(true);
                Console.WriteLine($"Thread id : {Thread.CurrentThread.ManagedThreadId} ended");
            });
            thread.Start();


            var taskResult = taskCompletionSource.Task.Result;
            Console.WriteLine("Result is {0}", taskResult);

            /*   Enumerable.Range(1, 100).ToList().ForEach(f =>
               {
                   new Thread(() =>
                   {
                       Console.WriteLine($"Thread id : {Thread.CurrentThread.ManagedThreadId} started");
                       Thread.Sleep(100);

                       Console.WriteLine($"Thread id : {Thread.CurrentThread.ManagedThreadId} ended");
                   }).Start();


               });*/
            /*  Enumerable.Range(0, 1000).ToList().ForEach(f =>
              {
                  ThreadPool.QueueUserWorkItem((o) =>
              {
                  Console.WriteLine($"Thread id : {Thread.CurrentThread.ManagedThreadId} started");
                  Thread.Sleep(100);

                  Console.WriteLine($"Thread id : {Thread.CurrentThread.ManagedThreadId} ended");
              });
              });*/

            Thread t1 = new Thread(Thread1Function);
            Thread t2 = new Thread(Thread2Function);
            Console.WriteLine("Main Thread Started");
          
            t1.Start();
            t2.Start();
           
          if(t1.Join(1000))
            {
                Console.WriteLine("Thread1 was done");
            }
            else
            {
                Console.WriteLine("Thread1 was not done within 1 second.");
            }
          
            t2.Join();
            Console.WriteLine("Thread2 was done");

            for (int i = 0; i < 10; i++)
            {
                if (t1.IsAlive)
                {
                    Console.WriteLine("Thread1 is doing stuff");
                    Thread.Sleep(300);

                }
                else
                {
                    Console.WriteLine("Thread1 was completed");
                }
            }
            Console.WriteLine("Main Thread ended");

            Console.ReadKey();

        }
        static void Thread1Function()
        {
            Console.WriteLine("Thread1 function Started");
            Thread.Sleep(3000);
            Console.WriteLine("Thread1 Going back to caller");
        }
        static void Thread2Function()
        {
            Console.WriteLine("Thread2 function started");
        }

    }
}    


    

