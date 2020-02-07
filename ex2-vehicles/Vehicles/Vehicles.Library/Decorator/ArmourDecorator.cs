using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Decorator
{
    public class ArmourDecorator : VehicleDecorator
    {
        private const int defence = 200;

        public ArmourDecorator(IDecorator vehicle) : base(vehicle)
        {
            _defence = defence;
        }
    }
}
