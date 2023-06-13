using System;
using System.IO;

namespace Exception1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader("HelloFundamentals.txt");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                sr.Close();
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine($"Could not open the file \"{exception.FileName}\": " +
                                   "There's no point in continuing, so quitting gracefully :)");
            }
            catch (OutOfMemoryException exception)
            {
                Console.WriteLine($"Error reading the file: {exception.Message}");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
