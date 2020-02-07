using System;
using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Strategy
{
    public class FlyStrategy : IMoveStrategy
    {
        public string Move()
        {
            return "Fly";
        }
    }
}
