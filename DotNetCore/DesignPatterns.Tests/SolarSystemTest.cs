using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarSystem;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class SolarSystemTest
    {
        //[TestMethod]
        public void ShouldContainsOnlyOneSun()
        {
            var firstSun = new Sun();
            var secondSun = new Sun();
            
            Assert.AreEqual(secondSun, firstSun);
        }
    }
}
