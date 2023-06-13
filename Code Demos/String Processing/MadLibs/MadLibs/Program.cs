using System;


namespace MadLibs
{
    class Program
    {
        static void Main()
        {
            // Birds and bees question: Daddy, where do strings come from?


            // Answer 1: We can create them from hardcoded "literals"
            string welcomeMessage = "Welcome to MadLibs";
            Console.WriteLine(welcomeMessage);


            // Answer 2: Methods can create and return strings, like ReadLine()
            Console.Write("Place: ");
            string place = Console.ReadLine();


            // Note: Strings are objects, so they have built-in methods like ToLower()
            //       Most string methods return a new string that you assign to a variable
            //       Since string methods return strings, you can often chain them together
            Console.Write("Adjective: ");
            string adjective = Console.ReadLine().ToLower();


            // Note: Most string operations are case-sensitive, so you can either convert
            //       everything to the same case, e.g., if (name.ToLower() == "john") or
            //       you can tell some of the string functions to ignore case
            string article = "a";
            if (adjective.StartsWith("a", StringComparison.CurrentCultureIgnoreCase) ||
                adjective.StartsWith("e", StringComparison.CurrentCultureIgnoreCase) ||
                adjective.StartsWith("i", StringComparison.CurrentCultureIgnoreCase) ||
                adjective.StartsWith("o", StringComparison.CurrentCultureIgnoreCase) ||
                adjective.StartsWith("u", StringComparison.CurrentCultureIgnoreCase))
            {
                article = "an";
            }

            Console.Write("Verb: ");
            string verb = Console.ReadLine().ToUpper();



            // Answer 3: The last way to create strings is to concatenate them together
            //           or to use string interpolation
            string madLib = "Let me tell you a story about my great Uncle Lou. ";
            madLib += "One day he announced that we were going to visit " + place + ". ";
            madLib += $"You must understand, Uncle Lou has {article} {adjective} knee. " +
                $"My sisters and I decided we just couldn't {verb} with him in public. ";

            // Note: Most non-string data types can be converted to a string. To be used
            //       as a string, they must internally have a function called ToString()
            madLib += "So mom let us stay home and read " + 3 + " stories instead.";



            Console.Clear();
            Console.WriteLine(madLib);
        }
    }
}
