namespace ClientService
{
    public class CustomerService
    {
        private readonly IOrdering ordering;
        private readonly IBilling billing;

        public CustomerService(IOrdering ordering, IBilling billing)
        {
            this.ordering = ordering;
            this.billing = billing;
        }

        public void UpdateAddress(Client client, Adress newAddress)
        {
            ordering.UpdateAdress(client, newAddress);
        }
        public void AddOption(Order order, Option option)
        {
            billing.AddOption(order, option);
        }
    }
}
