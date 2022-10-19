using CodecTest_RobotMarsTrip.Enums;
using CodecTest_RobotMarsTrip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecTest_RobotMarsTrip
{
    public class BiDimensionalRobotController: IMoverController
    {
        public IBiDimensionalMover Robot { get; private set; }
        public TerrainSensor TerrainSensor { get; private set; }

        public BiDimensionalRobotController(IBiDimensionalMover _robot, long terrHorLimit, long terrVertLimit) 
        {
            Robot = _robot;
            TerrainSensor = new TerrainSensor(terrHorLimit, terrVertLimit);
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
                if (Robot.GetFacingOption() == FacingOption.North) 
                    MoveForwardFacingNorth();

                if(Robot.GetFacingOption() == FacingOption.South)
                    MoveForwardFacingSouth();

                if(Robot.GetFacingOption() == FacingOption.West)
                    MoveForwardFacingWest();

                if(Robot.GetFacingOption() == FacingOption.East)
                    MoveForwardFacingEast();
            }
        }

        public void RobotReport() 
        {
            Console.WriteLine(Robot.GetPosX() + ", " + Robot.GetPosY() + ", " + Robot.GetFacingOption());
        }

        private void MoveForwardFacingNorth() 
        {
            if (Robot.GetPosY() < TerrainSensor.VerticalLimit) 
            {
                Robot.MoveForward();
            }
        }

        private void MoveForwardFacingSouth()
        {
            if (Robot.GetPosY() > 1)
            {
                Robot.MoveForward();
            }
        }

        private void MoveForwardFacingWest()
        {
            if (Robot.GetPosX() > 1)
            {
                Robot.MoveForward();
            }
        }

        private void MoveForwardFacingEast()
        {
            if (Robot.GetPosX() < TerrainSensor.HorizontalLimit)
            {
                Robot.MoveForward();
            }
        }
    }
}
