using NUnit.Framework;
using Toy.Robot.Simulator.Library;

namespace Toy.Robot.Simulator.Test
{
    /// <summary>
    /// Test Both right and Left Directions, to make sure it rotates at 90 degrees 
    /// in the specified direction without changing the position of the robot
    /// </summary>
    [TestFixture]
    public class RobotRotateTest
    {
        /// <summary>
        /// Test all left directions
        /// </summary>
        [Test]
        public void Robot_At_0_0_N_Report_0_0_W_AfterLeftCommand()
        {
            //arrange
            TRobot robot = new TRobot();
            //act
            string result = robot.Commands("PLACE 0,0,NORTH");
            result = robot.Commands("LEFT");
            result = robot.Commands("REPORT");
            //assert
            Assert.AreEqual("0,0,WEST", result);
        }

        [Test]
        public void Robot_At_0_0_W_Report_0_0_S_AfterLeftCommand()
        {
            //arrange
            TRobot robot = new TRobot();
            //act
            string result = robot.Commands("PLACE 0,0,WEST");
            result = robot.Commands("LEFT");
            result = robot.Commands("REPORT");
            //assert
            Assert.AreEqual("0,0,SOUTH", result);
        }

        [Test]
        public void Robot_At_0_0_S_Report_0_0_E_AfterLeftCommand()
        {
            //arrange
            TRobot robot = new TRobot();
            //act
            string result = robot.Commands("PLACE 0,0,SOUTH");
            result = robot.Commands("LEFT");
            result = robot.Commands("REPORT");
            //assert
            Assert.AreEqual("0,0,EAST", result);
        }

        [Test]
        public void Robot_At_0_0_E_Report_0_0_N_AfterLeftCommand()
        {
            //arrange
            TRobot robot = new TRobot();
            //act
            string result = robot.Commands("PLACE 0,0,EAST");
            result = robot.Commands("LEFT");
            result = robot.Commands("REPORT");
            //assert
            Assert.AreEqual("0,0,NORTH", result);
        }





        /// <summary>
        /// Test All right directions
        /// </summary>
        [Test]
        public void Robot_At_0_0_N_Report_0_0_E_AfterRightCommand()
        {
            //arrange
            TRobot robot = new TRobot();
            //act
            string result = robot.Commands("PLACE 0,0,NORTH");
            result = robot.Commands("RIGHT");
            result = robot.Commands("REPORT");
            //assert
            Assert.AreEqual("0,0,EAST", result);
        }

        [Test]
        public void Robot_At_0_0_E_Report_0_0_S_AfterRightCommand()
        {
            //arrange
            TRobot robot = new TRobot();
            //act
            string result = robot.Commands("PLACE 0,0,EAST");
            result = robot.Commands("RIGHT");
            result = robot.Commands("REPORT");
            //assert
            Assert.AreEqual("0,0,SOUTH", result);
        }

        [Test]
        public void Robot_At_0_0_S_Report_0_0_W_AfterRightCommand()
        {
            //arrange
            TRobot robot = new TRobot();
            //act
            string result = robot.Commands("PLACE 0,0,SOUTH");
            result = robot.Commands("RIGHT");
            result = robot.Commands("REPORT");
            //assert
            Assert.AreEqual("0,0,WEST", result);
        }

        [Test]
        public void Robot_At_0_0_W_Report_0_0_N_AfterRightCommand()
        {
            //arrange
            TRobot robot = new TRobot();
            //act
            string result = robot.Commands("PLACE 0,0,WEST");
            result = robot.Commands("RIGHT");
            result = robot.Commands("REPORT");
            //assert
            Assert.AreEqual("0,0,NORTH", result);
        }
    }

    }