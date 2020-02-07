using Vehicles.Library.Abstractions;
using Vehicles.Library.Enums;
using Vehicles.Library.Interfaces;
using Vehicles.Library.Strategy;

namespace Vehicles.Library
{
    public class AircraftCarrier : Vehicle, IWatercraftVehicle, IDecorator
    {
        public EngineType EngineType { get; set; }
        private IMoveStrategy _move;

        public AircraftCarrier()
        {
            _move = new SwimStrategy();
        }
    }
}
