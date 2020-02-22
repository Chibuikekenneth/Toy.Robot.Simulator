using System;

namespace Toy.Robot.Simulator.Library.Command
{
    public class CommandChecker
    {
        private bool Placed = false;
        public string Commands(string commandInput)
        {
            string command = commandInput.ToUpper();
            string result = string.Empty;

            try
            {
                if (command.Contains("PlACE")
                {
                    result = Place(command);
                }
                
            }
            catch (Exception e)
            {

                result =
            }
        }
    }
}
