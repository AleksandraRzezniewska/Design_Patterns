using Vehicles.Library.Abstractions;
using Vehicles.Library.Enums;
using Vehicles.Library.Interfaces;
using Vehicles.Library.Strategy;

namespace Vehicles.Library
{
    public class Car : Vehicle, ILandcraftVehicle, IDecorator
    {
        public EngineType EngineType { get; set; }
        private IMoveStrategy _move; 

        public Car()
        {
            _move = new DriveStrategy();
            _move.Move();
        }
    }
}
