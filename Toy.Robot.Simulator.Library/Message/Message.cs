namespace Toy.Robot.Simulator.Library
{
    /// <summary>
    /// This class contains helper messages used by the robot
    /// </summary>
    public class Message
    {
        public const string NOT_PLACED = "Invalid command: Please ensure that the PLACE command is using format: PLACE X,Y,DIRECTION";
        public const string OUT_OF_BOUND = "Invalid Command: Robot is out of Bound";
        public const string COMMAND_NOT_RECOGNISED = "Invalid command: Robot dis not understand this command";
        public const string INVALID_DIRECTION = "Invalid direction: Please select from one of the following directions: NORTH|EAST|SOUTH|WEST";
        public const string VALID_COMMAND = "Invalid command:  \nValid commands are:\nPLACE X,Y,DIRECTION\nMOVE\nLEFT\nRIGHT\nREPORT";
    }
}
