using System;


namespace SalesTax
{
    class SalesTax3
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
            if (taxRate < 0 || taxRate > 50) {
                return -1;
            }

            double salesTax = subtotal * taxRate / 100;

            return subtotal + salesTax;
        }


        static void Main()
        {
            // We live in Bakersfield and went on vacation to the beach San Diego
            // Before leaving, we bought a beach towel at the Bakerfield Target
            // On the way, we realized that we had forgotten paper plates, so we stopped at a Stater Brothers in LA
            // We arrived, and promptly ran out of sunscreen, so we went to Dave's Beach Bargains to buy some

            double priceTowel = 12.00;
            double pricePlates = 4.00;
            double priceSunScreen = 15.00;

            double total = TotalWithSalesTax(priceTowel, CaliforniaSalesTax.KernCounty) +
                           TotalWithSalesTax(pricePlates, CaliforniaSalesTax.LosAngelesCounty) +
                           TotalWithSalesTax(priceSunScreen, CaliforniaSalesTax.SanDiegoCounty);

            Console.WriteLine($"The total price on your three items is {total:C}\n");
        }       
    }
}
