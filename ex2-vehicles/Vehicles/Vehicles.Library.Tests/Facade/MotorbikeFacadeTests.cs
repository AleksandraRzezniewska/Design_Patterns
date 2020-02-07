using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Enums;
using Vehicles.Library.Facade;

namespace Vehicles.Library.Tests.Facade
{
    [TestClass]
    public class MotorbikeFacadeTests
    {
        [TestMethod]
        public void MotorbikeFacadeReturnsProperMotorbikeTest()
        {
            var motorbikeFacade = new MotorbikeFacade();
            var motorbike = motorbikeFacade.CreateMotorbike(1997, "Audi", 300, 300, Guid.NewGuid(), Color.Pink, EngineType.Diesel);

            Assert.AreEqual(motorbike.ProductionYear, 1997);
            Assert.AreEqual(motorbike.Brand, "Audi");
            Assert.AreEqual(motorbike.KerbWeight, 300);
            Assert.AreEqual(motorbike.MaxVelocity, 300);
            Assert.AreEqual(motorbike.Color, Color.Pink);
            Assert.AreEqual(motorbike.EngineType, EngineType.Diesel);
        }
    }
}
