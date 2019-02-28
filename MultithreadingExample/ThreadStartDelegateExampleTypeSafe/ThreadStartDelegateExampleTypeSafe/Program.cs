using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStartDelegateExampleTypeSafe
{
    //also doing a return from thread using delegate
    public delegate void SumOfNumbersCallBack(int CallBack);


    class Program
    {
        public static void PrintSumOutput(int sum)
        {
            Console.WriteLine("Sum of numbers = " + sum);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("please enter targer number");
            int target = Convert.ToInt32(Console.ReadLine());

            SumOfNumbersCallBack callBack = new SumOfNumbersCallBack(PrintSumOutput);
            Number number = new Number(target,callBack);
            //Same thing 
           // Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));
            Thread T1 = new Thread(number.PrintSumOfNumbers);
            T1.Start();

            Console.Read();
        }
    }


    class Number
    {
        int _target;
        SumOfNumbersCallBack _CallBackMethod;
        public Number(int target, SumOfNumbersCallBack callBackMethod)
        {
            this._target = target;
            this._CallBackMethod = callBackMethod;
        }

        public void PrintSumOfNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= _target; i++)
            {
                //Console.WriteLine(i);
                sum += i;

            }
            if (_CallBackMethod != null)
            {
                _CallBackMethod(sum);
            }
        }
    }
}
