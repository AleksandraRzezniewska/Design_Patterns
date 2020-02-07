using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Strategy;

namespace Vehicles.Library.Tests.Strategy
{
    [TestClass]
    public class SwimStrategyTests
    {
        [TestMethod]
        public void SwimStrategyReturnsSwimTest()
        {
            var swimStrategy = new SwimStrategy();

            var result = swimStrategy.Move();

            Assert.AreEqual(result, "Swim");
        }
    }
}
