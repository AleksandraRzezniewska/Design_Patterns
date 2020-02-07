using Vehicles.Library.Abstractions;
using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Factory
{
    public sealed class LandcraftFactory : VehicleFactory<LandcraftFactory>
    {
        public T CreateVehicle<T>() 
            where T : ILandcraftVehicle, new()
        {
            return new T();
        }
    }
}
