using System;


namespace SalesTax
{
    class SalesTax1
    {
         static void Main()
        {
            // We live in Bakersfield and went on vacation to the beach San Diego
            // Before leaving, we bought a beach towel at the Bakerfield Target
            // On the way, we realized that we had forgotten paper plates, so we stopped at a Stater Brothers in LA
            // We arrived, and promptly ran out of sunscreen, so we went to Dave's Beach Bargains to buy some

            double priceTowel = 12.00;
            double kernCountyTax = 7.25;
            double subtotal1 = priceTowel + priceTowel * kernCountyTax / 100;

            double pricePlates    = 4.00;
            double losAngelesCountyTax = 9.5;
            double subtotal2 = pricePlates + pricePlates * losAngelesCountyTax / 100;

            double priceSunScreen = 15.00;
            double sanDiegoCountyTax = 7.75;
            double subtotal3 = priceSunScreen + priceSunScreen * sanDiegoCountyTax / 100;

            double total = subtotal1 + subtotal2 + subtotal3;

            Console.WriteLine($"The total price on your three items is {total:C}\n");
        }       
    }
}
