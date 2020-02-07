using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Enums;
using Vehicles.Library.Facade;

namespace Vehicles.Library.Tests.Facade
{
    [TestClass]
    public class PlaneFacadeTests
    {
        [TestMethod]
        public void PlaneFacadeReturnsProperPlaneTest()
        {
            var planeFacade = new PlaneFacade();
            var plane = planeFacade.CreatePlane(1997, "Audi", 300, 300, Guid.NewGuid(), Color.Pink, EngineType.Diesel);

            Assert.AreEqual(plane.ProductionYear, 1997);
            Assert.AreEqual(plane.Brand, "Audi");
            Assert.AreEqual(plane.KerbWeight, 300);
            Assert.AreEqual(plane.MaxVelocity, 300);
            Assert.AreEqual(plane.Color, Color.Pink);
            Assert.AreEqual(plane.EngineType, EngineType.Diesel);
        }
    }
}
