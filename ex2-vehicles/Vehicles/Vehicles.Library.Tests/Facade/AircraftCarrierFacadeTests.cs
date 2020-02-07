using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Enums;
using Vehicles.Library.Facade;

namespace Vehicles.Library.Tests.Facade
{
    [TestClass]
    public class AircraftCarrierFacadeTests
    {
        [TestMethod]
        public void AircraftCarrierFacadeReturnsProperAircraftCarrierTest()
        {
            var aircraftCarrierFacade = new AircraftCarrierFacade();
            var aircraftCarrier = aircraftCarrierFacade.CreateAircraftCarrier(1997, "Audi", 300, 300, Guid.NewGuid(), Color.Pink, EngineType.Diesel);

            Assert.AreEqual(aircraftCarrier.ProductionYear, 1997);
            Assert.AreEqual(aircraftCarrier.Brand, "Audi");
            Assert.AreEqual(aircraftCarrier.KerbWeight, 300);
            Assert.AreEqual(aircraftCarrier.MaxVelocity, 300);
            Assert.AreEqual(aircraftCarrier.Color, Color.Pink);
            Assert.AreEqual(aircraftCarrier.EngineType, EngineType.Diesel);
        }
    }
}
