using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadStartDelegateExample
{
     class Program
    {
 
       public static void Main()
        {

            //Static  example

            //threadstart is a delegate of void and no parameters
            Thread T1 = new Thread(new ThreadStart(Number.PrintNumbers));

            //same as T1 - explicatly writing delegate
            Thread T2 = new Thread(delegate () { Number.PrintNumbers(); });

            //same as t1 and t2 -- using lambda
            Thread T3 = new Thread(() => Number.PrintNumbers());

            //also same- framwwork handles the delegate behind the scenes
            Thread T4 = new Thread(Number.PrintNumbers);


            //uncommentme for static test
            //////////T3.Start();
            

            //not static function example

            Number number = new Number();
            Thread T4n = new Thread(number.InstancePrintNumbers);
            //uncomment me to  executed instance Thread
            //T4n.Start();


            //user to enyer upto
            Console.WriteLine("please enter targer number");
           object target =  Console.ReadLine();

            //paramatised Thread is to allow parameters
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(number.PrintNumbers2);
            Thread pt = new Thread(parameterizedThreadStart);
            //uncomment to test thread with specific writing of parameterizedThreadStart
           // pt.Start(target);

            //do not need to write parameterized threadStart as shown above
            //compliler does the conversion implicity converts
            Thread pt2 = new Thread(number.PrintNumbers2);

            //uncomment here for short version of parameterisedThreadStart
            pt2.Start(target);


            //note losse c# type safety this way of passing object to thread.






            Console.Read();

        }
    }

    class Number
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void InstancePrintNumbers()

        {
            for (int i = 10; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void PrintNumbers2(object target)
        {
            
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
            {

                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }



    
}
