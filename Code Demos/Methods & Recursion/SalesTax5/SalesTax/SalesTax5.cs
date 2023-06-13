using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    class SalesTax5
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



        static double TotalWithSalesTax(double subtotal, double taxRate=CaliforniaSalesTax.OrangeCounty)
        {
            if (taxRate < 0 || taxRate > 50) {
                return -1;
            }

            double salesTax = subtotal * taxRate / 100;

            return salesTax + subtotal;
        }



        static void Main()
        {
            // If we provide a default parameter, then we don't necessarily need to pass a parameter
            // Use default parameters when there is one parameter value that is much more common than all the other possibilities

            //double total = TotalWithSalesTax(100, CaliforniaSalesTax.OrangeCounty);
            double total = TotalWithSalesTax(100);

            Console.WriteLine($"The total price will be {total:C}\n");

        }       
    }
}
