﻿using System;

namespace Toy.Robot.Simulator.Library
{
    /// <summary>
    /// This class checks and validate all neccesary command to be used by the robot, and makes sure it performs all its actions
    /// </summary>
    public class TRobot
    {
         RobotBehaviour robot = new RobotBehaviour();

        public string Commands(string commandInput)
        {
            string command = commandInput.ToUpper();
            string result = string.Empty;

            try
            {
                if (command.Contains(Command.PLACE))
                {
                    result = robot.Place(command);
                }
                else if (! robot.Placed)
                {
                    result = Message.NOT_PLACED;
                }
                
                else if (command.Contains(Command.REPORT))
                {
                    result = robot.GetReport();
                }
                else if (command.Contains(Command.MOVE))
                {
                    result = robot.Move();
                }
                else if (command.Contains(Command.RIGHT))
                {
                    robot.Right();
                }
                else if (command.Contains(Command.LEFT))
                {
                    robot.Left();
                }
                else
                    result = Message.COMMAND_NOT_RECOGNISED;

            }
            catch (Exception e)
            {

                result = Message.VALID_COMMAND;
            }

            return result;
        }
    }
}
