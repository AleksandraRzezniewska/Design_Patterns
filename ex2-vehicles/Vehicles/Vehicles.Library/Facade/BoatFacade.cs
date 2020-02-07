using System;
using Vehicles.Library.Enums;

namespace Vehicles.Library.Facade
{
    public class BoatFacade
    {
        Boat boat = new Boat();

        public Boat CreateBoat(int year, string brand, int weight, int maxVelocity, Guid id, Color color, EngineType engineType)
        {
            boat.ProductionYear = year;
            boat.Brand = brand;
            boat.KerbWeight = weight;
            boat.MaxVelocity = maxVelocity;
            boat.Id = id;
            boat.Color = color;
            boat.EngineType = engineType;

            return boat;
        }
    }
}
