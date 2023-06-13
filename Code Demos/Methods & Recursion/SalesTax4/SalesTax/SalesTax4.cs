using System;


namespace SalesTax
{
    class SalesTax4
    {
        struct CaliforniaSalesTax
        {
            public const double LosAngelesCounty = 9.5;
            public const double KernCounty = 7.25;
            public const double OrangeCounty = 7.75;
            public const double RiversideCounty = 7.75;
            public const double SanBernardinoCounty = 7.75;
            public const double SanDiegoCounty = 7.75;
            public const double StanislausCounty = 8.375;
        };



        static double TotalWithSalesTax(double subtotal, double taxRate)
        {
            double salesTax = subtotal * taxRate / 100;

            // this line won't do anything because we've already calculated salesTax
            // but if you back at the caller's passed argument, you'll notice it hasn't chagned
            subtotal = 100000;

            return salesTax + subtotal;
        }


        // Overloaded version of the CalcualteSalesTax method that takes an array of prices
        static double TotalItemsWithSalesTax(double[] items, double taxRate)
        {
            double subtotal = 0;
            foreach (double item in items)
            {
                subtotal += item;
            }

            // this line won't do anything because we've already calculated salesTax
            // but if you back at the caller's passed argument, you'll notice it *HAS* chagned
            items[0] = 100000;

            double salesTax = subtotal * taxRate / 100;
            return salesTax + subtotal;
        }




        static void Main()
        {
            double priceTowel = 12.00;
            double pricePlates = 4.00;
            double priceSunScreen = 15.00;

            double total = TotalWithSalesTax(priceTowel, CaliforniaSalesTax.KernCounty) +
                           TotalWithSalesTax(pricePlates, CaliforniaSalesTax.LosAngelesCounty) +
                           TotalWithSalesTax(priceSunScreen, CaliforniaSalesTax.SanDiegoCounty);

            Console.WriteLine($"The total price on your three items is {total:C}\n");

            

            // This time, we buy five items right here in Irvine
            // We call a different function that allows us to price multiple items through an array

            double[] items = { 10, 20, 30, 40, 50 };

            Console.WriteLine($"Before passing by reference: {items[0]}");

            TotalItemsWithSalesTax(items, CaliforniaSalesTax.OrangeCounty);

            Console.WriteLine($"After passing by reference:  {items[0]}");
        }
    }
}
