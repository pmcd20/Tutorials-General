using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingExample
{

    /// <summary>
    /// https://www.youtube.com/watch?v=fjvMr12TU1Q&index=92&list=PLAC325451207E3105
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main thread started");
            Thread T1 = new Thread(Thread1Function);
            T1.Start();

            Thread T2 = new Thread(Thread2Function);
            T2.Start();

            if (T1.Join(1000)) //main thread will wait a certain time for T1
            {
                Console.WriteLine("thread1Function completed");
            }
            else
            {
                Console.WriteLine("thread 1 did not complete");
            }
            T2.Join(); //main thread waits for T2.toComplete
            Console.WriteLine("thread2Function completed");


            for (int i = 0; i < 10; i++)
            {
                if (T1.IsAlive)
                {
                    Console.WriteLine("thread1Function is still Working");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine("thread 1 is completed");
                    break;
                }
            }
          


            Console.WriteLine("Main Completed");
            Console.Read();
        }

        public static void Thread1Function()
        {
            
            Console.WriteLine("thread1Function started");
            Thread.Sleep(5000);
            Console.WriteLine("thread1Function about to return");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("thread2Function started");
        }
    }
}
