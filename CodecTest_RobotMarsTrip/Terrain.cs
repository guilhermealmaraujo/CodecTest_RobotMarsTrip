using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecTest_RobotMarsTrip
{
    public class Terrain
    {
        public long HorizontalLimit { get; private set; }
        public long VerticalLimit { get; private set; }

        public Terrain(long horinLimit, long vertLimit) 
        {
            HorizontalLimit = horinLimit;
            VerticalLimit = vertLimit;
        }
    }
}
