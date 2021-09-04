using MarsRover.Model.Concrete;
using MarsRover.Model.Constant;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.UnitTest.TestData
{
    public static class Scenario1
    {
        public static string Commands = "LMLMLMLMM";

        public static string[] MaxPoints = { "5", "5" };

        public static Location Location()
        {
            return new Location
            {
                X = 1,
                Y = 2,
                Direction = Direction.N
            };
        }
    }
}
