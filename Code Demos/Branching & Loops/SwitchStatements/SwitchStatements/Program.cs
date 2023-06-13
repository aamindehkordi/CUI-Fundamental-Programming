using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main()
        {
            Console.Write("Type a day of the week (monday, tuesday, ...): ");
            string dayOfWeek = Console.ReadLine();
            
            switch(dayOfWeek.ToLower())
            {
                case "mon" + "day":
                case "wednesday":
                    Console.WriteLine("I can hardly wait, " +
                                      "tomorrow we get to see Prof Tallman!");
                    break;
                case "tuesday":            // cannot call ToLower() because the
                case "thursday": // string would no longer be a constant
                    Console.WriteLine("Yipee! today we have CSC 104!");
                    break;
                case "friday":
                    Console.WriteLine("TGIF");
                    return;
                case "saturday":
                case "sunday":
                    Console.WriteLine("Yay! it's the weekend, " +
                                      "extra time to work on CSC 104 projects");
                    break;
                default:
                    Console.WriteLine($"I don't think that \"{dayOfWeek}\" " +
                                       "means what you think it means");
                    break;
            }

            Console.WriteLine("Thank you all very much.");
        }
    }
}
