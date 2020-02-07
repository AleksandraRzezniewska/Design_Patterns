using System;
using Vehicles.Library.Enums;

namespace Vehicles.Library.Facade
{
    public class PlaneFacade
    {
        Plane plane = new Plane();

        public Plane CreatePlane(int year, string brand, int weight, int maxVelocity, Guid id, Color color, EngineType engineType)
        {
            plane.ProductionYear = year;
            plane.Brand = brand;
            plane.KerbWeight = weight;
            plane.MaxVelocity = maxVelocity;
            plane.Id = id;
            plane.Color = color;
            plane.EngineType = engineType;

            return plane;
        }
    }
}
