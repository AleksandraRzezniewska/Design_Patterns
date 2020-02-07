using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Enums;
using Vehicles.Library.Facade;

namespace Vehicles.Library.Tests.Facade
{
    [TestClass]
    public class BikeFacadeTests
    {
        [TestMethod]
        public void BikeFacadeReturnsProperBikeTest()
        {
            var bikeFacade = new BikeFacade();
            var bike = bikeFacade.CreateBike(1997, "Audi", 300, 300, Guid.NewGuid(), Color.Pink);

            Assert.AreEqual(bike.ProductionYear, 1997);
            Assert.AreEqual(bike.Brand, "Audi");
            Assert.AreEqual(bike.KerbWeight, 300);
            Assert.AreEqual(bike.MaxVelocity, 300);
            Assert.AreEqual(bike.Color, Color.Pink);
        }
    }
}
