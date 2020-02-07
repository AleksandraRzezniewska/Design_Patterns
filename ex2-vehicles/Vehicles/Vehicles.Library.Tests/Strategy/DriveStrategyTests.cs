using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Strategy;

namespace Vehicles.Library.Tests.Strategy
{
    [TestClass]
    public class DriveStrategyTests
    {
        [TestMethod]
        public void DriveStrategyReturnsDriveTest()
        {
            var driveStrategy = new DriveStrategy();

            var result = driveStrategy.Move();

            Assert.AreEqual(result, "Drive");
        }
    }
}
