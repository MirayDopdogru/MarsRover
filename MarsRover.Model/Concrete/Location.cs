using MarsRover.Model.Abstract;
using MarsRover.Model.Constant;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Model.Concrete
{
    public class Location : ILocation
    {       
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }
    }
}
