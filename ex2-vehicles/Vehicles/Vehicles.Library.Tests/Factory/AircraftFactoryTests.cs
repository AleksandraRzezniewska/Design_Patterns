using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Factory;

namespace Vehicles.Library.Tests.Factory
{
    [TestClass]
    public class AircraftFactoryTests
    {
        [TestMethod]
        public void AircraftFactoryCreatesPlaneTest()
        {
            var factory = new AircraftFactory();
            var plane = factory.CreateVehicle<Plane>();

            Assert.IsInstanceOfType(plane, typeof(Plane));
        }

        [TestMethod]
        public void AircraftFactoryCreatesDroneTest()
        {
            var factory = new AircraftFactory();
            var drone = factory.CreateVehicle<Drone>();

            Assert.IsInstanceOfType(drone, typeof(Drone));
        }

        [TestMethod]
        public void AircraftFactoryCreatesRocketTest()
        {
            var factory = new AircraftFactory();
            var rocket = factory.CreateVehicle<Rocket>();

            Assert.IsInstanceOfType(rocket, typeof(Rocket));
        }

        [TestMethod]
        public void AircraftFactoryIsASingletonTest()
        {
            var factory = AircraftFactory.Instance;
            var secondFactory = AircraftFactory.Instance;

            Assert.IsTrue(factory == secondFactory);
        }
    }
}
