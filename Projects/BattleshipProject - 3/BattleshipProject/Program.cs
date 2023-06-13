using System;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            BattleshipAgentWrapper myBattleshipAgent = new BattleshipAgentWrapper(new FrankSinatra(), false);
            BattleshipAgentWrapper myTestHumanAgent = new BattleshipAgentWrapper(new FrankSinatra(), true);

            BattleshipEngine gameEngine = new BattleshipEngine(myTestHumanAgent, myBattleshipAgent);
            gameEngine.PlaySingleGame(true, 500);

        }
    }
}
