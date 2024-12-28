using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.SampleDeadlock
{
    public class DeadLock
    {

        static object lock1 = new object();
        static object lock2 = new object();

        public void taskall()
        {

            Thread thread1 = new Thread(ExecuteThread1);
            Thread thread2 = new Thread(ExecuteThread2);


            //int a = 0;
            
           // Parallel.For(0, 10, b => { Console.WriteLine(b); });

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();


            
        }
         void ExecuteThread1()
        {
            lock (lock1)
            {
                Console.WriteLine("Thread 1: Holding lock1...");
                Thread.Sleep(100);
                
                Console.WriteLine("Thread 1: Waiting for lock2...");
                lock (lock2)
                {
                    Console.WriteLine("Thread 1: Acquired lock2!");
                }
            }
        }

         void ExecuteThread2()
        {
            lock (lock2)
            {
                Console.WriteLine("Thread 2: Holding lock2...");
                Thread.Sleep(100);

                Console.WriteLine("Thread 2: Waiting for lock1...");
                lock (lock1)
                {
                    Console.WriteLine("Thread 2: Acquired lock1!");
                }
            }

        }
    }
}
