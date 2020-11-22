using System;
using System.Globalization;
using System.Collections.Generic;

// You are employed as a junior dev at National bank and you're asked to create a small program to allow prospective customers know the sum
//they would collect after saving in the bank for a period of time.
// The interest rate is fixed at 6.25% per month by the federal reserve, using simple interest.
//Create a simple console program that would allow the user speculate an amount,
//and returns to the user the total amount he would get based on the number of months he specifies.

//Do the one for compound interest

namespace SimpleInterestProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SimpleCase();
            //IfCase()
            //SwitchCase()
            //ForEach()
        }

        private static void SimpleCase()
        {
            const decimal rate = 5.5m;
            Console.WriteLine("*******Welcome to National Bank********");

            Console.WriteLine("Please enter your Principal amount..");
            decimal principal = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your tenure in months...");
            uint duration = (uint)int.Parse(Console.ReadLine());

            var interest = principal * rate * duration / 12 / 100;
            var totalSum = interest + principal;
            Console.WriteLine($"The total amount you will receive at the end of {duration} month(s) is {totalSum:C}");
            Console.WriteLine("Thank you for banking with us :)");
            Console.ReadLine();
        }

        private static void IfCase()
        {
            const decimal rate = 6.25m;
            const decimal vat = 7.5m;
            decimal interest = 0;
            Console.WriteLine("*******Welcome to National Bank********");

            Console.WriteLine("Please enter your Principal amount..");
            decimal principal = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your tenure in months...");
            uint duration = (uint)int.Parse(Console.ReadLine());

            if (principal >= 1000000m)
            {
                interest = principal * rate * duration * vat / 100 / 100;
            }
            else
            {
                interest = (principal * rate * duration) / 100;
            }

            var totalSum = interest + principal;
            Console.WriteLine($"The total amount you will receive at the end of {duration} month(s) is {totalSum:#,###,###}.");
            Console.WriteLine("Thank you for banking with us :)");
            Console.ReadLine();
        }

        private static void SwitchCase()
        {
            const decimal rate = 6.25m;
            const decimal vat = 7.5m;
            decimal interest = 0;
            decimal cot = 0;
            Console.WriteLine("*******Welcome to National Bank********");
            Console.WriteLine("Please what's your account type?");
            var accountType = Console.ReadLine().ToLower();

            Console.WriteLine("Please enter your Principal amount..");
            decimal principal = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your tenure in months...");
            uint duration = (uint)int.Parse(Console.ReadLine());

            switch (accountType)
            {
                case "saving":
                    interest = principal * rate * duration * vat / 100 / 100;
                    break;

                case "current":
                    interest = principal * rate * duration * cot / 100 / 100;
                    break;

                case "domiciliary":
                    Console.WriteLine("");
                    break;

                case "student":
                    interest = principal * rate * duration / 100;
                    break;

                case "dollar":
                    Console.Write("Please enter the dollar multiplier: ");
                    var multiplier = decimal.Parse(Console.ReadLine());
                    interest = principal * rate * duration * multiplier / 100;
                    break;

                default:
                    Console.WriteLine("Account type not found, exiting........");
                    break;
            }

            var totalSum = interest + principal;
            Console.WriteLine("The total amount you will receive at the end of {0} month(s) is {1:C3}.", duration, totalSum);
            Console.WriteLine("Thank you for banking with us :)");
            Console.ReadLine();
        }

        private static void ForEach()
        {
            var amounts = new List<decimal>();
            decimal total = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number");
                decimal number = decimal.Parse(Console.ReadLine());
                amounts.Add(number);
            }

            foreach (var number in amounts)
            {
                total += number;
            }
            Console.WriteLine("The total sum of the numbers you entered is {0}", total);
            Console.ReadLine();
        }
    }
}