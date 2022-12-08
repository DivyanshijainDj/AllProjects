using System.Diagnostics;
using System.Threading;
namespace CS_ThreadBasics
{
    class Program
    {
        static void Main()
        {
            //object of myclass for accessing
            //multiple threads

            //MyClass obj = new MyClass();
            //obj.Increment();

            Thread t1 = new Thread(MyClass.Increment);
            //t1.Priority = ThreadPriority.Highest;
            Console.WriteLine();
            //obj.Decrement();
            t1.Start();
          
            t1.Join();
            

            Thread t3 = new Thread(MyClass.Decrement);
            t3.Start();
            t3.Join();

            //Thread t2 = new Thread(MyClass.Decrement);
            //// t2.Priority = ThreadPriority.Lowest;
            //Console.WriteLine($"State {t1.ThreadState} and {t2.ThreadState}");
            //t1.Start();
            //t1.Join();
            //t2.Start();

            Console.WriteLine($"State {t1.ThreadState} and {t2.ThreadState}");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main THread i = {i}");
            }

            Console.ReadLine();
            
        }
    }

 

    public static class MyClass
    {
        public static void Increment()
        {
            var start = Stopwatch.StartNew();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Increment {i}");
                //Thread.Sleep(1000);
            }
            var totalTime = start.Elapsed.TotalMilliseconds;

            Console.WriteLine($"Time for INcrement {totalTime}");
        }
        public static void Decrement()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"Decrement {i}");
            }
        }
    }
}

