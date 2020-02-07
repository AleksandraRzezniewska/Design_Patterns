using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Enums;
using Vehicles.Library.Facade;

namespace Vehicles.Library.Tests.Facade
{
    [TestClass]
    public class BoatFacadeTests
    {
        [TestMethod]
        public void BoatFacadeReturnsProperBoatTest()
        {
            var boatFacade = new BoatFacade();
            var boat = boatFacade.CreateBoat(1997, "Audi", 300, 300, Guid.NewGuid(), Color.Pink, EngineType.Diesel);

            Assert.AreEqual(boat.ProductionYear, 1997);
            Assert.AreEqual(boat.Brand, "Audi");
            Assert.AreEqual(boat.KerbWeight, 300);
            Assert.AreEqual(boat.MaxVelocity, 300);
            Assert.AreEqual(boat.Color, Color.Pink);
            Assert.AreEqual(boat.EngineType, EngineType.Diesel);
        }
    }
}
