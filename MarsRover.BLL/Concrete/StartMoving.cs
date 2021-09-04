using MarsRover.BLL.Abstract;
using MarsRover.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.BLL.Concrete
{/// <summary>
/// Makes the rover moving
/// </summary>
    public class StartMoving
    {
        public void Execute(Location location, char[] commands, string[] maxPoint)
        {
            TurnLeft tleft = new TurnLeft();
            TurnRight tright = new TurnRight();
            MoveForward move = new MoveForward();

            foreach (var letter in commands)
            {
                if (location.X < 0 || location.X > Convert.ToInt32(maxPoint[0]) || location.Y < 0 || location.Y > Convert.ToInt32(maxPoint[1]))
                {
                    throw new Exception("Location can not be beyond bounderies of the plateau!");
                }
                else
                {
                    switch (letter)
                    {
                        case 'R':
                            tright.Execute(location);
                            break;
                        case 'M':
                            move.Execute(location);
                            break;
                        case 'L':
                            tleft.Execute(location);
                            break;
                        default:
                            Console.WriteLine($"Invalid Character {letter}");
                            break;
                    }
                }
            }
        }
    }
}
