using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            if (args.Length < 3 /*|| args.Length != 3*/)
            {
                Console.WriteLine("You have entered the incorrect amount of arguments.");
                Console.WriteLine("For Example: ");
                Console.WriteLine("0.exe [balance] [rate] [termInYears]" /*{yearly investment}*/);
                Console.WriteLine("    (in dollars)(decimals)(months)"/*(optional)*/);
            }
            // else
            {
                if (double.Parse(args[0]) < 0)
                {
                    Console.WriteLine("We do not accept donations.");
                    return;

                }

                if (double.Parse(args[1]) <= 0 || double.Parse(args[1]) > 50)
                {
                    Console.WriteLine("Invalid APR");
                    return;
                }

                double rate;

                if (double.Parse(args[1]) > 0 && double.Parse(args[1]) < 1)
                {
                    rate = double.Parse(args[1]) * 100;
                }
                else
                {
                    rate = double.Parse(args[1]);
                }

                if (double.Parse(args[2]) <= 0)
                {
                    Console.WriteLine("No.");
                    return;
                }


                double balance = int.Parse(args[0]);
                int termInYears = int.Parse(args[2]) / 12;
                int termInMonths = int.Parse(args[2]);


                /*double yearlyInvestment = 0.00;
                if (args.Length == 3)
                {
                    yearlyInvestment = double.Parse(args[3]);
                }
                */

                double monthlyRate = rate / 1200;
                double paymentAmount = (monthlyRate * balance) / (1 - Math.Pow(1 + monthlyRate, termInMonths * -1));


                Console.WriteLine($"You requested a {balance,1:C} loan,");
                Console.WriteLine($"To pay with an interest rate of {rate}%,");
                Console.WriteLine($"Over the span of {termInYears} years({termInMonths} months),");
                //Console.WriteLine($"And you want to pay an extra {yearlyInvestment,1:C} every year.");
                Console.WriteLine($"Your monthly payment is {paymentAmount,1:C2}");

                Console.WriteLine("If this is correct, press any key to continue, otherwise try again.");
                Console.ReadKey();
                Console.Clear();

                double[] amount = new double[termInMonths];
                double[] interest = new double[termInMonths];
                double[] balancePaid = new double[termInMonths];
                double[] balanceRemaining = new double[termInMonths];
                int[] j = new int[termInMonths];

                for (int i = 0; i < termInMonths; i++)
                {
                    if (balanceRemaining[i] - paymentAmount < 0)
                    {
                        balanceRemaining[i] = paymentAmount;
                    }
                    amount[i] = paymentAmount;//(monthlyRate * balance) / (1 - Math.Pow(1 + monthlyRate, termInMonths * -1));
                    interest[i] = balance * monthlyRate;
                    balancePaid[i] = amount[i] - interest[i];
                    balanceRemaining[i] = balance - balancePaid[i];
                    balance = balanceRemaining[i];
                    j[i] = i;

                 // Console.WriteLine($"{j[i],7}{amount[i],8:c2}{interest[i],10:c2}{balancePaid[i],11:C2}{balanceRemaining[i],12:c2}");
                }


                Console.WriteLine($"Amortization Schedule");
                Console.WriteLine($"{"Payment",7}{"Amount",8}{"Interest",10}{"Principal",11}{"Balance",11}");

                Console.WriteLine($"{j[0],7}{amount[0],8:c2}{interest[0],10:c2}{balancePaid[0],11:C2}{balanceRemaining[0],12:c2}");
                Console.WriteLine($"{j[1],7}{amount[1],8:c2}{interest[1],10:c2}{balancePaid[1],11:C2}{balanceRemaining[1],12:c2}");
                Console.WriteLine($"{j[2],7}{amount[2],8:c2}{interest[2],10:c2}{balancePaid[2],11:C2}{balanceRemaining[2],12:c2}");
                Console.WriteLine($"{j[3],7}{amount[3],8:c2}{interest[3],10:c2}{balancePaid[3],11:C2}{balanceRemaining[3],12:c2}");
                Console.WriteLine($"{j[4],7}{amount[4],8:c2}{interest[4],10:c2}{balancePaid[4],11:C2}{balanceRemaining[4],12:c2}");

                Console.WriteLine($"...");

                Console.WriteLine($"{j[j.Length - 5]+1,7}{amount[amount.Length - 5],8:c2}{interest[interest.Length - 5],10:c2}{balancePaid[balancePaid.Length - 5],11:C2}{balanceRemaining[balanceRemaining.Length - 5],12:c2}");
                Console.WriteLine($"{j[j.Length - 4]+1,7}{amount[amount.Length - 4],8:c2}{interest[interest.Length - 4],10:c2}{balancePaid[balancePaid.Length - 4],11:C2}{balanceRemaining[balanceRemaining.Length - 4],12:c2}");
                Console.WriteLine($"{j[j.Length - 3]+1,7}{amount[amount.Length - 3],8:c2}{interest[interest.Length - 3],10:c2}{balancePaid[balancePaid.Length - 3],11:C2}{balanceRemaining[balanceRemaining.Length - 3],12:c2}");
                Console.WriteLine($"{j[j.Length - 2]+1,7}{amount[amount.Length - 2],8:c2}{interest[interest.Length - 2],10:c2}{balancePaid[balancePaid.Length - 2],11:C2}{balanceRemaining[balanceRemaining.Length - 2],12:c2}");
                Console.WriteLine($"{j[j.Length - 1]+1,7}{amount[amount.Length - 1],8:c2}{interest[interest.Length - 1],10:c2}{balancePaid[balancePaid.Length - 1],11:C2}{balanceRemaining[balanceRemaining.Length - 1],12:c2}");

            }


        }
    }
}
