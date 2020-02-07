using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Enums;
using Vehicles.Library.Facade;

namespace Vehicles.Library.Tests.Facade
{
    [TestClass]
    public class DroneFacadeTests
    {
        [TestMethod]
        public void DroneFacadeReturnsProperDroneTest()
        {
            var droneFacade = new DroneFacade();
            var dorne = droneFacade.CreateDrone(1997, "Audi", 300, 300, Guid.NewGuid(), Color.Pink, EngineType.Diesel);

            Assert.AreEqual(dorne.ProductionYear, 1997);
            Assert.AreEqual(dorne.Brand, "Audi");
            Assert.AreEqual(dorne.KerbWeight, 300);
            Assert.AreEqual(dorne.MaxVelocity, 300);
            Assert.AreEqual(dorne.Color, Color.Pink);
            Assert.AreEqual(dorne.EngineType, EngineType.Diesel);
        }
    }
}
