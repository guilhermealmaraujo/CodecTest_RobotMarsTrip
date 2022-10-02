using CodecTest_RobotMarsTrip;
using CodecTest_RobotMarsTrip.Enums;

string? terrainCrudeInput = Console.ReadLine();

string[] terrainSplit = terrainCrudeInput.Split("x");

long terrainHorLmt = Convert.ToInt64(terrainSplit[0]);
long terrainVertLmt = Convert.ToInt64(terrainSplit[1]);

string? robotCommands = Console.ReadLine();

RobotController robotController = new RobotController(1, 1, FacingOption.North, terrainHorLmt, terrainVertLmt);

foreach (char command in robotCommands)
{
    switch (command) 
    {
        case 'L':
            robotController.ExecuteComand(Command.TurnLeft);
            break;
        case 'R':
            robotController.ExecuteComand(Command.TurnRight);
            break;
        case 'F':
            robotController.ExecuteComand(Command.Forward);
            break;
        default:
            break;
    }
}

robotController.RobotReport();