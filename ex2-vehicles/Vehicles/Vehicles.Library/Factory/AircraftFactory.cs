using Vehicles.Library.Abstractions;
using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Factory
{
    public class AircraftFactory : VehicleFactory<AircraftFactory>
    { 
        public T CreateVehicle<T>() 
            where T : IAircraftVehicle , new()
        {
            return new T();
        }
    }
}
