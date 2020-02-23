## Toy Robot Simulator
This C# `.NET Core` solution is a simulator of a toy robot that moves on a `6 x 6` square tabletop. The development of this project is driven by unit tests.

### Instructions and Valid Commands
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

Example Input and Output:
a)
PLACE 0,0,NORTH
MOVE
REPORT
Output: 0,1,NORTH

b)
PLACE 0,0,NORTH
LEFT
REPORT
Output: 0,0,WEST

c)
PLACE 1,2,EAST
MOVE
MOVE
LEFT
MOVE
REPORT
Output: 3,3,NORTH

d)
PLACE 1,2,EAST
MOVE
LEFT
MOVE
PLACE 3,1
MOVE
REPORT
Output: 3,2,NORTH
```
### Installing and Running the Application
Clone the Repository
`git clone https://github.com/Chibuikekenneth/Toy.Robot.Simulator.git `

#### The application comprises of three layers
##### 1. Toy.Robot.Simulator
```
    -This is where the Toy Robot interacts directly with the User.
    -cd Toy.Robot.Simulator
    -dotnet run
```
##### 2. Toy.Robot.Simulator.Library
```
    -This project struture contains all the business logic and functionalities of the Robot.
    -cd Toy.Robot.Simulator.Library
    -dotnet build
```
##### 3. Toy.Robot.Simulator.Test
```
    -This project struture contains all the unit test for the functionalities of the Robot.
    -cd Toy.Robot.Simulator.Test
    -dotnet restore
    -dotnet run test
``` 
