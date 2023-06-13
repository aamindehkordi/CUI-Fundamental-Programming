using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_The_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            Random x = new Random();
            int myRand = x.Next(0, 100);
            
            for(int i = 1; i<6; i++)
            {      
                
                Console.Write("Guess the number, you will have 5 attempts [0-100]: ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == myRand)
                {
                    Console.WriteLine($"You got it right! The correct answer was {myRand}");
                    Console.WriteLine("Press any button to continue...");
                    Console.ReadKey();
                    return;
                }
                if(answer<myRand)
                {
                    Console.WriteLine("You have guessed less than the answer.");
                    Console.WriteLine("Press any button to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                if (answer > myRand)
                {
                    Console.WriteLine("You have guessed more than the answer.");
                    Console.WriteLine("Press any button to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }

            Console.WriteLine("You lose!");
            Console.WriteLine("Press any button to continue...");
            Console.ReadKey();
            return;

        }
    }
}
