using CodecTest_RobotMarsTrip;
using CodecTest_RobotMarsTrip.Enums;

namespace RobotTerrainMarsTripTests
{
    public class RobotControllerTest
    {
        [Theory]
        [InlineData(1 ,5, FacingOption.North)]
        [InlineData(5, 1, FacingOption.South)]
        [InlineData(5, 1, FacingOption.East)]
        [InlineData(1, 5, FacingOption.West)]
        public void ExecuteCommandMoveForward_FacingDifferentDirections_TestingHorizontalAndVerticalLimitsOfTerrain(int initialPosX, int initialPosY, FacingOption facingOption) 
        {
            int robotPosX = initialPosX;
            int robotPosY = initialPosY;

            BiDimensionalRobotA robot = new BiDimensionalRobotA(robotPosX, robotPosY, facingOption);

            BiDimensionalRobotController robotControllerUnderTest = new BiDimensionalRobotController(robot, 5, 5);

            robotControllerUnderTest.ExecuteComand(Command.Forward);

            Assert.Equal(robotPosY, robotControllerUnderTest.Robot.GetPosY());
            Assert.Equal(robotPosX, robotControllerUnderTest.Robot.GetPosX());
            Assert.Equal(facingOption, robotControllerUnderTest.Robot.GetFacingOption());
        }

        [Theory]
        [InlineData(FacingOption.West, FacingOption.North, Command.TurnLeft)]
        [InlineData(FacingOption.East, FacingOption.South, Command.TurnLeft)]
        [InlineData(FacingOption.South, FacingOption.West, Command.TurnLeft)]
        [InlineData(FacingOption.North, FacingOption.East, Command.TurnLeft)]
        [InlineData(FacingOption.East, FacingOption.North, Command.TurnRight)]
        [InlineData(FacingOption.West, FacingOption.South, Command.TurnRight)]
        [InlineData(FacingOption.North, FacingOption.West, Command.TurnRight)]
        [InlineData(FacingOption.South, FacingOption.East, Command.TurnRight)]
        public void ExecuteCommandTurnLeftOrRight_FacingDifferentDirections(FacingOption expectedFO, FacingOption originalFO, Command commandLeftOrRight) 
        {
            int robotPosX = 1;
            int robotPosY = 1;

            BiDimensionalRobotA robot = new BiDimensionalRobotA(robotPosX, robotPosY, originalFO);

            BiDimensionalRobotController robotControllerUnderTest = new BiDimensionalRobotController(robot, 5, 5);

            robotControllerUnderTest.ExecuteComand(commandLeftOrRight);

            Assert.Equal(expectedFO, robotControllerUnderTest.Robot.GetFacingOption());
            Assert.Equal(robotPosY, robotControllerUnderTest.Robot.GetPosY());
            Assert.Equal(robotPosX, robotControllerUnderTest.Robot.GetPosX());
        }
    }
}
