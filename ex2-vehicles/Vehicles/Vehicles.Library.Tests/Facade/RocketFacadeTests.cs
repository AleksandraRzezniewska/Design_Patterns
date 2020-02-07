using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Enums;
using Vehicles.Library.Facade;

namespace Vehicles.Library.Tests.Facade
{
    [TestClass]
    public class RocketFacadeTests
    {
        [TestMethod]
        public void RocketFacadeReturnsProperRocketTest()
        {
            var rocketFacade = new RocketFacade();
            var rocket = rocketFacade.CreateRocket(1997, "Audi", 300, 300, Guid.NewGuid(), Color.Pink, EngineType.Diesel);

            Assert.AreEqual(rocket.ProductionYear, 1997);
            Assert.AreEqual(rocket.Brand, "Audi");
            Assert.AreEqual(rocket.KerbWeight, 300);
            Assert.AreEqual(rocket.MaxVelocity, 300);
            Assert.AreEqual(rocket.Color, Color.Pink);
            Assert.AreEqual(rocket.EngineType, EngineType.Diesel);
        }
    }
}
