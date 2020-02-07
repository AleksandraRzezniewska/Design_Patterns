using Vehicles.Library.Abstractions;
using Vehicles.Library.Enums;
using Vehicles.Library.Interfaces;
using Vehicles.Library.Strategy;

namespace Vehicles.Library
{
    public class Boat : Vehicle, IWatercraftVehicle, IDecorator
    {
        public EngineType EngineType { get; set; }
        private IMoveStrategy _move;

        public Boat()
        {
            _move = new SwimStrategy();
        }
    }
}
