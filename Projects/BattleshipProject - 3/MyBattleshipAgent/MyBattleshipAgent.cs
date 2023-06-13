using System;

namespace Battleship
{
    public class FrankSinatra : BattleshipAgent
    {
        char[,] attackHistory;
        bool[,] shots;
        GridSquare attackGrid;

        int lastX;
        int lastY;

        int numOfNeighbors;
        int neighborIndex;
        int[] neighborX;
        int[] neighborY;

        int bHits;
        int cHits;
        int dHits;
        int sHits;
        int pHits;


        public FrankSinatra()
        {
            shots = new bool[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j<10; j++)
                {
                    shots[i, j] = false;
                }
            }
            attackHistory = new char[10, 10];
            attackGrid = new GridSquare();
            shots = new bool[10, 10];

            neighborX = new int[100];
            neighborY = new int[100];
            numOfNeighbors = 0;
            neighborIndex = 0;

            bHits = 4;
            cHits = 5;
            dHits = 3;
            sHits = 3;
            pHits = 2;
        }

        public override string ToString()
        {
            return $"Battleship Agent '{GetNickname()}'";
        }

        public override string GetNickname()
        {
            return "Franc";
        }

        public override void SetOpponent(string opponent)
        {
            return;
        }

        public bool IsValidCoords(int x, int y)
        {
            return (x > -1 && x < 10 && y > -1 && y < 10 && !shots[x, y]);
        }
        public override GridSquare LaunchAttack()
        {
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

            Random temp = new Random(); int x = temp.Next(10); int y = temp.Next(10);
            while(shots[x,y] == true) {
                x = temp.Next(10);
                y = temp.Next(10);
            }

            attackGrid.x = x; lastX = x;
            attackGrid.y = y; lastY = y;
            shots[x, y] = true;
            return attackGrid;
        }

        public void UpdateNeighbors()
        {
            if (IsValidCoords(lastX + 1, lastY))
            {
                neighborX[numOfNeighbors] = lastX + 1;
                neighborY[numOfNeighbors] = lastY;
                numOfNeighbors++;
            }
            if (IsValidCoords(lastX - 1, lastY))
            {
                neighborX[numOfNeighbors] = lastX -1;
                neighborY[numOfNeighbors] = lastY;
                numOfNeighbors++;
            }
            if (IsValidCoords(lastX, lastY + 1))
            {
                neighborX[numOfNeighbors] = lastX;
                neighborY[numOfNeighbors] = lastY + 1;
                numOfNeighbors++;
            }
            if (IsValidCoords(lastX, lastY - 1))
            {
                neighborX[numOfNeighbors] = lastX;
                neighborY[numOfNeighbors] = lastY -1;
                numOfNeighbors++;
            }
        }

        public override void DamageReport(char report)
        {

            if (report != ShipType.None)
            {
                UpdateNeighbors();
                if (report == ShipType.Carrier)
                {
                    if (cHits == 5)
                    {
                        // first hit against carrier, do any initialization
                    }
                    cHits--;
                    if (cHits == 0)
                    {
                        // last hit against carrier, do any cleanup
                        neighborIndex = numOfNeighbors;
                    }
                }
                if (report == ShipType.Battleship)
                {
                    if (bHits == 5)
                    {
                        // first hit against carrier, do any initialization
                    }
                    bHits--;
                    if (bHits == 0)
                    {
                        // last hit against carrier, do any cleanup
                        neighborIndex = numOfNeighbors;
                    }
                }
                if (report == ShipType.Destroyer)
                {
                    if (dHits == 5)
                    {
                        // first hit against carrier, do any initialization
                    }
                    dHits--;
                    if (dHits == 0)
                    {
                        // last hit against carrier, do any cleanup
                        neighborIndex = numOfNeighbors;
                    }
                }
                if (report == ShipType.Submarine)
                {
                    if (sHits == 5)
                    {
                        // first hit against carrier, do any initialization
                    }
                    sHits--;
                    if (sHits == 0)
                    {
                        // last hit against carrier, do any cleanup
                        neighborIndex = numOfNeighbors;
                    }
                }
                if (report == ShipType.PatrolBoat)
                {
                    if (pHits == 5)
                    {
                        // first hit against carrier, do any initialization
                    }
                    pHits--;
                    if (pHits == 0)
                    {
                        // last hit against carrier, do any cleanup
                        neighborIndex = numOfNeighbors;
                    }
                }
            }
        }

        public override BattleshipFleet PositionFleet()
        {
            BattleshipFleet myFleet = new BattleshipFleet();
            DateTime now = DateTime.Now;
            int time = now.Millisecond;
            Random myRand = new Random(time);
            

            myFleet.Carrier = new ShipPosition(myRand.Next(5),myRand.Next(1), ShipRotation.Vertical);
            myFleet.Battleship = new ShipPosition(6, myRand.Next(7, 9), ShipRotation.Horizontal);
            myFleet.Destroyer = new ShipPosition(myRand.Next(1, 3), 7, ShipRotation.Vertical);
            myFleet.Submarine = new ShipPosition(6, myRand.Next(0, 2), ShipRotation.Horizontal);
            myFleet.PatrolBoat = new ShipPosition(myRand.Next(6, 9), myRand.Next(3, 5), ShipRotation.Vertical);

            return myFleet;
        }
    }
}
