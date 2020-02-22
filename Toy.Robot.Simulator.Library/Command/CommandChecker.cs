using System;

namespace Toy.Robot.Simulator.Library.Command
{
    /// <summary>
    /// This class checks and validate all neccesary command to be used by the robot, and makes sure it performs all its actions
    /// </summary>
    public class CommandChecker
    {
        Robot robot = new Robot();

        public string Commands(string commandInput)
        {
            string command = commandInput.ToUpper();
            string result = string.Empty;

            try
            {
                if (command == Command.PLACE)
                {
                    result = robot.Place(command);
                }
                else if (!robot.Placed)
                {
                    result = Message.Message.NOT_PLACED;
                }
                else if (command == Command.REPORT)
                {
                    result = robot.GetReport();
                }
                else if (command == Command.MOVE)
                {
                    result = robot.Move();
                }
                else if (command == Command.RIGHT)
                {
                    robot.Right();
                }
                else if (command == Command.LEFT)
                {
                    robot.Left();
                }
                else
                    result = Message.Message.COMMAND_NOT_RECOGNISED;

            }
            catch (Exception e)
            {

                result = Message.Message.VALID_COMMAND;
            }

            return result;
        }
    }
}
