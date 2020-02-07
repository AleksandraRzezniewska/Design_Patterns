using System;
using Vehicles.Library.Enums;

namespace Vehicles.Library.Facade
{
    public class RocketFacade
    {
        Rocket rocket = new Rocket();

        public Rocket CreateRocket(int year, string brand, int weight, int maxVelocity, Guid id, Color color, EngineType engineType)
        {
            rocket.ProductionYear = year;
            rocket.Brand = brand;
            rocket.KerbWeight = weight;
            rocket.MaxVelocity = maxVelocity;
            rocket.Id = id;
            rocket.Color = color;
            rocket.EngineType = engineType;

            return rocket;
        }
    }
}
