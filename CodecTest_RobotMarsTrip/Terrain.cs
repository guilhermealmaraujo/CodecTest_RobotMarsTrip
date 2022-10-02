using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecTest_RobotMarsTrip
{
    public class Terrain
    {
        public int HorizontalLimit { get; private set; }
        public int VerticalLimit { get; private set; }

        public Terrain(int horinLimit, int vertLimit) 
        {
            HorizontalLimit = horinLimit;
            VerticalLimit = vertLimit;
        }
    }
}
