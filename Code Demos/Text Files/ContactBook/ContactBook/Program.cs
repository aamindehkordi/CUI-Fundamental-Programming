using System;
using System.IO;

namespace SimpleReadTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while(input.ToLower() != "quit")
            {
                Console.Write("Search for contact: ");
                input = Console.ReadLine();

                LookupAndPrintContactFromFile(input);
            }
        }



        static void LookupAndPrintContactFromFile(string search)
        {
            StreamReader sr = new StreamReader("Contacts.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] fields = line.Split('|');
                if (fields.Length != 4)
                {
                    Console.WriteLine($"Error: {line}");
                    continue;
                }

                string name = fields[0];
                string office = fields[1];
                string phone = fields[2];
                string email = fields[3];

                if (name.ToLower().Contains(search.ToLower()))
                {
                    Console.WriteLine($"  {name}");
                    Console.WriteLine($"  {office}");
                    Console.WriteLine($"  {phone}");
                    Console.WriteLine($"  {email}");
                }
            }
            Console.WriteLine();
            sr.Close();
        }
    }
}
