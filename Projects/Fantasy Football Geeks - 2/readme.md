# Fantasy Football Geeks

This project is a simulation of a fantasy football game. The code is written in C# and consists of several classes that represent different aspects of the game, such as players and game statistics.

The `FootballPlayer` class represents a football player and contains properties such as the player's name, the team they belong to, the number of games they've played, and their game statistics. The game statistics are stored in an array of `FootballGameStats` objects, each of which represents the stats of a single game. The stats include the number of passes attempted, the number of passes completed, the number of yards thrown, and the number of touchdowns.

The `Program` class contains the `Main` method, which is the entry point of the program. It reads player data from a text file, creates `FootballPlayer` objects for each player, and adds their game stats. It then prints a table of the players' names, teams, number of games played, and completion averages.

The `printTable` function is used to print the table. It takes an array of header items and an array of `FootballPlayer` objects, and optionally a field length. It pads all header values and field values to be exactly the field length characters in length, and uses Unicode box drawing characters to draw the table.

The code demonstrates the use of classes, objects, arrays, and file I/O in C#.
