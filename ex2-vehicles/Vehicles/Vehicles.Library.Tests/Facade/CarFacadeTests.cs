using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Enums;
using Vehicles.Library.Facade;

namespace Vehicles.Library.Tests.Facade
{
    [TestClass]
    public class CarFacadeTests
    {
        [TestMethod]
        public void CarFacadeReturnsProperCarTest()
        {
            var carFacade = new CarFacade();
            var car = carFacade.CreateCar(1997, "Audi", 300, 300, Guid.NewGuid(), Color.Pink, EngineType.Diesel);

            Assert.AreEqual(car.ProductionYear, 1997);
            Assert.AreEqual(car.Brand, "Audi");
            Assert.AreEqual(car.KerbWeight, 300);
            Assert.AreEqual(car.MaxVelocity, 300);
            Assert.AreEqual(car.Color, Color.Pink);
            Assert.AreEqual(car.EngineType, EngineType.Diesel);
        }
    }
}
