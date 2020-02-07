using Vehicles.Library.Abstractions;
using Vehicles.Library.Enums;
using Vehicles.Library.Interfaces;
using Vehicles.Library.Strategy;

namespace Vehicles.Library
{
    public class Rocket : Vehicle, IAircraftVehicle, IDecorator
    {
        public EngineType EngineType { get; set; }
        private IMoveStrategy _move;

        public Rocket()
        {
            _move = new FlyStrategy();
        }
    }
}
