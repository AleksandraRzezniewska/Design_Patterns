using Vehicles.Library.Abstractions;
using Vehicles.Library.Interfaces;
using Vehicles.Library.Strategy;

namespace Vehicles.Library
{
    public class Bike : Vehicle, ILandcraftVehicle, IDecorator
    {
        private IMoveStrategy _move;

        public Bike()
        {
            _move = new DriveStrategy();
        }
    }
}
