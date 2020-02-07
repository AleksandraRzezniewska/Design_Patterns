using System;
using Vehicles.Library.Enums;

namespace Vehicles.Library.Facade
{
    public class CarFacade
    {
        Car car = new Car();

        public Car CreateCar(int year, string brand, int weight, int maxVelocity, Guid id, Color color, EngineType engineType)
        {
            car.ProductionYear = year;
            car.Brand = brand;
            car.KerbWeight = weight;
            car.MaxVelocity = maxVelocity;
            car.Id = id;
            car.Color = color;
            car.EngineType = engineType;

            return car;
        }
    }
}
