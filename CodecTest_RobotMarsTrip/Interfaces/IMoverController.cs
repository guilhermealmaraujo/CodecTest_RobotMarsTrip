using CodecTest_RobotMarsTrip.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecTest_RobotMarsTrip.Interfaces
{
    public interface IMoverController
    {
        public void ExecuteComand(Command command);
    }
}
