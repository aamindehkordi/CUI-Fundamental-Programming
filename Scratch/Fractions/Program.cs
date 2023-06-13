using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionDriver
{
    class Program
    {
        public static void Main(string[] args)
        {

            System.out.println("\f");
            Scanner myScan = new Scanner(System.in);
            System.out.print("Enter a Numerator: ");
            int num = Integer.parseInt(myScan.nextLine());
            System.out.println("Enter a Numerator: ");
            int denom = Integer.parseInt(myScan.nextLine());

            Fraction x = new Fraction(num, denom);
            System.out.println(x);

        }
    }
}
