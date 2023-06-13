using System;


namespace Baseball
{
    class BaseballGameStats
    {
        public int numberAtBats;
        public int numberOfHits;
        public int runsScored;
        public int strikeouts;
    }

    class BaseballPlayer
    {
        public static readonly int MaxGames = 162;
        public string Name;
        public string Team;

        private int gamesPlayed;
        private BaseballGameStats[] gameStats; 
        
        private int totalBats;
        private int totalHits;
        private double battingAverage;

        public BaseballPlayer(string name, string team)
        {
            Name = name;
            Team = team;
            gamesPlayed = 0;
            gameStats = new BaseballGameStats[MaxGames];
            totalBats = 0;
            totalHits = 0;
            battingAverage = 0;
        }

        public void AddGame(int atBats, int hits, int runs, int strikeouts)
        {
            gameStats[gamesPlayed] = new BaseballGameStats();
            gameStats[gamesPlayed].numberAtBats = atBats;
            gameStats[gamesPlayed].numberOfHits = hits;
            gameStats[gamesPlayed].runsScored = runs;
            gameStats[gamesPlayed].strikeouts = strikeouts;
            gamesPlayed++;

            totalBats += atBats;
            totalHits += hits;
            battingAverage = (double)totalHits / totalBats;
        }

        public int TotalBats { get { return totalBats; } }
        public int TotalHits { get { return totalHits; } }
        public double BattingAverage { get { return battingAverage; } }
        public int GamesPlayed { get { return gamesPlayed; } }
        public BaseballGameStats[] GameStats { get { return gameStats; } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseballPlayer p1 = new BaseballPlayer("Howie Kendrick", "Washington Nationals");
            p1.AddGame(4, 2, 1, 0);
            p1.AddGame(4, 0, 0, 2);
            p1.AddGame(4, 3, 2, 1);
            p1.AddGame(3, 0, 0, 1);
            Console.WriteLine($"Name            Team                  G Avg");
            Console.WriteLine($"{p1.Name}  {p1.Team}  {p1.GamesPlayed} {p1.BattingAverage:N3}");
        }
    }
}
