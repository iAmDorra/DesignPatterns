namespace ClientService
{
    public class Ordering
    {
        public void UpdateAdress(Client client, Adress newAdress)
        {
            client.SetAdress(newAdress);
        }
    }
}
