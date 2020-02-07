using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Decorator;

namespace Vehicles.Library.Tests.Decorator
{
    [TestClass]
    public class ArmourDecoratorTests
    {
        [TestMethod]
        public void ArmourDecoratorAdds200ToShield()
        {
            var car = new Car();
            var carWithShield = new ArmourDecorator(car);

            Assert.AreEqual(200, carWithShield.Shield());
        }
    }
}
