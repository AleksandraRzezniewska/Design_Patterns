using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Factory;

namespace Vehicles.Library.Tests.Factory
{
    [TestClass]
    public class LandcraftFactoryTests
    {
        [TestMethod]
        public void LandcraftFactoryCreatesBikeTest()
        {
            var factory = new LandcraftFactory();
            var bike = factory.CreateVehicle<Bike>();

            Assert.IsInstanceOfType(bike, typeof(Bike));
        }

        [TestMethod]
        public void LandcraftFactoryCreatesCarTest()
        {
            var factory = new LandcraftFactory();
            var car = factory.CreateVehicle<Car>();

            Assert.IsInstanceOfType(car, typeof(Car));
        }

        [TestMethod]
        public void LandcraftFactoryCreatesMotorbikeTest()
        {
            var factory = new LandcraftFactory();
            var motorbike = factory.CreateVehicle<Motorbike>();

            Assert.IsInstanceOfType(motorbike, typeof(Motorbike));
        }

        [TestMethod]
        public void LandcraftFactoryCreatesTrainTest()
        {
            var factory = new LandcraftFactory();
            var train = factory.CreateVehicle<Train>();

            Assert.IsInstanceOfType(train, typeof(Train));
        }

        [TestMethod]
        public void LandcraftFactoryIsASingletonTest()
        {
            var factory = LandcraftFactory.Instance;
            var secondFactory = LandcraftFactory.Instance;

            Assert.IsTrue(factory == secondFactory);
        }
    }
}
