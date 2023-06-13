using System;

namespace MessingAboutConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting input from the keyboard (type one key and then press ENTER)");
            char singleRead = (char)Console.Read();
            Console.WriteLine("You pressed " + singleRead + "!!");

            Console.WriteLine("Getting input from the keyboard (type one key and then press ENTER)");
            char readKey = Console.ReadKey().KeyChar;
            Console.WriteLine("\nYou pressed " + readKey + "!!");

            ConsoleColor saved = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine($"\nWhat color is this?");
            Console.WriteLine($"More pretty blue");

            Console.ForegroundColor = saved;    // we can just change the foreground color back
            Console.ResetColor();               // or we can completely reset the color scheme

            Console.WriteLine($"Back to white");
        }
    }
}
