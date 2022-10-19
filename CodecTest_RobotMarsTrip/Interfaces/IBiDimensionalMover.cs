using CodecTest_RobotMarsTrip.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecTest_RobotMarsTrip.Interfaces
{
    public interface IBiDimensionalMover
    {
        public void MoveForward();

        public void TurnLeft();

        public void TurnRight();

        public long GetPosX();

        public long GetPosY();

        public FacingOption GetFacingOption();
    }
}
