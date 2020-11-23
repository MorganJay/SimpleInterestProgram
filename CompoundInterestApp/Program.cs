using System;
using System.Collections.Generic;
using System.Threading;

namespace CompoundInterestApp
{
    internal class Program
    {
        private const decimal rate = 0.0625m;
        private const uint quarterCompound = 4;
        private const uint annualCompound = 1;
        private const uint weeklyCompund = 52;
        private const uint dailyCompound = 365;

        private static void Main(string[] args)
        {
            WelcomeUser();
            CalculateInterest();
            Closing();
        }

        private static void WelcomeUser()
        {
            Console.WriteLine("*******Welcome to National Bank********");
            Console.WriteLine("Now, you can know how much you would receive if you invest with us after any VALID period of time you wish");
            Console.WriteLine("Note that we deal in compounded interest only....which is the best kind of interest");
            Console.WriteLine($"Our interest rate is {rate:P}");
            Thread.Sleep(1000);
        }

        private static void CalculateInterest()
        {
            List<string> compoundIntervals = new List<string>() { "annually", "quarterly", "weekly", "daily" };
            string compoundRate;

            Console.WriteLine("Please enter the principal amount you wish to invest.");
            decimal principal = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Should the interest be given annually, quarterly, weekly or daily?");
            compoundRate = Console.ReadLine().ToLower();

            if (!compoundIntervals.Contains(compoundRate))
            {
                do
                {
                    Console.WriteLine("Please enter a valid input");
                    compoundRate = Console.ReadLine().ToLower();
                } while (!compoundIntervals.Contains(compoundRate));
            }

            Console.WriteLine("Please enter the time period in months.");
            decimal duration = decimal.Parse(Console.ReadLine());

            decimal finalAmount;
            switch (compoundRate)
            {
                case "annually":
                    finalAmount = principal * (decimal)Math.Pow((double)(1 + (rate / annualCompound)), (double)(annualCompound * duration / 12));
                    Console.WriteLine($"You will receive {finalAmount:C} at the end of {duration} month(s).");
                    break;

                case "quarterly":
                    finalAmount = principal * (decimal)Math.Pow((double)(1 + (rate / quarterCompound)), (double)(quarterCompound * duration / 12));
                    Console.WriteLine($"The total amount you will receive at the end of {duration} month(s) is {finalAmount:C}");
                    break;

                case "weekly":
                    finalAmount = principal * (decimal)Math.Pow((double)(1 + (rate / weeklyCompund)), (double)(weeklyCompund * duration / 12));
                    Console.WriteLine($"Wow!! You will receive {finalAmount:C} after {duration} month(s)");
                    break;

                case "daily":
                    finalAmount = principal * (decimal)Math.Pow((double)(1 + (rate / dailyCompound)), (double)(dailyCompound * duration / 12));
                    Console.WriteLine($"OMO Lord of Lavish!! After {duration} month(s) you will cash out {finalAmount:C}");
                    break;
            }
        }

        private static void Closing()
        {
            Console.WriteLine("Thank you for banking with us :)");
            Thread.Sleep(10000);
        }
    }
}