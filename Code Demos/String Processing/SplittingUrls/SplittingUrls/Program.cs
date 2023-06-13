using System;

namespace SplittingUrls
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] urls = {
                "http://www.google.com",
                "http://photos.app.goo.gl/Sj3ovJk35jsl",
                "http://www.espn.com/nfl/games/ravens_win.html"
            };

            foreach (string url in urls)
            {
                // Choose the forward-slash as the separator
                // Remove the empty entry between the two protocol slashes (http://) 
                char[] separators = { '/' };
                StringSplitOptions mySplitOptions = StringSplitOptions.RemoveEmptyEntries;

                // Choosing a max of 3 means the last entry may still have slashes in it
                string[] urlParts = url.Split(separators, 3, mySplitOptions);

                if (urlParts.Length == 0)
                {
                    Console.WriteLine("Error: invalid URL provided, skipping to next entry");
                    continue;
                }

                // We trim the colon off of the protocol (http:)
                Console.WriteLine($"protocol: {urlParts[0].TrimEnd(':')}");

                if (urlParts.Length > 1) {
                    Console.WriteLine($"server:   {urlParts[1]}");
                } else {
                    Console.WriteLine("server:   NONE");
                }

                if (urlParts.Length > 2) {
                    Console.WriteLine($"resource: {urlParts[2]}");
                } else {
                    Console.WriteLine("resource: NONE");
                }
                Console.WriteLine();
            }
        }
    }
}
