using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Builders;
using Vehicles.Library.Enums;

namespace Vehicles.Library.Tests.Builders
{
    [TestClass]
    public class DroneBuilderTests
    {
        [TestMethod]
        public void DroneBuilderBuildsProperDroneTest()
        {
            var drone = new DroneBuilder();

            var result = drone.SetProductionYear(1997)
                .SetBrand("Audi")
                .SetKerbWeight(1000)
                .SetColor(Color.Pink)
                .SetMaxVelosity(300)
                .Build();

            Assert.AreEqual(1997, result.ProductionYear);
            Assert.AreEqual("Audi", result.Brand);
            Assert.AreEqual(1000, result.KerbWeight);
            Assert.AreEqual(Color.Pink, result.Color);
            Assert.AreEqual(300, result.MaxVelocity);
        }
    }
}
