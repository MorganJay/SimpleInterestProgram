using System;
using System.Collections.Generic;
using System.Threading;

namespace CompoundInterestApp
{
    internal class Program
    {
        // A = principal * (1 + rate/n)^ number of times interest is compounded in time period * time in year/months
        private static void Main(string[] args)
        {
            const decimal rate = 0.0625m;
            const uint quarterCompound = 4;
            const uint annualCompound = 1;
            const uint weeklyCompund = 52;
            const uint dailyCompound = 365;
            Console.WriteLine("*******Welcome to National Bank********");
            Console.WriteLine("Now, you can know how much you would receive if you invest with us after any VALID period of time you wish");
            Console.WriteLine("Note that we deal in compounded interest only....which is the best kind of interest");
            Console.WriteLine($"Our interest rate is {rate:P}");
            Thread.Sleep(1000);

            Console.WriteLine("Please enter the principal amount you wish to invest..");
            decimal principal = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Should the interest be given annually, quarterly, weekly or daily ? ");
            var compoundRate = Console.ReadLine().ToLower();

            Console.WriteLine("Please enter the time period in months...");
            decimal duration = Decimal.Parse(Console.ReadLine());

            decimal value;
            switch (compoundRate)
            {
                case "annually":
                    value = principal * (decimal)Math.Pow((double)(1 + (rate / annualCompound)), (double)(annualCompound * duration / 12));
                    Console.WriteLine($"The total amount you will receive at the end of {duration} month(s) is {value:C}");
                    break;

                case "quarterly":
                    value = principal * (decimal)Math.Pow((double)(1 + (rate / quarterCompound)), (double)(quarterCompound * duration / 12));
                    Console.WriteLine($"The total amount you will receive at the end of {duration} month(s) is {value:C}");
                    break;

                case "weekly":
                    value = principal * (decimal)Math.Pow((double)(1 + (rate / weeklyCompund)), (double)(weeklyCompund * duration / 12));
                    Console.WriteLine($"Wow!! You will receive {value:C} after {duration} months");
                    break;

                case "daily":
                    value = principal * (decimal)Math.Pow((double)(1 + (rate / dailyCompound)), (double)(dailyCompound * duration / 12));
                    Console.WriteLine($"OMO Lord of Lavish!! After {duration} months you will cash out {value:C}");
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            Console.WriteLine("Thank you for banking with us :)");
            Thread.Sleep(5000);
        }
    }
}