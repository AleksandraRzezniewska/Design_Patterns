using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Decorator
{
    public class VehicleDecorator : IDecorator
    {
        protected IDecorator _vehicle;
        protected int _attack = 0;
        protected int _defence = 0;

        public VehicleDecorator(IDecorator vehicle)
        {
            _vehicle = vehicle;
        }
        
        public virtual int Weapon()
        {
            return _vehicle.Weapon() + _attack;
        }

        public virtual int Shield()
        {
            return _vehicle.Shield() + _defence;
        }
    }
}
