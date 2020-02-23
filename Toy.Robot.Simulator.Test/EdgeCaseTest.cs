using NUnit.Framework;
using Toy.Robot.Simulator.Library;

namespace Toy.Robot.Simulator.Test
{
    /// <summary>
    /// 
    /// </summary>]
    [TestFixture]
    public class EdgeCaseTest
    {
        [Test]
        public void EdgeTestCase_Example_1()
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


        [Test]
        public void EdgeTestCase_Example_2()
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
        public void EdgeTestCase_Example_3()
        {
            //arrange
            TRobot robot = new TRobot();
            //act
            string result = robot.Commands("PLACE 1,2,EAST");
            result = robot.Commands("MOVE");
            result = robot.Commands("MOVE");
            result = robot.Commands("LEFT");
            result = robot.Commands("MOVE");
            result = robot.Commands("REPORT");
            //assert
            Assert.AreEqual("3,3,NORTH", result);
        }

        [Test]
        public void EdgeTestCase_Example_4()
        {
            //arrange
            TRobot robot = new TRobot();
            //act
            string result = robot.Commands("PLACE 1,2,EAST");
            result = robot.Commands("MOVE");
            result = robot.Commands("LEFT");
            result = robot.Commands("MOVE");
            result = robot.Commands("PLACE 3,1");
            result = robot.Commands("MOVE");
            result = robot.Commands("REPORT");
            //assert
            Assert.AreEqual("3,2,NORTH", result);
        }
    }
}
