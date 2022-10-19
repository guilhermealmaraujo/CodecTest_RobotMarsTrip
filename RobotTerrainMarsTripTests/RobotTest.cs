using CodecTest_RobotMarsTrip;
using CodecTest_RobotMarsTrip.Enums;

namespace RobotTerrainMarsTripTests
{
    public class RobotTest
    {
        [Theory]
        [InlineData(FacingOption.North)]
        [InlineData(FacingOption.South)]
        [InlineData(FacingOption.West)]
        [InlineData(FacingOption.East)]
        public void MoveForwardTestFacingDiferentDirections(FacingOption facingOption) 
        {
            //Arrange
            int posX = 1;
            int posY = 1;
            BiDimensionalRobotA robotUnderTest = new BiDimensionalRobotA(posX, posY, facingOption);

            //Act
            robotUnderTest.MoveForward();

            //Assert
            if (facingOption == FacingOption.North) 
            {
                Assert.Equal(posY + 1, robotUnderTest.GetPosY());
                Assert.Equal(posX, robotUnderTest.GetPosX());
            }
            else if (facingOption == FacingOption.South) 
            {
                Assert.Equal(posY - 1, robotUnderTest.GetPosY());
                Assert.Equal(posX, robotUnderTest.GetPosX());
            }
            else if (facingOption == FacingOption.West)
            {
                Assert.Equal(posY, robotUnderTest.GetPosY());
                Assert.Equal(posX - 1, robotUnderTest.GetPosX());
            }
            else if (facingOption == FacingOption.East)
            {
                Assert.Equal(posY, robotUnderTest.GetPosY());
                Assert.Equal(posX + 1, robotUnderTest.GetPosX());
            }
        }

        [Theory]
        [InlineData(FacingOption.North)]
        [InlineData(FacingOption.South)]
        [InlineData(FacingOption.West)]
        [InlineData(FacingOption.East)]
        public void TurnLeftFacingDifferentDirections(FacingOption facingOption) 
        {
            int posX = 1;
            int posY = 1;
            BiDimensionalRobotA robotUnderTest = new BiDimensionalRobotA(posX, posY, facingOption);

            robotUnderTest.TurnLeft();

            if (facingOption == FacingOption.North)
            {
                Assert.Equal(FacingOption.West, robotUnderTest.GetFacingOption());
            }
            else if (facingOption == FacingOption.South)
            {
                Assert.Equal(FacingOption.East, robotUnderTest.GetFacingOption());
            }
            else if (facingOption == FacingOption.West)
            {
                Assert.Equal(FacingOption.South, robotUnderTest.GetFacingOption());
            }
            else if (facingOption == FacingOption.East)
            {
                Assert.Equal(FacingOption.North, robotUnderTest.GetFacingOption());
            }
        }

        [Theory]
        [InlineData(FacingOption.North)]
        [InlineData(FacingOption.South)]
        [InlineData(FacingOption.West)]
        [InlineData(FacingOption.East)]
        public void TurnRightFacingDifferentDirections(FacingOption facingOption)
        {
            int posX = 1;
            int posY = 1;
            BiDimensionalRobotA robotUnderTest = new BiDimensionalRobotA(posX, posY, facingOption);

            robotUnderTest.TurnRight();

            if (facingOption == FacingOption.North)
            {
                Assert.Equal(FacingOption.East, robotUnderTest.GetFacingOption());
            }
            else if (facingOption == FacingOption.South)
            {
                Assert.Equal(FacingOption.West, robotUnderTest.GetFacingOption());
            }
            else if (facingOption == FacingOption.West)
            {
                Assert.Equal(FacingOption.North, robotUnderTest.GetFacingOption());
            }
            else if (facingOption == FacingOption.East)
            {
                Assert.Equal(FacingOption.South, robotUnderTest.GetFacingOption());
            }
            
        }
    }
}
