using System;
using Vehicles.Library.Enums;

namespace Vehicles.Library.Abstractions
{
    public abstract class VehicleBuilder<T> where T : Vehicle, new()
    {
        private T _vehicle = new T();

        public VehicleBuilder<T> SetProductionYear(int year)
        {
            _vehicle.ProductionYear = year;

            return this;
        }

        public VehicleBuilder<T> SetBrand(string brand)
        {
            _vehicle.Brand = brand;

            return this;
        }

        public VehicleBuilder<T> SetKerbWeight(int weight)
        {
            _vehicle.KerbWeight = weight;

            return this;
        }

        public VehicleBuilder<T> SetId()
        {
            _vehicle.Id = Guid.NewGuid();

            return this;
        }

        public VehicleBuilder<T> SetMaxVelosity(int velosity)
        {
            _vehicle.MaxVelocity = velosity;

            return this;
        }

        public VehicleBuilder<T> SetColor(Color color)
        {
            _vehicle.Color = color;

            return this;
        }

        public T Build()
        {
            return _vehicle;
        }
    }
}
