﻿using System;
using Toy.Robot.Simulator.Library;

namespace Toy.Robot.Simulator
{
    class Program
    {
        /// <summary>
        /// This is the Interface of the Toy Robot Simulator.
        /// This Makes use of the library to run the Program
        /// </summary>
        static void Main(string[] args)
        {
            const string instructions =
@"
  **********************************
  **********************************
  **   TOY ROBOT SIMULATOR        **
  **                              **
  ** With 6 x 6 Square Table Top  **
  **                              **
  **********************************
  **********************************

                                                                                                                   
  **      # 1. PLACE - PLACE will put the toy robot on the table in position X,Y and facing NORTH, SOUTH, EAST or WEST.   **
  **      # 2. RIGHT - to turn the robot 90 degrees Right without changing its current position                           **
  **      # 3. LEFT - to turn the robot 90 degrees left without changing its current position                             **
  **      # 4. MOVE to move the robot one step forward in it's direction                                                  **
  **      # 5. REPORT to print the current position of the robot.                                                         **
  **      # 6. EXIT to exit the application                                                                               **
";

            Console.WriteLine(instructions);

            TRobot robot = new TRobot();

            while(true)
            {
                Console.WriteLine("Enter a Valid Command :>");
                var command = Console.ReadLine();

                if(command == null) continue;

                if (command.Equals("EXIT"))
                    break;

                Console.WriteLine(robot.Commands(command));
                Console.WriteLine();
            }
        }
    }
}
