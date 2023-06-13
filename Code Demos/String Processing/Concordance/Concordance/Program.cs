using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concordance
{
    class Program
    {
        static string theBible = "Is there any encouragement from belonging to Christ? Any comfort from his love? Any fellowship together in the Spirit? Are your hearts tender and compassionate? Then make me truly happy by agreeing wholeheartedly with each other, loving one another, and working together with one mind and purpose.Don’t be selfish; don’t try to impress others.Be humble, thinking of others as better than yourselves.Don’t look out only for your own interests, but take an interest in others, too.You must have the same attitude that Christ Jesus had.Though he was God, he did not think of equality with God as something to cling to. Instead, he gave up his divine privileges; he took the humble position of a slave and was born as a human being.When he appeared in human form, he humbled himself in obedience to God and died a criminal’s death on a cross.Therefore, God elevated him to the place of highest honor and gave him the name above all other names, that at the name of Jesus every knee should bow, in heaven and on earth and under the earth, and every tongue declare that Jesus Christ is Lord, to the glory of God the Father.Dear friends, you always followed my instructions when I was with you.And now that I am away, it is even more important.Work hard to show the results of your salvation, obeying God with deep reverence and fear.For God is working in you, giving you the desire and the power to do what pleases him.Do everything without complaining and arguing, so that no one can criticize you.Live clean, innocent lives as children of God, shining like bright lights in a world full of crooked and perverse people. Hold firmly to the word of life; then, on the day of Christ’s return, I will be proud that I did not run the race in vain and that my work was not useless.But I will rejoice even if I lose my life, pouring it out like a liquid offering to God, just like your faithful service is an offering to God. And I want all of you to share that joy. Yes, you should rejoice, and I will share your joy.";


        static void Main(string[] args)
        {
            Console.Write("Enter a term to search for: ");
            string searchTerm = Console.ReadLine();

            // we don't want to worry about case when searching
            StringComparison ignoreCase = StringComparison.CurrentCultureIgnoreCase;

            // find the first occurence
            int refIndex = theBible.IndexOf(searchTerm, ignoreCase);
            if (refIndex < 0)
            {
                Console.WriteLine("Error: Text not found");
                return;
            }

            // extract context by taking -25 and +25 characters
            string passage = theBible.Substring(refIndex - 25, searchTerm.Length + 50);

            // find all occurences
            while (refIndex != -1)
            {
                passage = theBible.Substring(refIndex - 25, searchTerm.Length + 50);
                Console.WriteLine("..." + passage + "...");
                refIndex = theBible.IndexOf(searchTerm, refIndex + 1, ignoreCase);
            }

        }
    }
}
