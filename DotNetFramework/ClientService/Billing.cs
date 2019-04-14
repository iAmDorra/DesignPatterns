namespace ClientService
{
    internal class Billing : IBilling
    {
        public void AddOption(Order order, Option option)
        {
            order.AddNewOption(option);
        }

        public void Edit(Order order)
        {
            // Edit order
        }
    }
}
