using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ThreadingExampleConCurrentAccess
{
    /// <summary>
    /// https://www.youtube.com/watch?v=pjzplzR8E3U&list=PLAC325451207E3105&index=93
    /// </summary>
    class Program
    {
        //total is shared resource and is not projtected
        static int Total = 0;
        static object _lock = new object();
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            Thread T1 = new Thread(Program.AddOneMillion);
            Thread T2 = new Thread(Program.AddOneMillion);
            Thread T3 = new Thread(Program.AddOneMillion);

            stopwatch.Start();
            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join();
            T2.Join();
            T3.Join();


            Console.WriteLine("Total = " + Total);

            stopwatch.Stop();
            Console.WriteLine("Total Time is " + stopwatch.ElapsedTicks);
            Console.Read();

        }

        public static void AddOneMillion()
        {

            //when coming to just add .. subtract on a stactic int /long. 
            // use interlock class has increased performance



            for (int i = 1; i <= 1000000; i++)
            {
                //Total++;


                //Interlocked.Increment(ref Total);


                //lock ensure only one thread can hit this section
                lock(_lock)
                {
                    Total++;
                }

            }
        }

    }
}
