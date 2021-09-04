using MarsRover.BLL.Concrete;
using MarsRover.Model.Concrete;
using MarsRover.Model.Constant;
using System;

namespace MarsRoverCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Location location = new Location();
            var maxPoint = Console.ReadLine().Split(' ');
            var commandPositions = Console.ReadLine().Trim().Split(' ');


            if (commandPositions.Length == 3)
            {
                location.X = Convert.ToInt32(commandPositions[0]);
                location.Y = Convert.ToInt32(commandPositions[1]);
                location.Direction = (Direction)Enum.Parse(typeof(Direction), commandPositions[2]);
            }

            var commandRotations = Console.ReadLine().ToUpper();

            try
            {
                StartMoving sm = new StartMoving();
                sm.Execute(location, commandRotations.ToCharArray(), maxPoint);
                if (location != null)
                {
                    Console.WriteLine($"{location.X} {location.Y} {location.Direction}");
                }
                else
                {
                    Console.WriteLine("Not valid input!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
