using System;

namespace StartOfBible
{
    /// <summary>
    /// This class contains the main entry point for the application.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Define a 3D array to hold the Bible text
            string[][][] bible = new string[66][][];

            // Define the first book of the Bible
            bible[0] = new string[50][];
            bible[0][0] = new string[31];
            bible[0][0][0] = "In the beginning God created the heavens and the earth.";
            bible[0][0][1] = "Now the earth was formless and empty, darkness was over the surface of the deep, and the Spirit of God was hovering over the waters.";

            // Loop through each book of the Bible
            for (int b = 0; b < bible.Length; b++)
            {
                string[][] book = bible[b];

                // Loop through each chapter of the book
                for (int c = 0; c < book.Length; c++)
                {
                    string[] chapter = book[c];
                    Console.WriteLine($"Chapter {c + 1}");

                    // Loop through each verse of the chapter
                    for (int v = 0; v < chapter.Length; v++)
                    {
                        string verse = chapter[v];
                        Console.WriteLine($"{v + 1,2}: {verse}");

                        // Exit the program after printing the third verse
                        if (v == 2) { return; }
                    }
                }
            }
        }
    }
}