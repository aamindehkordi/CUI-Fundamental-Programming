using System;

namespace ButWhatIf
{
    class Program
    {
        static void Main()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("May I be so bold as to inquire about your age? ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 65) // change from a series of if-else statements to a series of if statements
            {
                Console.WriteLine($"Welcome {name} you are old enough to recieve senior discounts.");
            }
            else if (age >= 35)
            {
                Console.WriteLine($"Welcome {name} you are old enough to run for president of the USA.");
            }
            else if (age >= 25)
            {
                Console.WriteLine($"Welcome {name} you are old enough to rent a car without restrictions.");
            }
            else if (age >= 21)
            {
                Console.WriteLine($"Welcome {name} you are old enough to legally drink alcohol.");
            }
            else if (age >= 18)
            {
                Console.WriteLine($"Welcome {name} you are considered an adult and are old enough to vote.");
            }
            else if (age >= 16)
            {
                Console.WriteLine($"Welcome {name} you are old enough to drive legally.");
            }
        }
    }
}
