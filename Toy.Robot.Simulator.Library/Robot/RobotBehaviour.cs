
using System;

namespace Toy.Robot.Simulator.Library
{
    /// <summary>
    /// This class contains actions and behaviours performed by the robot
    /// </summary>
    public class RobotBehaviour
    {
        public string direction;
        public bool Placed = false;
        TableTop tableTop = new TableTop();

        //MOVE will move the toy robot one unit forward in the direction it is currently facing.
        public string Move()
        {
            string result = string.Empty;

            int XOriginalPosition = tableTop.X_Position;
            int YOriginalPosition = tableTop.Y_Position;


            switch (direction)
            {
                case Direction.NORTH:
                    tableTop.Y_Position++; break;
                case Direction.WEST:
                    tableTop.X_Position--; break;
                case Direction.SOUTH:
                    tableTop.Y_Position--; break;
                case Direction.EAST:
                    tableTop.X_Position++; break;
            }

            if(!tableTop.CheckPositionValidation())
            {
                tableTop.X_Position = XOriginalPosition;
                tableTop.Y_Position = YOriginalPosition;
                result = Message.OUT_OF_BOUND;
            }

            return result;
        }


        //LEFT will rotate the robot 90 degrees in the specified direction without changing the position of the robot.
        public void Left()
        {
            switch (direction)
            {
                case Direction.NORTH:
                    direction = Direction.WEST; break;
                case Direction.WEST:
                    direction = Direction.SOUTH; break;
                case Direction.SOUTH:
                    direction = Direction.EAST; break;
                case Direction.EAST:
                    direction = Direction.NORTH; break;
            }
        }


        //RIGHT will rotate the robot 90 degrees in the specified direction without changing the position of the robot.
        public void Right()
        {
            switch (direction)
            {
                case Direction.NORTH:
                    direction = Direction.EAST; break;
                case Direction.WEST:
                    direction = Direction.NORTH; break;
                case Direction.SOUTH:
                    direction = Direction.WEST; break;
                case Direction.EAST:
                    direction = Direction.SOUTH; break;
            }
        }


        //GETREPORT will announce the X,Y and orientation of the robot.
        public string GetReport()
        {
            return string.Format(tableTop.X_Position + "," + tableTop.Y_Position + "," + direction.ToUpper());
        }


        //PLACE will put the toy robot on the table in position X,Y and facing NORTH, SOUTH, EAST or WEST.
        public string Place(string command)
        {
            string result = string.Empty;
            char[] PositionChars = { ',', ' ' };

            string[] wordsInCommand = command.Split(PositionChars);

            tableTop.X_Position = Int32.Parse(wordsInCommand[1]);
            tableTop.Y_Position = Int32.Parse(wordsInCommand[2]);  

            if(wordsInCommand.Length == 3 && Placed == true)
            {
                PlacedWithoutDirection(command, direction);
            }
            else 
                direction = wordsInCommand[3];

            if (!tableTop.CheckPositionValidation())
            {
                result = Message.OUT_OF_BOUND;
            }
            else
                Placed = true;

            return result;
        }

        //This method is only invoked when the Robot has been placed initially and when a direction is not specified by the Robot
        public void PlacedWithoutDirection(string command, string PlacedDirection)
        {
            char[] PositionChars2 = { ',', ' ' };
            string[] wordsInCommand2 = command.Split(PositionChars2);
            tableTop.X_Position = Int32.Parse(wordsInCommand2[1]);
            tableTop.Y_Position = Int32.Parse(wordsInCommand2[2]);

            if (PlacedDirection != string.Empty)
            {
                direction = PlacedDirection;
            }
        }
    }
}
