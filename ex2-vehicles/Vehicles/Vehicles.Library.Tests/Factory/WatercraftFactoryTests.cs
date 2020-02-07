using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Factory;

namespace Vehicles.Library.Tests.Factory
{
    [TestClass]
    public class WatercraftFactoryTests
    {
        [TestMethod]
        public void WatercraftFactoryCreatesAircraftCarrierTest()
        {
            var factory = new WatercraftFactory();
            var aircraftCarrier = factory.CreateVehicle<AircraftCarrier>();

            Assert.IsInstanceOfType(aircraftCarrier, typeof(AircraftCarrier));
        }

        [TestMethod]
        public void WatercraftFactoryCreatesBoatTest()
        {
            var factory = new WatercraftFactory();
            var boat = factory.CreateVehicle<Boat>();

            Assert.IsInstanceOfType(boat, typeof(Boat));
        }

        [TestMethod]
        public void WatercraftFactoryIsASingletonTest()
        {
            var factory = WatercraftFactory.Instance;
            var secondFactory = WatercraftFactory.Instance;

            Assert.IsTrue(factory == secondFactory);
        }
    }
}
