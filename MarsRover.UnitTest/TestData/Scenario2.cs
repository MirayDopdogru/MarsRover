using MarsRover.Model.Concrete;
using MarsRover.Model.Constant;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.UnitTest.TestData
{
    public static class Scenario2
    {
        public static string Commands = "MMRMMRMRRM";

        public static string[] MaxPoints = { "5", "5" };

        public static Location Location()
        {
            return new Location
            {
                X = 3,
                Y = 3,
                Direction = Direction.E
            };
        }
    }
}
