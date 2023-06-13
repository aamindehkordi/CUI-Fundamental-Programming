using System;

namespace RedirectStdout
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is some text to the stdout");

            System.IO.TextWriter fileOut = System.IO.File.CreateText("redirect.txt");
            Console.SetOut(fileOut);
            Console.WriteLine("Here is some text for the file");
            fileOut.Close();

            System.IO.StreamWriter stdout = new System.IO.StreamWriter(Console.OpenStandardOutput());
            stdout.AutoFlush = true;
            Console.SetOut(stdout);

            Console.WriteLine("And now we've restored stdout");
        }
    }
}
