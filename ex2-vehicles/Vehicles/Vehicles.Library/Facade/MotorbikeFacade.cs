using System;
using Vehicles.Library.Enums;

namespace Vehicles.Library.Facade
{
    public class MotorbikeFacade
    {
        Motorbike motorbike = new Motorbike();

        public Motorbike CreateMotorbike(int year, string brand, int weight, int maxVelocity, Guid id, Color color, EngineType engineType)
        {
            motorbike.ProductionYear = year;
            motorbike.Brand = brand;
            motorbike.KerbWeight = weight;
            motorbike.MaxVelocity = maxVelocity;
            motorbike.Id = id;
            motorbike.Color = color;
            motorbike.EngineType = engineType;

            return motorbike;
        }
    }
}
