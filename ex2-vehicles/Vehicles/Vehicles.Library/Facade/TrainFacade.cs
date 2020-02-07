using System;
using Vehicles.Library.Enums;

namespace Vehicles.Library.Facade
{
    public class TrainFacade
    {
        Train train = new Train();

        public Train CreateTrain(int year, string brand, int weight, int maxVelocity, Guid id, Color color, EngineType engineType)
        {
            train.ProductionYear = year;
            train.Brand = brand;
            train.KerbWeight = weight;
            train.MaxVelocity = maxVelocity;
            train.Id = id;
            train.Color = color;
            train.EngineType = engineType;

            return train;
        }
    }
}
