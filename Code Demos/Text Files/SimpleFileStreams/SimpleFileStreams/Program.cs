using System;
using System.IO;

namespace SimpleReadTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            StreamReader sr = new StreamReader("HelloFundamentals.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
                count++;
            }
            sr.Close();



            /***************************************************************/



            string line1 = "When we were utterly helpless, Christ came at just the right time and died for us sinners.";
            string line2 = "Now, most people would not be willing to die for an upright person, though someone might perhaps be willing to die for a person who is especially good.";
            string line3 = "But God showed his great love for us by sending Christ to die for us while we were still sinners.";

            bool append = false;
            StreamWriter sw = new StreamWriter("Romans5_8.txt", append);
            sw.WriteLine(line1);
            sw.WriteLine(line2);
            sw.WriteLine(line3);
            sw.Close();
        }
    }
}
