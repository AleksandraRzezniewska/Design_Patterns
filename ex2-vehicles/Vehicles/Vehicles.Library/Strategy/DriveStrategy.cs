using System;
using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Strategy
{
    public class DriveStrategy : IMoveStrategy
    {
        public string Move()
        {
            return "Drive";
        }
    }
}
