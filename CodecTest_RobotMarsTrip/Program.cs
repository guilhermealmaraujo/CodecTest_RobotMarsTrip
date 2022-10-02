using CodecTest_RobotMarsTrip;
using CodecTest_RobotMarsTrip.Enums;

RobotController robotController = new RobotController(1, 1, FacingOption.North, 5, 5);

robotController.RobotReport();

robotController.ExecuteComand(Command.Forward);
robotController.RobotReport();

robotController.ExecuteComand(Command.Forward);
robotController.RobotReport();

robotController.ExecuteComand(Command.TurnRight);
robotController.RobotReport();

robotController.ExecuteComand(Command.Forward);
robotController.RobotReport();

robotController.ExecuteComand(Command.TurnLeft);
robotController.RobotReport();

robotController.ExecuteComand(Command.Forward);
robotController.RobotReport();

robotController.ExecuteComand(Command.TurnLeft);
robotController.RobotReport();

robotController.ExecuteComand(Command.Forward);
robotController.RobotReport();
