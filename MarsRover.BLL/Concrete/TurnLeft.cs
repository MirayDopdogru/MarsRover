using MarsRover.BLL.Abstract;
using MarsRover.Model.Concrete;
using MarsRover.Model.Constant;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.BLL.Concrete
{
    public class TurnLeft : ICommand
    {/// <summary>
     /// Makes the rover spin 90 degrees left
     /// </summary>
     /// <param name="location"></param>
     /// <returns></returns>
        public Location Execute(Location location)
        {
            switch (location.Direction)
            {
                case Direction.N:
                    location.Direction = Direction.W;
                    break;

                case Direction.W:
                    location.Direction = Direction.S;
                    break;

                case Direction.S:
                    location.Direction = Direction.E;
                    break;

                case Direction.E:
                    location.Direction = Direction.N;
                    break;
            }
            return location;
        }
    }
}
