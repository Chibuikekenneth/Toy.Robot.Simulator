using NUnit.Framework;
using Toy.Robot.Simulator.Library;

namespace Toy.Robot.Simulator.Test
{
    /// <summary>
    /// Test all directions using the MOVE command
    /// </summary>
    [TestFixture]
    public class RobotMoveTest
    {
        [Test]
        public void Robot_At_0_0_N_Report_0_0_N_AfterSingleMove()
        {
            //arrange
            TRobot robot = new TRobot();

            //act
            string result = robot.Commands("PLACE 0,0,NORTH");
            result = robot.Commands("MOVE");
            result = robot.Commands("REPORT");

            //assert
            Assert.AreEqual("0,1,NORTH", result);
        }
    }
}
