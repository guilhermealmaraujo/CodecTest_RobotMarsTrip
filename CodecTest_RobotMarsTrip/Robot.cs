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
        public long PosX { get; private set; }
        public long PosY { get; private set; }
        public FacingOption Facing { get; private set; }

        public Robot(long x, long y, FacingOption fac) 
        {
            PosX = x;
            PosY = y;
            Facing = fac;
        }

        public void MoveForward() 
        {
            switch (Facing) 
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
            switch (Facing)
            {
                case FacingOption.North:
                    Facing = FacingOption.West;
                    break;
                case FacingOption.South:
                    Facing = FacingOption.East;
                    break;
                case FacingOption.East:
                    Facing = FacingOption.North;
                    break;
                case FacingOption.West:
                    Facing = FacingOption.South;
                    break;
            }
        }

        public void TurnRight()
        {
            switch (Facing)
            {
                case FacingOption.North:
                    Facing = FacingOption.East;
                    break;
                case FacingOption.South:
                    Facing = FacingOption.West;
                    break;
                case FacingOption.East:
                    Facing = FacingOption.South;
                    break;
                case FacingOption.West:
                    Facing = FacingOption.North;
                    break;
            }
        }
    }

}
