using MarsRover.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.BLL.Abstract
{
    public interface ICommand
    {
        public Location Execute(Location location);
    }
}
