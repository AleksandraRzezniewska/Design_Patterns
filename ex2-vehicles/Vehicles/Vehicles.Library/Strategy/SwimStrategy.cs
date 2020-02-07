using System;
using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Strategy
{
    public class SwimStrategy : IMoveStrategy
    {
        public string Move()
        {
            return "Swim";
        }
    }
}
