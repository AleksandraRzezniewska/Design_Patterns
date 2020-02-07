using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Strategy;

namespace Vehicles.Library.Tests.Strategy
{
    [TestClass]
    public class FlyStrategyTests
    {
        [TestMethod]
        public void FlyStrategyReturnsFlyTest()
        {
            var flyStrategy = new FlyStrategy();

            var result = flyStrategy.Move();

            Assert.AreEqual(result, "Fly");
        }
    }
}
