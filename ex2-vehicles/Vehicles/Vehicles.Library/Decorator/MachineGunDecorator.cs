using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Decorator
{
    public class MachineGunDecorator : VehicleDecorator
    {
        private const int attack = 100;

        public MachineGunDecorator(IDecorator vehicle) : base(vehicle)
        {
            _attack = attack;
        }
    }
}
