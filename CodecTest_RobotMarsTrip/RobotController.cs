using CodecTest_RobotMarsTrip.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecTest_RobotMarsTrip
{
    internal class RobotController
    {
        public Robot Robot { get; private set; }
        public Terrain TerrainSensor { get; private set; }

        public RobotController(int initPosX, int initPosY, FacingOption initFacingOption, int terrHorLimit, int terrVertLimit) 
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
                if (Robot.facing == FacingOption.North) 
                    MoveForwardFacingNorth();

                if(Robot.facing == FacingOption.South)
                    MoveForwardFacingSouth();

                if(Robot.facing == FacingOption.West)
                    MoveForwardFacingWest();

                if(Robot.facing == FacingOption.East)
                    MoveForwardFacingEast();
            }
        }

        public void RobotReport() 
        {
            Console.WriteLine("Robot report: " + Robot.PosX + ", " + Robot.PosY + ", " + Robot.facing);
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
            if (Robot.PosY < TerrainSensor.HorizontalLimit)
            {
                Robot.MoveForward();
            }
        }
    }
}
