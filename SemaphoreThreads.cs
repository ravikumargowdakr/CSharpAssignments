using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Assignment
{
    internal class Program
    {

        private static Semaphore _pool;

        private static int _padding;
        static void Main(string[] args)
        {
            _pool = new Semaphore(initialCount: 0, maximumCount: 3);
            for (int i = 1; i <= 5; i++)
            {
                Thread th = new Thread(new ParameterizedThreadStart(Worker));
                th.Start(i);
            }
            Thread.Sleep(500);
            Console.WriteLine("Main thread calls Release(3).");
            _pool.Release(releaseCount: 3);

            Console.WriteLine("Main thread exits.");
        }
        private static void Worker(object num)
        {
            Console.WriteLine("Thread {0} begins " +
                "and waits for the semaphore.", num);
            _pool.WaitOne();

            int padding = Interlocked.Add(ref _padding, 100);

            Console.WriteLine("Thread {0} enters the semaphore.", num);

 
            Thread.Sleep(1000 + padding);

            Console.WriteLine("Thread {0} releases the semaphore.", num);
            Console.WriteLine("Thread {0} previous semaphore count: {1}",
                num, _pool.Release());
        }
    }
}
