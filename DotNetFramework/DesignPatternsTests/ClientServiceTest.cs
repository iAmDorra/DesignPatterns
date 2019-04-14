using ClientService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class ClientServiceTest
    {
        [TestMethod]
        public void Should_call_billing_when_adding_option_with_customerService()
        {
            // Ordering and Billing are internal so I should mock them
            //var ordering = new Ordering();
            IOrdering ordering = Substitute.For<IOrdering>();
            IBilling billing = Substitute.For<IBilling>();
            var customerService = new CustomerService(ordering, billing);

            Option option = new Option();
            Order order = new Order();
            customerService.AddOption(order, option);

            // Check that billing received one call with the same parameters
            billing.Received(1).AddOption(order, option);
        }

        [TestMethod]
        public void Should_call_ordering_when_adding_option_with_customerService()
        {
            IOrdering ordering = Substitute.For<IOrdering>();
            IBilling billing = Substitute.For<IBilling>();
            var customerService = new CustomerService(ordering, billing);

            Client client = new Client();
            Adress newAdress = new Adress();
            customerService.UpdateAddress(client, newAdress);

            // Check that billing received one call with the same parameters
            ordering.Received(1).UpdateAdress(client, newAdress);
        }
    }
}
