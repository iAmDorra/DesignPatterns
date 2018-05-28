namespace ClientService
{
    internal class Ordering : IOrdering
    {
        public void UpdateAdress(Client client, Adress newAdress)
        {
            client.SetAdress(newAdress);
        }
    }
}
