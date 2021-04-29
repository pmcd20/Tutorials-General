using System;

/* This example below has two prize functions. 
 * Depending on the number will determing what prize will be given
 * only if the number is greater then 80 then we are to run the function
 * The functions are stored in a variable that basically can be passed around. 
 */

namespace FuncDelegate
{
    class Program
    {

        static Func<int, int> EvenProcess = Sum;
        static Func<int, int> OddProcess = Multiply;


        static void Main(string[] args)
        {
            Console.WriteLine("Game Begin");
            int TotalAmountWon = 0;


            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"{i} tries left");
                int rand = 0;
                rand = new Random().Next(0, 100);

                Func<int, int> selectedProcess = (rand % 2 == 0) ? EvenProcess : OddProcess;


                //Game 

                if (rand > 80) 
                {
                    //give prize
                    int gameTotal = selectedProcess(rand);
                    Console.WriteLine($"This round, you have won {gameTotal}");
                    TotalAmountWon += gameTotal;
                    
                }

          



            }

            if (TotalAmountWon == 0)
            {
                Console.WriteLine("Hard luck");
            }
            else
            {
                Console.WriteLine($"Well done. you won {TotalAmountWon}");
            }

        }



        static int Sum(int x)
        {
            Console.WriteLine("Sum Process");
            return x + x;
        }

        static int Multiply(int x)
        {
            Console.WriteLine("Multiply Process");
            return x * x;
        }






    }
}
