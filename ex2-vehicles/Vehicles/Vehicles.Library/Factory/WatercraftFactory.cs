using Vehicles.Library.Abstractions;
using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Factory
{
    public sealed class WatercraftFactory : VehicleFactory<WatercraftFactory>
    { 
        public T CreateVehicle<T>() 
            where T : IWatercraftVehicle, new()
        {
            return new T();
        }
    }
}
