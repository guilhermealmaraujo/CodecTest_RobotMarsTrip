using CodecTest_RobotMarsTrip;
using CodecTest_RobotMarsTrip.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotTerrainMarsTripTests
{
    public class RobotTest
    {
        [Fact]
        public void MoveForwardTestFacingNorth() 
        {
            //Arrange
            int posX = 1;
            int posY = 1;
            Robot robotUnderTest = new Robot(posX, posY, FacingOption.North);

            //Act
            robotUnderTest.MoveForward();

            //Assert
            Assert.Equal(posY + 1, robotUnderTest.PosY);
            Assert.Equal(posX, robotUnderTest.PosX);
        }

        [Fact]
        public void MoveForwardTestFacingSouth()
        {
            int posX = 1;
            int posY = 1;
            Robot robotUnderTest = new Robot(posX, posY, FacingOption.South);

            robotUnderTest.MoveForward();

            Assert.Equal(posY - 1, robotUnderTest.PosY);
            Assert.Equal(posX, robotUnderTest.PosX);
        }

        [Fact]
        public void MoveForwardTestFacingWest()
        {
            int posX = 1;
            int posY = 1;
            Robot robotUnderTest = new Robot(posX, posY, FacingOption.West);

            robotUnderTest.MoveForward();

            Assert.Equal(posY, robotUnderTest.PosY);
            Assert.Equal(posX - 1, robotUnderTest.PosX);
        }

        [Fact]
        public void MoveForwardTestFacingEast()
        {
            int posX = 1;
            int posY = 1;
            Robot robotUnderTest = new Robot(posX, posY, FacingOption.East);

            robotUnderTest.MoveForward();

            Assert.Equal(posY, robotUnderTest.PosY);
            Assert.Equal(posX + 1, robotUnderTest.PosX);
        }

        [Fact]
        public void TurnLeftFacingNorth() 
        {
            int posX = 1;
            int posY = 1;
            Robot robotUnderTest = new Robot(posX, posY, FacingOption.North);

            robotUnderTest.TurnLeft();

            Assert.Equal(FacingOption.West, robotUnderTest.facing);
        }

        [Fact]
        public void TurnLeftFacingSouth()
        {
            int posX = 1;
            int posY = 1;
            Robot robotUnderTest = new Robot(posX, posY, FacingOption.South);

            robotUnderTest.TurnLeft();

            Assert.Equal(FacingOption.East, robotUnderTest.facing);
        }

        [Fact]
        public void TurnLeftFacingWest()
        {
            int posX = 1;
            int posY = 1;
            Robot robotUnderTest = new Robot(posX, posY, FacingOption.West);

            robotUnderTest.TurnLeft();

            Assert.Equal(FacingOption.South, robotUnderTest.facing);
        }

        [Fact]
        public void TurnLeftFacingEast()
        {
            int posX = 1;
            int posY = 1;
            Robot robotUnderTest = new Robot(posX, posY, FacingOption.East);

            robotUnderTest.TurnLeft();

            Assert.Equal(FacingOption.North, robotUnderTest.facing);
        }

        [Fact]
        public void TurnRightFacingNorth()
        {
            int posX = 1;
            int posY = 1;
            Robot robotUnderTest = new Robot(posX, posY, FacingOption.North);

            robotUnderTest.TurnRight();

            Assert.Equal(FacingOption.East, robotUnderTest.facing);
        }

        [Fact]
        public void TurnRightFacingSouth()
        {
            int posX = 1;
            int posY = 1;
            Robot robotUnderTest = new Robot(posX, posY, FacingOption.South);

            robotUnderTest.TurnRight();

            Assert.Equal(FacingOption.West, robotUnderTest.facing);
        }

        [Fact]
        public void TurnRightFacingWest()
        {
            int posX = 1;
            int posY = 1;
            Robot robotUnderTest = new Robot(posX, posY, FacingOption.West);

            robotUnderTest.TurnRight();

            Assert.Equal(FacingOption.North, robotUnderTest.facing);
        }

        [Fact]
        public void TurnRightFacingEast()
        {
            int posX = 1;
            int posY = 1;
            Robot robotUnderTest = new Robot(posX, posY, FacingOption.East);

            robotUnderTest.TurnRight();

            Assert.Equal(FacingOption.South, robotUnderTest.facing);
        }
    }
}
