using System;
using Vehicles.Library.Enums;

namespace Vehicles.Library.Facade
{
    public class BikeFacade
    {
        Bike bike = new Bike();

        public Bike CreateBike(int year, string brand, int weight, int maxVelocity, Guid id, Color color)
        {
            bike.ProductionYear = year;
            bike.Brand = brand;
            bike.KerbWeight = weight;
            bike.MaxVelocity = maxVelocity;
            bike.Id = id;
            bike.Color = color;

            return bike;
        }
    }
}
