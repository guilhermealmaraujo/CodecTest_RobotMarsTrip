﻿using CodecTest_RobotMarsTrip;
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
            Robot robotUnderTest = new Robot(posX, posY, facingOption);

            //Act
            robotUnderTest.MoveForward();

            //Assert
            if (facingOption == FacingOption.North) 
            {
                Assert.Equal(posY + 1, robotUnderTest.PosY);
                Assert.Equal(posX, robotUnderTest.PosX);
            }
            else if (facingOption == FacingOption.South) 
            {
                Assert.Equal(posY - 1, robotUnderTest.PosY);
                Assert.Equal(posX, robotUnderTest.PosX);
            }
            else if (facingOption == FacingOption.West)
            {
                Assert.Equal(posY, robotUnderTest.PosY);
                Assert.Equal(posX - 1, robotUnderTest.PosX);
            }
            else if (facingOption == FacingOption.East)
            {
                Assert.Equal(posY, robotUnderTest.PosY);
                Assert.Equal(posX + 1, robotUnderTest.PosX);
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
            Robot robotUnderTest = new Robot(posX, posY, facingOption);

            robotUnderTest.TurnLeft();

            if (facingOption == FacingOption.North)
            {
                Assert.Equal(FacingOption.West, robotUnderTest.Facing);
            }
            else if (facingOption == FacingOption.South)
            {
                Assert.Equal(FacingOption.East, robotUnderTest.Facing);
            }
            else if (facingOption == FacingOption.West)
            {
                Assert.Equal(FacingOption.South, robotUnderTest.Facing);
            }
            else if (facingOption == FacingOption.East)
            {
                Assert.Equal(FacingOption.North, robotUnderTest.Facing);
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
            Robot robotUnderTest = new Robot(posX, posY, facingOption);

            robotUnderTest.TurnRight();

            if (facingOption == FacingOption.North)
            {
                Assert.Equal(FacingOption.East, robotUnderTest.Facing);
            }
            else if (facingOption == FacingOption.South)
            {
                Assert.Equal(FacingOption.West, robotUnderTest.Facing);
            }
            else if (facingOption == FacingOption.West)
            {
                Assert.Equal(FacingOption.North, robotUnderTest.Facing);
            }
            else if (facingOption == FacingOption.East)
            {
                Assert.Equal(FacingOption.South, robotUnderTest.Facing);
            }
            
        }
    }
}
