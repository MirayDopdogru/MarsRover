using MarsRover.BLL.Concrete;
using MarsRover.Model.Constant;
using MarsRover.UnitTest.TestData;
using System;
using Xunit;

namespace MarsRover.UnitTest
{
    public class MarsRoverTest
    {
        /// <summary>
        /// 5 5
        /// 1 2 N
        ///LMLMLMLMM
        /// </summary>
        [Fact]
        public void Test1()
        {
            StartMoving startMoving = new StartMoving();
            var location = Scenario1.Location();

            startMoving.Execute(location, Scenario1.Commands.ToCharArray(), Scenario1.MaxPoints);

            var actualOutput = $"{location.X} {location.Y} {location.Direction}";
            var expectedOutput = "1 3 N";

            Assert.Equal(expectedOutput, actualOutput);
        }


        /// <summary>
        /// 5 5
        /// 3 3 E
        ///MMRMMRMRRM
        /// </summary>
        [Fact]
        public void Test2()
        {
            StartMoving startMoving = new StartMoving();
            var location = Scenario2.Location();

            startMoving.Execute(location, Scenario2.Commands.ToCharArray(), Scenario2.MaxPoints);

            var actualOutput = $"{location.X} {location.Y} {location.Direction}";
            var expectedOutput = "5 1 E";

            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
