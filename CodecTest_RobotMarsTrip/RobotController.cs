using CodecTest_RobotMarsTrip.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecTest_RobotMarsTrip
{
    public class RobotController
    {
        public Robot Robot { get; private set; }
        public Terrain TerrainSensor { get; private set; }

        public RobotController(long initPosX, long initPosY, FacingOption initFacingOption, long terrHorLimit, long terrVertLimit) 
        {
            Robot = new Robot(initPosX, initPosY, initFacingOption);
            TerrainSensor = new Terrain(terrHorLimit, terrVertLimit);
        }

        public void ExecuteComand(Command command) 
        {
            if (command == Command.TurnLeft)
            {
                Robot.TurnLeft();
            }
            else if (command == Command.TurnRight)
            {
                Robot.TurnRight();
            }
            else if (command == Command.Forward) 
            {
                if (Robot.Facing == FacingOption.North) 
                    MoveForwardFacingNorth();

                if(Robot.Facing == FacingOption.South)
                    MoveForwardFacingSouth();

                if(Robot.Facing == FacingOption.West)
                    MoveForwardFacingWest();

                if(Robot.Facing == FacingOption.East)
                    MoveForwardFacingEast();
            }
        }

        public void RobotReport() 
        {
            Console.WriteLine(Robot.PosX + ", " + Robot.PosY + ", " + Robot.Facing);
        }

        private void MoveForwardFacingNorth() 
        {
            if (Robot.PosY < TerrainSensor.VerticalLimit) 
            {
                Robot.MoveForward();
            }
        }

        private void MoveForwardFacingSouth()
        {
            if (Robot.PosY > 1)
            {
                Robot.MoveForward();
            }
        }

        private void MoveForwardFacingWest()
        {
            if (Robot.PosX > 1)
            {
                Robot.MoveForward();
            }
        }

        private void MoveForwardFacingEast()
        {
            if (Robot.PosX < TerrainSensor.HorizontalLimit)
            {
                Robot.MoveForward();
            }
        }
    }
}
