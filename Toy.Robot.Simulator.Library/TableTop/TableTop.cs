
namespace Toy.Robot.Simulator.Library
{
    /// <summary>
    /// This class contains the The Table Surface that the robot sits on, specifically, it has a Top of XTablesize(6) and YTablesize(6)
    /// This class also validates the robot's positions to make sure its valid
    /// </summary>
    public class TableTop
    {
        
        private int XTablesize { get; set; }
        private int YTablesize { get; set; }


        public int X_Position { get; set; }
        public int Y_Position { get; set; }


        //Default Table sizes 6 x 6 as Strictly specified
        public TableTop()
        {
            XTablesize = 6;
            YTablesize = 6;
        }

        public bool CheckPositionValidation()
        {
            if ((X_Position < 0) || (Y_Position < 0)) 
                return false;
            else if ((X_Position >= XTablesize) || (Y_Position >= YTablesize)) 
                return false;
            else 
                return true;
        }
    }
}
