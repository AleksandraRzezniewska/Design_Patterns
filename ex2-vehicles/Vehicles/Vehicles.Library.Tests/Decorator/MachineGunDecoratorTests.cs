using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Decorator;

namespace Vehicles.Library.Tests.Decorator
{
    [TestClass]
    public class MachineGunDecoratorTests
    {
        [TestMethod]
        public void ArmourDecoratorAdds100ToWeapon()
        {
            var car = new Car();
            var carWithWeapon = new MachineGunDecorator(car);

            Assert.AreEqual(100, carWithWeapon.Weapon());
        }
    }
}
