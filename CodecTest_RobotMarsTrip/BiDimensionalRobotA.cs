using CodecTest_RobotMarsTrip.Enums;
using CodecTest_RobotMarsTrip.Interfaces;

namespace CodecTest_RobotMarsTrip
{
    public class BiDimensionalRobotA : IBiDimensionalMover
    {
        private long PosX;
        private long PosY;
        private FacingOption Facing;

        public BiDimensionalRobotA(long x, long y, FacingOption fac) 
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

        public long GetPosX() 
        {
            return PosX;
        }

        public long GetPosY()
        {
            return PosY;
        }

        public FacingOption GetFacingOption()
        {
            return Facing;
        }
    }

}
