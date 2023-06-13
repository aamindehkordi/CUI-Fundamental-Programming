using System;
using System.IO;

namespace Fantasy_Football_Geeks___2
{
    class FootballGameStats
    {
        public int numberOfPasses;
        public int numberOfCompletions;
        public int yardsThrown;
        public int touchdowns;
    }

    class FootballPlayer
    {
        public static readonly int MaxGames = 5;
        public string Name;
        public string Team;

        private int gamesPlayed;
        private FootballGameStats[] gameStats;

        private int totalYards;
        private int totalComp;//completions
        private double compAverage;

        public FootballPlayer(string name, string team)
        {
            Name = name;
            Team = team;
            gamesPlayed = 0;
            gameStats = new FootballGameStats[MaxGames];
            totalYards = 0;
            totalComp = 0;
            compAverage = 0;
        }

        public void AddGame(int pAtt, int pComp, int yards, int touchdowns)
        {
            gameStats[gamesPlayed] = new FootballGameStats();
            gameStats[gamesPlayed].numberOfPasses = pAtt;
            gameStats[gamesPlayed].numberOfCompletions = pComp;
            gameStats[gamesPlayed].yardsThrown = yards;
            gameStats[gamesPlayed].touchdowns = touchdowns;
            gamesPlayed++;

            totalYards += pAtt;
            totalComp += pComp;
            compAverage = (double)totalYards / totalComp;
        }

        public int TotalYards { get { return totalYards; } }
        public int Touchdowns { get { return Touchdowns; } }
        public int Completions { get { return totalComp; } }
        public double CompletionAverage { get { return compAverage; } }
        public int GamesPlayed { get { return gamesPlayed; } }
        public FootballGameStats[] GameStats { get { return gameStats; } }
    }

    class Program
    {
        /* function printTable written by Daniel Menche */
        static void printTable(string[] headerItems, FootballPlayer[] items, int fieldLength = 20)
        {
            /* values \x2501, \x2503, and \x254B are Unicode box drawing characters */

            /* pad all header values to be exactly fieldLength chars in length */
            for (uint i = 0; i < headerItems.Length; i++)
            {
                headerItems[i] = headerItems[i].PadRight(fieldLength);
            }

            /* allow vertical lines to pass through the horizontal line */
            string horizontalLineFragment = "";
            horizontalLineFragment = horizontalLineFragment.PadRight(fieldLength, '\x2501');
            string[] horizontalLine = { horizontalLineFragment, horizontalLineFragment, horizontalLineFragment, horizontalLineFragment };

            /* reverse foreground/background colors for the header */
            ConsoleColor[] colors = { Console.ForegroundColor, Console.BackgroundColor };
            Console.ForegroundColor = colors[1];
            Console.BackgroundColor = colors[0];
            Console.Write(String.Join("\x2503", headerItems));

            Console.ResetColor();
            Console.WriteLine();

            for (uint i = 0; i < items.Length; i++)
            {

                string[] fields = new string[4];

                /* convert any numbers to strings, and pad all strings to fieldLength chars */
                fields[0] = items[i].Name.PadRight(fieldLength);
                fields[1] = items[i].Team.PadRight(fieldLength);
                fields[2] = items[i].GamesPlayed.ToString().PadRight(fieldLength);
                fields[3] = items[i].CompletionAverage.ToString().PadRight(fieldLength);

                Console.WriteLine(String.Join("\x254B", horizontalLine));
                Console.WriteLine(String.Join("\x2503", fields));
            }
        }

        static void Main(string[] args)
        {
            int j = 0;
            int i = 0;
            string[] all;
            string[] playerName = new string[16];
            string[] teamName = new string[16];

            string[] gameStats = new string[16];
            int[] numberOfPasses = new int[16];
            int[] numberOfCompletions = new int[16];
            int[] yardsThrown = new int[16];
            int[] touchdowns = new int[16];



            StreamReader sr = new StreamReader("ffg.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                all = line.Split('|');
                playerName[i] = all[j];
                teamName[i] = all[j + 1];
                gameStats = (all[j + 2]).Split(':');
                numberOfCompletions[i] = int.Parse(gameStats[j]);
                numberOfPasses[i] = int.Parse(gameStats[j + 1]);
                yardsThrown[i] = int.Parse(gameStats[j + 2]);
                touchdowns[i] = int.Parse(gameStats[j + 3]);
                i++;
            }
            sr.Close();

            FootballPlayer p1 = new FootballPlayer(playerName[0], teamName[0]); p1.AddGame(numberOfPasses[0], numberOfCompletions[0], yardsThrown[0], touchdowns[0]);
            FootballPlayer p2 = new FootballPlayer(playerName[1], teamName[1]); p2.AddGame(numberOfPasses[1], numberOfCompletions[1], yardsThrown[1], touchdowns[1]);
            FootballPlayer p3 = new FootballPlayer(playerName[2], teamName[2]); p3.AddGame(numberOfPasses[2], numberOfCompletions[2], yardsThrown[2], touchdowns[2]);
            FootballPlayer p4 = new FootballPlayer(playerName[3], teamName[3]); p4.AddGame(numberOfPasses[3], numberOfCompletions[3], yardsThrown[3], touchdowns[3]);
            FootballPlayer p5 = new FootballPlayer(playerName[4], teamName[4]); p5.AddGame(numberOfPasses[4], numberOfCompletions[4], yardsThrown[4], touchdowns[4]);
            FootballPlayer p6 = new FootballPlayer(playerName[5], teamName[5]); p6.AddGame(numberOfPasses[5], numberOfCompletions[5], yardsThrown[5], touchdowns[5]);
            FootballPlayer p7 = new FootballPlayer(playerName[6], teamName[6]); p7.AddGame(numberOfPasses[6], numberOfCompletions[6], yardsThrown[6], touchdowns[6]);
            FootballPlayer p8 = new FootballPlayer(playerName[7], teamName[7]); p8.AddGame(numberOfPasses[7], numberOfCompletions[7], yardsThrown[7], touchdowns[7]);
            FootballPlayer p9 = new FootballPlayer(playerName[8], teamName[8]); p9.AddGame(numberOfPasses[8], numberOfCompletions[8], yardsThrown[8], touchdowns[8]);
            FootballPlayer p10 = new FootballPlayer(playerName[9], teamName[9]); p10.AddGame(numberOfPasses[9], numberOfCompletions[9], yardsThrown[9], touchdowns[9]);
            FootballPlayer p11 = new FootballPlayer(playerName[10], teamName[10]); p11.AddGame(numberOfPasses[10], numberOfCompletions[10], yardsThrown[10], touchdowns[10]);
            FootballPlayer p12 = new FootballPlayer(playerName[11], teamName[11]); p12.AddGame(numberOfPasses[11], numberOfCompletions[11], yardsThrown[11], touchdowns[11]);
            FootballPlayer p13 = new FootballPlayer(playerName[12], teamName[12]); p13.AddGame(numberOfPasses[12], numberOfCompletions[12], yardsThrown[12], touchdowns[12]);
            FootballPlayer p14 = new FootballPlayer(playerName[13], teamName[13]); p14.AddGame(numberOfPasses[13], numberOfCompletions[13], yardsThrown[13], touchdowns[13]);
            FootballPlayer p15 = new FootballPlayer(playerName[14], teamName[14]); p15.AddGame(numberOfPasses[14], numberOfCompletions[14], yardsThrown[14], touchdowns[14]);
            FootballPlayer p16 = new FootballPlayer(playerName[15], teamName[15]); p16.AddGame(numberOfPasses[15], numberOfCompletions[15], yardsThrown[15], touchdowns[15]);

            /*
            Console.WriteLine($"Name            Team              Total Yards   Touchdowns    Avg");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("__________________________________________________________________");
            //Console.WriteLine($"{p1.Name} | {p1.Team} | {p1.TotalYards}  | {p1.Touchdowns}  | {p1.CompletionAverage:N3}");
            Console.WriteLine($"{p2.Name} | {p2.Team} | {p2.GamesPlayed} | {p2.CompletionAverage:N3}");
            Console.WriteLine($"{p3.Name} | {p3.Team} | {p3.GamesPlayed} | {p3.CompletionAverage:N3}");
            Console.WriteLine($"{p4.Name} | {p4.Team} | {p4.GamesPlayed} | {p4.CompletionAverage:N3}");
            Console.WriteLine($"{p5.Name} | {p5.Team} | {p5.GamesPlayed} | {p5.CompletionAverage:N3}");
            Console.WriteLine($"{p6.Name} | {p6.Team} | {p6.GamesPlayed} | {p6.CompletionAverage:N3}");
            Console.WriteLine($"{p7.Name} | {p7.Team} | {p7.GamesPlayed} | {p7.CompletionAverage:N3}");
            Console.WriteLine($"{p8.Name} | {p8.Team} | {p8.GamesPlayed} | {p8.CompletionAverage:N3}");
            Console.WriteLine($"{p9.Name} | {p9.Team} | {p9.GamesPlayed} | {p9.CompletionAverage:N3}");
            Console.WriteLine($"{p10.Name}| {p10.Team}| {p10.GamesPlayed}| {p10.CompletionAverage:N3}");
            Console.WriteLine($"{p11.Name}| {p11.Team}| {p11.GamesPlayed}| {p11.CompletionAverage:N3}");
            Console.WriteLine($"{p12.Name}| {p12.Team}| {p12.GamesPlayed}| {p12.CompletionAverage:N3}");
            Console.WriteLine($"{p13.Name}| {p13.Team}| {p13.GamesPlayed}| {p13.CompletionAverage:N3}");
            Console.WriteLine($"{p14.Name}| {p14.Team}| {p14.GamesPlayed}| {p14.CompletionAverage:N3}");
            Console.WriteLine($"{p15.Name}| {p15.Team}| {p15.GamesPlayed}| {p15.CompletionAverage:N3}");
            Console.WriteLine($"{p16.Name}| {p16.Team}| {p16.GamesPlayed}| {p16.CompletionAverage:N3}");
			*/

            FootballPlayer[] results = { p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16 };
            string[] headers = { "Name", "Team", "Games", "Completion" };
            printTable(headers, results);
        }
    }
}