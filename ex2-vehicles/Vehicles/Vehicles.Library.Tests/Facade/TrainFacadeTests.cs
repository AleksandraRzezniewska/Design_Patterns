using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Enums;
using Vehicles.Library.Facade;

namespace Vehicles.Library.Tests.Facade
{
    [TestClass]
    public class TrainFacadeTests
    {
        [TestMethod]
        public void TrainFacadeReturnsProperTrainTest()
        {
            var trainFacade = new TrainFacade();
            var train = trainFacade.CreateTrain(1997, "Audi", 300, 300, Guid.NewGuid(), Color.Pink, EngineType.Diesel);

            Assert.AreEqual(train.ProductionYear, 1997);
            Assert.AreEqual(train.Brand, "Audi");
            Assert.AreEqual(train.KerbWeight, 300);
            Assert.AreEqual(train.MaxVelocity, 300);
            Assert.AreEqual(train.Color, Color.Pink);
            Assert.AreEqual(train.EngineType, EngineType.Diesel);
        }
    }
}
