# Battleship Project

This project is part of the 'CUI-Fundamental-Programming' course. The task was to create a Battleship agent named Frank Sinatra. The agent is designed to play the game of Battleship, making decisions about where to place ships and where to attack based on the current state of the game.

The agent keeps track of its attack history and the shots it has fired. It also keeps track of the neighboring grid squares of the last shot it took. When a ship is hit, the agent updates the neighbors of the last shot. The agent also positions the fleet of ships on the game board.

The agent's code is written in C# and is object-oriented. The agent class, `FrankSinatra`, inherits from the `BattleshipAgent` class. The `FrankSinatra` class has several methods that override the methods in the `BattleshipAgent` class, such as `LaunchAttack()`, `DamageReport()`, and `PositionFleet()`.

## Key Features

- **Attack Strategy:** The agent attacks the neighboring squares of the last shot if there are still neighboring squares to attack. If all neighboring squares have been attacked, it chooses a random unattacked square.
- **Damage Report:** When a ship is hit, the agent updates the neighbors of the last shot and keeps track of the number of hits for each ship type.
- **Fleet Positioning:** The agent positions the fleet of ships on the game board randomly.

## Potential Improvements

While the agent has a basic strategy for playing Battleship, there are several potential improvements that could be made:

- **Improved Attack Strategy:** The agent could use a more sophisticated strategy for choosing where to attack, such as targeting the areas around a hit more systematically.
- **Adaptive Fleet Positioning:** The agent could adapt its fleet positioning strategy based on the opponent's attack patterns in previous games.
- **Learning from Past Games:** The agent could learn from past games to improve its strategy, for example by recognizing patterns in the opponent's fleet positioning or attack strategy.
