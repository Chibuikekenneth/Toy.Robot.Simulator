﻿namespace Toy.Robot.Simulator.Library
{
    /// <summary>
    /// This class contains helper messages used by the robot
    /// </summary>
    public class Message
    {
        public const string NOT_PLACED = "Invalid command: Please ensure to use the PLACE command, and in the following format: PLACE X,Y,DIRECTION";
        public const string OUT_OF_BOUND = "Invalid Command: Robot is out of Bound";
        public const string COMMAND_NOT_RECOGNISED = "Invalid command: Robot does not understand this command";
        public const string INVALID_DIRECTION = "Invalid direction: Please select from one of the following directions: NORTH|EAST|SOUTH|WEST";
        public const string VALID_COMMAND = "Invalid command:  \nValid commands are:\n PLACE X,Y,DIRECTION\n MOVE\n LEFT\n RIGHT\n PLACE X,Y\n REPORT";
    }
}
