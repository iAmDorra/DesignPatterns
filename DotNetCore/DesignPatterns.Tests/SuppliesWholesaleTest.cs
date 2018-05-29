using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using SuppliesWholesale;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class SuppliesWholesaleTest
    {
        [TestMethod]
        public void Should_clone_order()
        {
            var order = new Order(10, "testORder");
            var clonedOrder = order.Clone();

            Check.That(clonedOrder.Id).IsEqualTo(order.Id);
            Check.That(clonedOrder.Label).IsEqualTo(order.Label);
        }
    }
}
