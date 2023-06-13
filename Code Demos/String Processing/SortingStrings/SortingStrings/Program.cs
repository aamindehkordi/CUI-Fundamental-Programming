using System;

namespace SortingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringComparison myIgnoreCase = StringComparison.CurrentCultureIgnoreCase;


            Console.WriteLine("First we look at different ways to check for equality");
            // The == operator always checks case
            // The Equals() method can be configured to ignore case

            bool check1 = ("Dog" == "dog");
            Console.WriteLine($"\"Dog\" == \"dog\" is {check1}");

            bool check2 = ("Dog".ToLower() == "dog".ToLower());
            Console.WriteLine($"\"Dog\".ToLower() == \"dog\".ToLower() is {check2}");

            bool check3 = (string.Equals("Dog", "dog", myIgnoreCase));
            Console.WriteLine($"string.Equals(\"Dog\", \"dog\", myIgnoreCase) is {check3}");





            // Now let's look at lexicographical sorting
            Console.WriteLine("\nThis program will alphabetically sort two words/phrases");

            string[] words = new string[2];
            Console.Write($"Enter word/phrase 1: ");
            words[0] = Console.ReadLine();
            Console.Write($"Enter word/phrase 2: ");
            words[1] = Console.ReadLine();

            int result = string.Compare(words[0], words[1], myIgnoreCase);
            if (result == -1)     // words[0] < words[1] because result is -1
            {
                Console.WriteLine(words[0]);
                Console.WriteLine(words[1]);
            }
            else if (result == 1) // words[0] > words[1] becuase result is 1
            {
                Console.WriteLine(words[1]);
                Console.WriteLine(words[0]);
            }
            else if (result == 0) // words[0] == words[1] because result is 0
            {
                Console.WriteLine($"\"{words[0]}\" and \"{words[1]}\" are the same");
            }
        }
    }
}
