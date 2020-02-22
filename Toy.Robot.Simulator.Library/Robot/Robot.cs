
namespace Toy.Robot.Simulator.Library.Robot
{
    public class Robot
    {
        public string direction;
        TableTop tableTop = new TableTop();

        private string Move()
        {
            string result = string.Empty;

            int XOriginalPosition = tableTop.X_Position;
            int YOriginalPosition = tableTop.Y_Position;


            switch (direction)
            {
                case "NORTH":
                    tableTop.Y_Position++; break;
                case "WEST":
                    tableTop.X_Position--; break;
                case "SOUTH":
                    tableTop.Y_Position--; break;
                case "EAST":
                    tableTop.X_Position++; break;
            }

            if(!tableTop.CheckPositionValidation())
            {
                tableTop.X_Position = XOriginalPosition;
                tableTop.Y_Position = YOriginalPosition;
                result = Message.Message.OUT_OF_BOUND;
            }

            return result;
        }
    }
}
