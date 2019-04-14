using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using SolarSystem;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class SolarSystemTest
    {
        [TestMethod]
        public void ShouldContainsOnlyOneSun()
        {
            var firstSun = Sun.Instance;
            var secondSun = Sun.Instance;

            Check.That(firstSun).IsEqualTo(secondSun);
        }
    }
}
