using MarsRover.BLL.Abstract;
using MarsRover.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.BLL.Concrete
{
    public class MoveForward : ICommand
    {/// <summary>
     /// 'M' means move forward one grid point
     /// </summary>
     /// <param name="location"></param>
     /// <returns></returns>
        public Location Execute(Location location)
        {
            if (location.Direction == Model.Constant.Direction.N)
            {
                location.Y += 1;
            }
            else if (location.Direction == Model.Constant.Direction.S)
            {
                if (location.Y != 0)
                    location.Y -= 1;
                else
                {
                    Console.WriteLine("The rover can not move");
                }
            }
            else if (location.Direction == Model.Constant.Direction.W)
            {
                if (location.X != 0)
                    location.X -= 1;
                else
                {
                    Console.WriteLine("The rover can not move");
                }
            }
            else if (location.Direction == Model.Constant.Direction.E)
            {
                location.X += 1;
            }
            return location;
        }
    }
}
