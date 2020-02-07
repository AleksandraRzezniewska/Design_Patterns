using System;
using Vehicles.Library.Enums;

namespace Vehicles.Library.Facade
{
    public class DroneFacade
    {
        Drone drone = new Drone();

        public Drone CreateDrone(int year, string brand, int weight, int maxVelocity, Guid id, Color color, EngineType engineType)
        {
            drone.ProductionYear = year;
            drone.Brand = brand;
            drone.KerbWeight = weight;
            drone.MaxVelocity = maxVelocity;
            drone.Id = id;
            drone.Color = color;
            drone.EngineType = engineType;

            return drone;
        }
    }
}
