using CodecTest_RobotMarsTrip.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecTest_RobotMarsTrip
{
    public class Robot
    {
        public int PosX { get; private set; }
        public int PosY { get; private set; }
        public FacingOption facing { get; private set; }

        public Robot(int x, int y, FacingOption fac) 
        {
            PosX = x;
            PosY = y;
            facing = fac;
        }

        public void MoveForward() 
        {
            switch (facing) 
            {
                case FacingOption.North:
                    PosY++;
                    break;
                case FacingOption.South:
                    PosY--;
                    break;
                case FacingOption.East:
                    PosX++;
                    break;
                case FacingOption.West:
                    PosX--;
                    break;
            }
        }

        public void TurnLeft() 
        {
            switch (facing)
            {
                case FacingOption.North:
                    facing = FacingOption.West;
                    break;
                case FacingOption.South:
                    facing = FacingOption.East;
                    break;
                case FacingOption.East:
                    facing = FacingOption.North;
                    break;
                case FacingOption.West:
                    facing = FacingOption.South;
                    break;
            }
        }

        public void TurnRight()
        {
            switch (facing)
            {
                case FacingOption.North:
                    facing = FacingOption.East;
                    break;
                case FacingOption.South:
                    facing = FacingOption.West;
                    break;
                case FacingOption.East:
                    facing = FacingOption.South;
                    break;
                case FacingOption.West:
                    facing = FacingOption.North;
                    break;
            }
        }
    }

}
