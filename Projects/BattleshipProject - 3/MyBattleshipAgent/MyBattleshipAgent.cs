using System;

namespace Battleship
{
    /// <summary>
    /// Represents a Battleship agent named Frank Sinatra.
    /// </summary>
    public class FrankSinatra : BattleshipAgent
    {
        // 2D array to keep track of attack history
        char[,] attackHistory;

        // 2D array to keep track of shots fired
        bool[,] shots;

        // The current grid square to attack
        GridSquare attackGrid;

        // The last x and y coordinates of the attack grid
        int lastX;
        int lastY;

        // Arrays to keep track of neighboring grid squares
        int numOfNeighbors;
        int neighborIndex;
        int[] neighborX;
        int[] neighborY;

        // Number of hits for each ship type
        int bHits;
        int cHits;
        int dHits;
        int sHits;
        int pHits;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrankSinatra"/> class.
        /// </summary>
        public FrankSinatra()
        {
            // Initialize shots array to false
            shots = new bool[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    shots[i, j] = false;
                }
            }

            // Initialize attack history array to empty
            attackHistory = new char[10, 10];

            // Initialize attack grid to default
            attackGrid = new GridSquare();
            shots = new bool[10, 10];

            // Initialize neighboring grid square arrays
            neighborX = new int[100];
            neighborY = new int[100];
            numOfNeighbors = 0;
            neighborIndex = 0;

            // Initialize number of hits for each ship type
            bHits = 4;
            cHits = 5;
            dHits = 3;
            sHits = 3;
            pHits = 2;
        }

        /// <summary>
        /// Returns a string representation of the Battleship Agent.
        /// </summary>
        /// <returns>A string representation of the Battleship Agent.</returns>
        public override string ToString()
        {
            return $"Battleship Agent '{GetNickname()}'";
        }

        /// <summary>
        /// Returns the nickname of the Battleship Agent.
        /// </summary>
        /// <returns>The nickname of the Battleship Agent.</returns>
        public override string GetNickname()
        {
            return "Franc";
        }

        /// <summary>
        /// Sets the opponent of the Battleship Agent.
        /// </summary>
        /// <param name="opponent">The name of the opponent.</param>
        public override void SetOpponent(string opponent)
        {
            // This method does not need to do anything in this implementation.
            return;
        }

        /// <summary>
        /// Checks if the given coordinates are valid for the game board.
        /// </summary>
        /// <param name="x">The x-coordinate to check.</param>
        /// <param name="y">The y-coordinate to check.</param>
        /// <returns>True if the coordinates are valid and have not been shot at before, false otherwise.</returns>
        public bool IsValidCoords(int x, int y)
        {
            // Check if the coordinates are within the bounds of the game board and have not been shot at before.
            return (x > -1 && x < 10 && y > -1 && y < 10 && !shots[x, y]);
        }

        /// <summary>
        /// Launches an attack on the opponent's game board.
        /// </summary>
        /// <returns>The coordinates of the attack.</returns>
        public override GridSquare LaunchAttack()
        {
            // If there are still neighboring squares to attack, attack the next one.
            if (neighborIndex < numOfNeighbors)
            {
                attackGrid.x = neighborX[neighborIndex];
                attackGrid.y = neighborY[neighborIndex];
                shots[attackGrid.x, attackGrid.y] = true;
                lastX = attackGrid.x;
                lastY = attackGrid.y;
                neighborIndex++;
                return attackGrid;
            }

            // If all neighboring squares have been attacked, choose a random unattacked square.
            Random temp = new Random();
            int x = temp.Next(10);
            int y = temp.Next(10);
            while (shots[x, y] == true)
            {
                x = temp.Next(10);
                y = temp.Next(10);
            }

            // Attack the chosen square and return its coordinates.
            attackGrid.x = x;
            lastX = x;
            attackGrid.y = y;
            lastY = y;
            shots[x, y] = true;
            return attackGrid;
        }

        /// <summary>
        /// Updates the neighbors of the last shot taken by the agent.
        /// </summary>
        public void UpdateNeighbors()
        {
            // Check if the neighbor to the right is a valid coordinate
            if (IsValidCoords(lastX + 1, lastY))
            {
                neighborX[numOfNeighbors] = lastX + 1; // Add the x-coordinate of the neighbor to the array
                neighborY[numOfNeighbors] = lastY; // Add the y-coordinate of the neighbor to the array
                numOfNeighbors++; // Increment the number of neighbors
            }

            // Check if the neighbor to the left is a valid coordinate
            if (IsValidCoords(lastX - 1, lastY))
            {
                neighborX[numOfNeighbors] = lastX - 1; // Add the x-coordinate of the neighbor to the array
                neighborY[numOfNeighbors] = lastY; // Add the y-coordinate of the neighbor to the array
                numOfNeighbors++; // Increment the number of neighbors
            }

            // Check if the neighbor above is a valid coordinate
            if (IsValidCoords(lastX, lastY + 1))
            {
                neighborX[numOfNeighbors] = lastX; // Add the x-coordinate of the neighbor to the array
                neighborY[numOfNeighbors] = lastY + 1; // Add the y-coordinate of the neighbor to the array
                numOfNeighbors++; // Increment the number of neighbors
            }

            // Check if the neighbor below is a valid coordinate
            if (IsValidCoords(lastX, lastY - 1))
            {
                neighborX[numOfNeighbors] = lastX; // Add the x-coordinate of the neighbor to the array
                neighborY[numOfNeighbors] = lastY - 1; // Add the y-coordinate of the neighbor to the array
                numOfNeighbors++; // Increment the number of neighbors
            }
        }

        /// <summary>
        /// Reports damage to the agent's ships and updates neighbors.
        /// </summary>
        /// <param name="report">The type of ship that was hit.</param>
        public override void DamageReport(char report)
        {
            // If the report is not "None", update neighbors
            if (report != ShipType.None)
            {
                UpdateNeighbors();

                // If the report is a carrier
                if (report == ShipType.Carrier)
                {
                    // If this is the first hit against the carrier, do any initialization
                    if (cHits == 5)
                    {
                        // TODO: Add initialization code here
                    }

                    // Decrement the number of hits against the carrier
                    cHits--;

                    // If this is the last hit against the carrier, do any cleanup
                    if (cHits == 0)
                    {
                        // TODO: Add cleanup code here

                        // Reset the neighbor index
                        neighborIndex = numOfNeighbors;
                    }
                }

                // If the report is a battleship
                if (report == ShipType.Battleship)
                {
                    // If this is the first hit against the battleship, do any initialization
                    if (bHits == 5)
                    {
                        // TODO: Add initialization code here
                    }

                    // Decrement the number of hits against the battleship
                    bHits--;

                    // If this is the last hit against the battleship, do any cleanup
                    if (bHits == 0)
                    {
                        // TODO: Add cleanup code here

                        // Reset the neighbor index
                        neighborIndex = numOfNeighbors;
                    }
                }

                // If the report is a destroyer
                if (report == ShipType.Destroyer)
                {
                    // If this is the first hit against the destroyer, do any initialization
                    if (dHits == 5)
                    {
                        // TODO: Add initialization code here
                    }

                    // Decrement the number of hits against the destroyer
                    dHits--;

                    // If this is the last hit against the destroyer, do any cleanup
                    if (dHits == 0)
                    {
                        // TODO: Add cleanup code here

                        // Reset the neighbor index
                        neighborIndex = numOfNeighbors;
                    }
                }

                // If the report is a submarine
                if (report == ShipType.Submarine)
                {
                    // If this is the first hit against the submarine, do any initialization
                    if (sHits == 5)
                    {
                        // TODO: Add initialization code here
                    }

                    // Decrement the number of hits against the submarine
                    sHits--;

                    // If this is the last hit against the submarine, do any cleanup
                    if (sHits == 0)
                    {
                        // TODO: Add cleanup code here

                        // Reset the neighbor index
                        neighborIndex = numOfNeighbors;
                    }
                }

                // If the report is a patrol boat
                if (report == ShipType.PatrolBoat)
                {
                    // If this is the first hit against the patrol boat, do any initialization
                    if (pHits == 5)
                    {
                        // TODO: Add initialization code here
                    }

                    // Decrement the number of hits against the patrol boat
                    pHits--;

                    // If this is the last hit against the patrol boat, do any cleanup
                    if (pHits == 0)
                    {
                        // TODO: Add cleanup code here

                        // Reset the neighbor index
                        neighborIndex = numOfNeighbors;
                    }
                }
            }
        }

        /// <summary>
        /// Positions the fleet of ships on the game board.
        /// </summary>
        /// <returns>The BattleshipFleet object containing the positions of all the ships.</returns>
        public override BattleshipFleet PositionFleet()
        {
            // Create a new BattleshipFleet object.
            BattleshipFleet myFleet = new BattleshipFleet();

            // Get the current time in milliseconds.
            DateTime now = DateTime.Now;
            int time = now.Millisecond;

            // Create a new Random object with the current time as the seed.
            Random myRand = new Random(time);

            // Position the Carrier ship randomly on the game board.
            myFleet.Carrier = new ShipPosition(myRand.Next(5), myRand.Next(1), ShipRotation.Vertical);

            // Position the Battleship ship randomly on the game board.
            myFleet.Battleship = new ShipPosition(6, myRand.Next(7, 9), ShipRotation.Horizontal);

            // Position the Destroyer ship randomly on the game board.
            myFleet.Destroyer = new ShipPosition(myRand.Next(1, 3), 7, ShipRotation.Vertical);

            // Position the Submarine ship randomly on the game board.
            myFleet.Submarine = new ShipPosition(6, myRand.Next(0, 2), ShipRotation.Horizontal);

            // Position the PatrolBoat ship randomly on the game board.
            myFleet.PatrolBoat = new ShipPosition(myRand.Next(6, 9), myRand.Next(3, 5), ShipRotation.Vertical);

            // Return the BattleshipFleet object containing the positions of all the ships.
            return myFleet;
        }
    }
}
