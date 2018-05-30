using CrepeMaker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class CrepeMakerTest
    {
        [TestMethod]
        public void Should_calculate_the_price_of_a_chocolate_crepe()
        {
            var crepe = new Chocolate(2, new Crepe(2.5));
            var price = crepe.GetPrice();
            Check.That(price).IsEqualTo(4.5);
        }

        [TestMethod]
        public void Should_calculate_the_price_of_a_chocolate_chantilly_waffle()
        {
            var waffle = new Chocolate(2, new Chantilly(2, new Waffle(2.5)));
            var price = waffle.GetPrice();
            Check.That(price).IsEqualTo(6.5);
        }
    }
}
