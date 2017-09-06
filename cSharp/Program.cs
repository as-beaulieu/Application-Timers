using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; //Stopwatch is static class under Diagnostics

namespace AppTimer
{
    class AppTimer
    {
        public static Int64 Calculation;
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch(); //Immediately create new instance of Stopwatch
            //Start the Stopwatch
            timer.Start();

            //Run some calculations
            Calculation = 1;
            
            for (var i = 0; i < 1000; i++)
            {
                Calculation++;
                Calculation = Calculation * 3;
            }

            Console.WriteLine("Final Calculation is: " + Calculation);

            //Before program ends, stop Stopwatch and display value
            timer.Stop();

            TimeSpan final = timer.Elapsed; //Stopwatch.Elapsed is of TimeSpan type

            Console.WriteLine("End Program. Program run time: " + final);
            Console.ReadLine();
        }
    }
}
