using System;
using Vehicles.Library.Enums;

namespace Vehicles.Library.Facade
{
    public class AircraftCarrierFacade
    {
        AircraftCarrier aircraftCarrier = new AircraftCarrier();

        public AircraftCarrier CreateAircraftCarrier(int year, string brand, int weight, int maxVelocity, Guid id, Color color, EngineType engineType)
        {
            aircraftCarrier.ProductionYear = year;
            aircraftCarrier.Brand = brand;
            aircraftCarrier.KerbWeight = weight;
            aircraftCarrier.MaxVelocity = maxVelocity;
            aircraftCarrier.Id = id;
            aircraftCarrier.Color = color;
            aircraftCarrier.EngineType = engineType;

            return aircraftCarrier;
        }
    }
}
