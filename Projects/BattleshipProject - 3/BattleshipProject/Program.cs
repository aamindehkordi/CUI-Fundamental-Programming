using System;

namespace Battleship
{
    /// <summary>
    /// The main program class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The entry point of the program.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            // Create a new instance of the BattleshipAgentWrapper class with a FrankSinatra agent and a flag indicating that it's not a human player.
            BattleshipAgentWrapper myBattleshipAgent = new BattleshipAgentWrapper(new FrankSinatra(), false);

            // Create a new instance of the BattleshipAgentWrapper class with a FrankSinatra agent and a flag indicating that it's a human player.
            BattleshipAgentWrapper myTestHumanAgent = new BattleshipAgentWrapper(new FrankSinatra(), true);

            // Create a new instance of the BattleshipEngine class with the human player agent and the non-human player agent.
            BattleshipEngine gameEngine = new BattleshipEngine(myTestHumanAgent, myBattleshipAgent);

            // Play a single game with the human player going first, and a maximum of 500 turns.
            gameEngine.PlaySingleGame(true, 500);
        }
    }
}