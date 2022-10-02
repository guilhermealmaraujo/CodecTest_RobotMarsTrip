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
            Assert.Equal(robotUnderTest.PosY, posY + 1);
            Assert.Equal(robotUnderTest.PosX, posX);
        }

        [Fact]
        public void MoveForwardTestFacingSouth()
        {
            int posX = 1;
            int posY = 1;
            Robot robotUnderTest = new Robot(posX, posY, FacingOption.South);

            robotUnderTest.MoveForward();

            Assert.Equal(robotUnderTest.PosY, posY - 1);
            Assert.Equal(robotUnderTest.PosX, posX);
        }

        [Fact]
        public void MoveForwardTestFacingWest()
        {
            int posX = 1;
            int posY = 1;
            Robot robotUnderTest = new Robot(posX, posY, FacingOption.West);

            robotUnderTest.MoveForward();

            Assert.Equal(robotUnderTest.PosY, posY);
            Assert.Equal(robotUnderTest.PosX, posX - 1);
        }

        [Fact]
        public void MoveForwardTestFacingEast()
        {
            int posX = 1;
            int posY = 1;
            Robot robotUnderTest = new Robot(posX, posY, FacingOption.East);

            robotUnderTest.MoveForward();

            Assert.Equal(robotUnderTest.PosY, posY);
            Assert.Equal(robotUnderTest.PosX, posX + 1);
        }
    }
}
