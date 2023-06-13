using System;

namespace StartOfBible
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][][] bible = new string[66][][];
            bible[0] = new string[50][];
            bible[0][0] = new string[31];
            bible[0][0][0] = "In the beginning God created the heavens and the earth.";
            bible[0][0][1] = "Now the earth was formless and empty, darkness was over the surface of the deep, and the Spirit of God was hovering over the waters.";

            for(int b = 0; b < bible.Length; b++)
            {
                string[][] book = bible[b];
                for (int c = 0; c < book.Length; c++)
                {
                    string[] chapter = book[c];
                    Console.WriteLine($"Chapter {c+1}");
                    for(int v = 0; v < chapter.Length; v++)
                    {
                        string verse = chapter[v];
                        Console.WriteLine($"{v+1,2}: {verse}");

                        if (v == 2) { return; }
                    }
                }
            }
        }
    }
}
