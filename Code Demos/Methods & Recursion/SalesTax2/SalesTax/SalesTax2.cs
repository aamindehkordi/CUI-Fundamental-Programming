using System;


namespace SalesTax
{
    class SalesTax2
    {
        static double TotalWithSalesTax(double subtotal, string locality)
        {
            double taxRate;

            switch(locality)
            {
                case "Los Angeles County":
                    taxRate = 9.5;
                    break;
                case "Kern County":
                    taxRate = 7.25;
                    break;
                case "Stanislaus County":
                    taxRate = 8.375;
                    break;
                case "Orange County":
                case "Riverside County":
                case "San Bernardino County":
                case "San Diego County":
                    taxRate = 7.75;
                    break;
                default:
                    taxRate = 7.75;
                    break;
            }

            double salesTax = subtotal * taxRate / 100;

            return salesTax + subtotal;
        }



        static void Main()
        {
            // We live in Bakersfield and went on vacation to the beach San Diego
            // Before leaving, we bought a beach towel at the Bakerfield Target
            // On the way, we realized that we had forgotten paper plates, so we stopped at a Stater Brothers in LA
            // We arrived, and promptly ran out of sunscreen, so we went to Dave's Beach Bargains to buy some

            double priceTowel = 12.00;
            double subtotal1 = TotalWithSalesTax(priceTowel, "Kern County");

            double pricePlates    = 4.00;
            double subtotal2 = TotalWithSalesTax(pricePlates, "Los Angeles County");

            double priceSunScreen = 15.00;
            double subtotal3 = TotalWithSalesTax(priceSunScreen, "San Diego County");

            double total = subtotal1 + subtotal2 + subtotal3;

            Console.WriteLine($"The total price on your three items is {total:C}\n");
        }       
    }
}
