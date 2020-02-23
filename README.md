##Toy Robot Simulator
This C# `.NET Core` solution is a simulator of a toy robot that moves on a tabletop. The development of this project is driven by unit tests.

####Instructions and Valid Commands
Follow the on screen instructions to place a robot and move it around the board. To exit the application at any time type EXIT 
```. The library allows for a simulation of a toy robot moving on a 6 x 6 square tabletop.
. There are no obstructions on the table surface.
. The robot is free to roam around the surface of the table, but must be prevented from falling to destruction. Any movement that would result in this must be prevented, however further valid movement commands must still be allowed.
. PLACE will put the toy robot on the table in position X,Y and facing NORTH, SOUTH, EAST or WEST.
. (0,0) can be considered as the SOUTH WEST corner and (5,5) as the NORTH EAST corner.
. The first valid command to the robot is a PLACE command. After that, any sequence of commands may be issued, in any order, including another PLACE command. The library should discard all commands in the sequence until a valid PLACE command has been executed.
. The PLACE command should be discarded if it places the robot outside of the table surface.
. Once the robot is on the table, subsequent PLACE commands could leave out the direction and only provide the coordinates. When this happens, the robot moves to the new coordinates without changing the direction.
. MOVE will move the toy robot one unit forward in the direction it is currently facing.
. LEFT and RIGHT will rotate the robot 90 degrees in the specified direction without changing the position of the robot.
. REPORT will announce the X,Y and orientation of the robot.
. A robot that is not on the table can choose to ignore the MOVE, LEFT, RIGHT and REPORT commands.
. The library should discard all invalid commands and parameters.
```
<h4>Installing and Running</h4>
The application runs in a single executable file which can be opened by double clicking it. The user can follow instructions on the console and also use it to type their input. For convenience the file can be downloaded from here:
<br><a href = "https://github.com/jeff1978/Toy-Robot-Simulator/blob/master/ToyRobotSimulator/bin/Debug/ToyRobotSimulator.exe">ToyRobotSimulator.exe</a>

####Unit Testing
To Test, navigate to test project using : 
