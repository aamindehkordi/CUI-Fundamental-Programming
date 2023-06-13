using System;

namespace loanCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money would you like? ");
            double loanAmount = double.Parse(Console.ReadLine());

            Console.Write("What kind of rate would you like? ");
            double rateApr = double.Parse(Console.ReadLine());

            Console.Write("How long would you like this money for? ");
            double termMonths = double.Parse(Console.ReadLine());

            double monthlyRate = 0.01 * rateApr / 12;
            double powerTerm = Math.Pow(1 + monthlyRate, termMonths);
            double monthlyPayment = monthlyRate * loanAmount * powerTerm / (powerTerm - 1);
            double totalPayment = monthlyPayment * termMonths;

            Console.WriteLine($"Here is your monthly payment: {monthlyPayment:C}");
            Console.WriteLine($"Here is your total payment: {totalPayment:C}");


        }
    }
}
